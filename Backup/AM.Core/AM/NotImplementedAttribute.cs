/* NotImplementedAttribute.cs -- marks classes and class members as not-implemented.
   Ars Magna project, https://www.assembla.com/spaces/arsmagna */

#region Using directives

using System;

#endregion

namespace AM
{
    /// <summary>
    /// Marks classes and class members as not-implemented.
    /// </summary>
    /// <example>
    /// Here is small example of <see cref="NotImplementedAttribute"/>
    /// usage.
    /// <code>
    /// [NotImplemented]
    /// public Employyee FindEmployee ( string name )
    /// {
    ///		throw NotImplementedException ();
    /// }
    /// </code>
    /// </example>
    /// <seealso cref="TodoAttribute"/>
    /// <seealso cref="DoneAttribute"/>
    [Done]
    [AttributeUsage ( AttributeTargets.All, AllowMultiple = false,
        Inherited = false )]
    public sealed class NotImplementedAttribute : Attribute
    {
        #region Properties

        private string _note;

        /// <summary>
        /// Gets the note.
        /// </summary>
        public string Note
        {
            get
            {
                return _note;
            }
        }

        #endregion

        #region Construction

        /// <summary>
        /// Initializes a new instance of the 
        /// <see cref="T:NotImplementedAttribute"/> class
        /// leaving note unassigned.
        /// </summary>
        public NotImplementedAttribute ( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the 
        /// <see cref="T:NotImplementedAttribute"/> class
        /// and assignes specified note.
        /// </summary>
        /// <param name="note">The note.</param>
        public NotImplementedAttribute ( string note )
        {
            _note = note;
        }

        #endregion
    }
}
