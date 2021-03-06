/* StreamCollection.cs --  
   Ars Magna project, https://www.assembla.com/spaces/arsmagna */

#region Using directives

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

#endregion

namespace AM
{
    /// <summary>
    /// Little automation: class that dispose all 
    /// marked fields during finalization.
    /// </summary>
    [Serializable]
    public class DisposableObject : IDisposable
    {
        #region Delegates

        private delegate void Disposer ( object obj );

        #endregion

        #region Properties

        /// <summary>
        /// Is the instance disposed.
        /// </summary>
        public bool Disposed
        {
            [DebuggerStepThrough]
            get
            {
                return _disposed;
            }
        }

        private bool _disposeByReflection;

        ///<summary>
        /// 
        ///</summary>
        public bool DisposeByReflection
        {
            [DebuggerStepThrough]
            get
            {
                return _disposeByReflection;
            }
        }

        #endregion

        #region Construction

        /// <summary>
        /// 
        /// </summary>
        public DisposableObject ( )
            : this ( false )
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposeByReflection"></param>
        public DisposableObject ( bool disposeByReflection )
        {
            _disposeByReflection = disposeByReflection;
            if ( !disposeByReflection )
            {
                _GenerateDisposer ();
            }
        }

        /// <summary>
        /// Destructor.
        /// </summary>
        ~DisposableObject ( )
        {
            Dispose ( false );
        }

        #endregion

        #region Private members

        private static Dictionary < Type, Disposer > _disposers =
            new Dictionary < Type, Disposer > ();

        private bool _CheckMember
            (
            MemberInfo info,
            Type type )
        {
            if ( type.IsValueType )
            {
                return false;
            }
            Type iDisposable = type.GetInterface ( "IDisposable" );
            if ( iDisposable == null )
            {
                return false;
            }
            if ( !info.IsDefined
                      (
                       typeof ( AutoDisposeAttribute ),
                       true ) )
            {
                return false;
            }
            return true;
        }

        private void _ProcessValue ( ILGenerator il )
        {
            il.Emit ( OpCodes.Dup );
            Type iDisposable = typeof ( IDisposable );
            il.Emit
                (
                 OpCodes.Castclass,
                 iDisposable );
            Label label1 = il.DefineLabel ();
            Label label2 = il.DefineLabel ();
            il.Emit
                (
                 OpCodes.Brfalse_S,
                 label1 );
            il.EmitCall
                (
                 OpCodes.Callvirt,
                 iDisposable.GetMethod ( "Dispose" ),
                 null );
            il.Emit
                (
                 OpCodes.Br_S,
                 label2 );
            il.MarkLabel ( label1 );
            il.Emit ( OpCodes.Pop );
            il.MarkLabel ( label2 );
        }

        private void _OneField
            (
            ILGenerator il,
            FieldInfo field )
        {
            Type type = field.FieldType;
            if ( !_CheckMember
                      (
                       field,
                       type ) )
            {
                return;
            }
            il.Emit ( OpCodes.Ldarg_0 );
            il.Emit
                (
                 OpCodes.Ldfld,
                 field );
            _ProcessValue ( il );
            il.Emit ( OpCodes.Ldarg_0 );
            il.Emit ( OpCodes.Ldnull );
            il.Emit
                (
                 OpCodes.Stfld,
                 field );
        }

        private void _OneProperty
            (
            ILGenerator il,
            PropertyInfo prop )
        {
            Type type = prop.PropertyType;
            if ( !_CheckMember
                      (
                       prop,
                       type ) )
            {
                return;
            }
            il.Emit ( OpCodes.Ldarg_0 );
            MethodInfo getter = prop.GetGetMethod ();
            il.EmitCall
                (
                 OpCodes.Callvirt,
                 getter,
                 null );
            _ProcessValue ( il );
            MethodInfo setter = prop.GetSetMethod ();
            if ( setter != null )
            {
                il.Emit ( OpCodes.Ldarg_0 );
                il.Emit ( OpCodes.Ldnull );
                il.EmitCall
                    (
                     OpCodes.Callvirt,
                     setter,
                     null );
            }
        }

        private void _GenerateDisposer ( )
        {
            Type type = GetType ();
            if ( !_disposers.ContainsKey ( type ) )
            {
                lock ( _disposers )
                {
                    if ( !_disposers.ContainsKey ( type ) )
                    {
                        string methodName = "_dispose" + _disposers.Count;
                        DynamicMethod method = new DynamicMethod
                            (
                            methodName,
                            typeof ( void ),
                            new Type[]
                            {
                                typeof ( object )
                            },
                            type );
                        method.InitLocals = true;
                        ILGenerator il = method.GetILGenerator ();
                        FieldInfo[] fields = type.GetFields
                            ( BindingFlags.Public | BindingFlags.Instance );
                        foreach ( FieldInfo field in fields )
                        {
                            _OneField
                                (
                                 il,
                                 field );
                        }
                        PropertyInfo[] props = type.GetProperties
                            ( BindingFlags.Public | BindingFlags.Instance );
                        foreach ( PropertyInfo prop in props )
                        {
                            _OneProperty
                                (
                                 il,
                                 prop );
                        }
                        il.Emit ( OpCodes.Ret );
                        Disposer disposer =
                            (Disposer)
                            method.CreateDelegate ( typeof ( Disposer ) );
                        _disposers.Add
                            (
                             type,
                             disposer );
                    }
                }
            }
        }

        private bool _disposed;

        private static void _DisposeWithReflection ( object obj )
        {
            Type type = obj.GetType ();
            FieldInfo[] fields = type.GetFields
                (
                 BindingFlags.Public | BindingFlags.NonPublic
                 | BindingFlags.Instance );

            foreach ( FieldInfo field in fields )
            {
                if ( Attribute.IsDefined
                    (
                     field,
                     typeof ( AutoDisposeAttribute ) ) )
                {
                    object val = field.GetValue ( obj );
                    IDisposable di = val as IDisposable;

                    if ( di != null )
                    {
                        di.Dispose ();
                    }
                    if ( type.IsCOMObject )
                    {
                        Marshal.ReleaseComObject ( val );
                    }

                    // Is it necessary?
                    field.SetValue
                        (
                         obj,
                         null );
                }
            }
        }

        private static void _DisposeWithLCG ( object obj )
        {
            Type type = obj.GetType ();
            Disposer disposer = _disposers [ type ];
            disposer ( obj );
        }

        /// <summary>
        /// Calls <c>Dispose ()</c> for all fields marked with
        /// <see cref="AutoDisposeAttribute">AutoDispose attribute.</see>
        /// </summary>
        private void DisposeFields ( )
        {
            if ( !DisposeByReflection )
            {
                _DisposeWithLCG ( this );
            }
            else
            {
                _DisposeWithReflection ( this );
            }
        }

        /// <summary>
        /// Checks whether this instance disposed.
        /// </summary>
        protected void CheckDisposed ( )
        {
            if ( Disposed )
            {
                throw new ObjectDisposedException
                    (
                    GetType ()
                        .Name );
            }
        }

        #endregion

        #region Protected members

        /// <summary>
        /// Performs application-defined tasks associated with freeing, 
        /// releasing, or resetting unmanaged resources.
        /// </summary>
        /// <param name="disposing">Is method called from <c>Dispose()</c>.
        /// </param>
        protected virtual void Dispose ( bool disposing )
        {
            DisposeFields ();
        }

        /// <summary>
        /// Alias for <c>Dispose</c>.
        /// </summary>
        public virtual void Close ( )
        {
            Dispose ();
        }

        #endregion

        #region IDisposable members

        /// <summary>
        /// Performs application-defined tasks associated with freeing, 
        /// releasing, or resetting unmanaged resources.
        /// </summary>
        /// <remark>Thread-safe.</remark>
        public void Dispose ( )
        {
            lock ( this )
            {
                if ( !_disposed )
                {
                    _disposed = true;
                    Dispose ( true );
                    GC.SuppressFinalize ( this );
                }
            }
        }

        #endregion
    }
}
