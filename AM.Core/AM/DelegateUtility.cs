/* DelegateUtility.cs -- delegate manipulation helpers.
   Ars Magna project, https://www.assembla.com/spaces/arsmagna */

#region Using directives

using System;
using System.Reflection;

#endregion

namespace AM
{
    /// <summary>
    /// <see cref="Delegate"/> manipulation helper methods.
    /// </summary>
    /// <example>
    /// <para>Following code shows how to store and restore delegates.
    /// </para>
    /// <code>
    /// private void _button_Click ( object sender, EventArgs ea )
    /// {
    ///	MessageBox.Show ( "Button clicked" );
    /// }
    /// 
    /// public void SaveDelegate ()
    /// {
    ///	EventHandler handler = _button_Click;
    ///	string text = DelegateUtility.DelegateToString ( handler );
    ///	File.WriteAllText ( "delegate.txt", text );
    /// }
    /// 
    /// public void RestoreDelegate ()
    /// {
    ///	string text = File.ReadAllText ( "delegate.txt" );
    ///	EventHandler handler = DelegateUtility.StringToDelegate ( this, text );
    ///	_button1.Click += handler;
    /// }
    /// </code>
    /// </example>
    public static class DelegateUtility
    {
        #region Public methods

        /// <summary>
        /// Converts <see cref="Delegate"/> to a <see cref="String"/>
        /// (e. g. for XML serialization).
        /// </summary>
        /// <param name="pointer">Delegate to convert.</param>
        /// <remarks>Looses information about delegate target.
        /// </remarks>
        /// <returns><see cref="System.String"/> that contains
        /// information about delegate type and method name.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="pointer"/> is <c>null</c>.
        /// </exception>
        public static string DelegateToString ( Delegate pointer )
        {
            ArgumentUtility.NotNull
                (
                 pointer,
                 "pointer" );
            MethodInfo method = pointer.Method;
            Type type = method.DeclaringType;
            string result = string.Format
                (
                 "{0}|{1}|{2}",
                 pointer.GetType ()
                        .FullName,
                 type.FullName,
                 method.Name );
            return result;
        }

        /// <summary>
        /// Restores <see cref="Delegate"/> from its string representation
        /// obtained from <see cref="DelegateToString"/> method.
        /// </summary>
        /// <param name="target">The delegate target (<c>null</c>
        /// for static methods).</param>
        /// <param name="pointer">String representation of 
        /// <see cref="Delegate"/> (e. g. obtained from 
        /// <see cref="DelegateToString"/>) method.</param>
        /// <returns>Reconstructed <see cref="Delegate"/>.</returns>
        /// <remarks>Throws when the delegate can't be created.
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="pointer"/> is <c>null</c> or empty.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// <paramref name="pointer"/> is malformed.
        /// </exception>
        public static Delegate StringToDelegate
            (
            object target,
            string pointer )
        {
            ArgumentUtility.NotNullOrEmpty
                (
                 pointer,
                 "pointer" );
            string[] parts = pointer.Split ( '|' );
            if ( parts.Length != 3 )
            {
                throw new ArgumentException ( "pointer" );
            }
            string delegateName = parts [ 0 ];
            string typeName = parts [ 1 ];
            string methodName = parts [ 2 ];
            Type delegateType = Type.GetType ( delegateName );
            Type type = Type.GetType
                (
                 typeName,
                 true );
            BindingFlags flags = BindingFlags.Instance | BindingFlags.Static
                                 | BindingFlags.Public | BindingFlags.NonPublic;
            MethodInfo method = type.GetMethod
                (
                 methodName,
                 flags );
            Delegate result = Delegate.CreateDelegate
                (
                 delegateType,
                 target,
                 method,
                 true );
            return result;
        }

        #endregion
    }
}
