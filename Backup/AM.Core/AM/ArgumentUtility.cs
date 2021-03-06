/* ArgumentUtility.cs -- Helper class to simplify function argument checking.
   ArsMagna project, https://www.assembla.com/spaces/arsmagna */

#region Using directives

using System;
using System.Diagnostics;
using System.IO;

#endregion

namespace AM
{
    /// <summary>
    /// Helper class to simplify function argument checking.
    /// </summary>
    [Done]
    public static class ArgumentUtility
    {
        #region Public methods

        /// <summary>
        /// Check whether <paramref name="value"/> is not defined.
        /// </summary>
        /// <typeparam name="T">Parameter type (must be System.Enum
        /// descendant).</typeparam>
        /// <param name="value">Value to check.</param>
        /// <param name="argumentName">Function argument name.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Throws <see cref="T:System.ArgumentOutOfRangeException"/>.
        /// </exception>
        public static void Defined < T >
            (
            T value,
            string argumentName ) where T : struct
        {
            if ( !Enum.IsDefined
                      (
                       typeof ( T ),
                       value ) )
            {
                throw new ArgumentOutOfRangeException ( argumentName );
            }
        }

        /// <summary>
        /// Checks whether specified files exists.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="argumentName">Name of the argument.</param>
        public static void FileExists
            (
            string path,
            string argumentName )
        {
            NotNull
                (
                 path,
                 argumentName );
            if ( !File.Exists ( path ) )
            {
                throw new FileNotFoundException ( argumentName + " : " + path );
            }
        }

        /// <summary>
        /// Checks whether <paramref name="argument"/> fits into
        /// specified range <paramref name="from"/> to <paramref name="to"/>.
        /// </summary>
        /// <param name="argument">The argument.</param>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        /// <param name="argumentName">Name of the argument.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Throws <see cref="T:System.ArgumentOutOfRangeException"/>.
        /// </exception>
        public static void InRange
            (
            int argument,
            int from,
            int to,
            string argumentName )
        {
            if ( ( argument < from )
                 || ( argument > to ) )
            {
                throw new ArgumentOutOfRangeException ( argumentName );
            }
        }

        /// <summary>
        /// Checks whether <paramref name="argument"/> fits into
        /// specified range <paramref name="from"/> to <paramref name="to"/>.
        /// </summary>
        /// <param name="argument">The argument.</param>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        /// <param name="argumentName">Name of the argument.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Throws <see cref="T:System.ArgumentOutOfRangeException"/>.
        /// </exception>
        public static void InRange
            (
            double argument,
            double from,
            double to,
            string argumentName )
        {
            if ( ( argument < from )
                 || ( argument > to ) )
            {
                throw new ArgumentOutOfRangeException ( argumentName );
            }
        }

        /// <summary>
        /// Check whether <paramref name="argument"/> is not negative.
        /// </summary>
        /// <param name="argument">Value to check.</param>
        /// <param name="argumentName">Function argument name.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Throws <see cref="T:System.ArgumentOutOfRangeException"/>.
        /// </exception>
        public static void Nonnegative
            (
            int argument,
            string argumentName )
        {
            if ( argument < 0 )
            {
                throw new ArgumentOutOfRangeException ( argumentName );
            }
        }

        /// <summary>
        /// Check whether <paramref name="argument"/> is not negative.
        /// </summary>
        /// <param name="argument">Value to check.</param>
        /// <param name="argumentName">Function argument name.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Throws <see cref="T:System.ArgumentOutOfRangeException"/>.
        /// </exception>
        public static void Nonnegative
            (
            long argument,
            string argumentName )
        {
            if ( argument < 0 )
            {
                throw new ArgumentOutOfRangeException ( argumentName );
            }
        }

        /// <summary>
        /// Check whether <paramref name="argument"/> is not negative.
        /// </summary>
        /// <param name="argument">Value to check.</param>
        /// <param name="argumentName">Function argument name.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Throws <see cref="T:System.ArgumentOutOfRangeException"/>.
        /// </exception>
        public static void Nonnegative
            (
            double argument,
            string argumentName )
        {
            if ( argument < 0.0 )
            {
                throw new ArgumentOutOfRangeException ( argumentName );
            }
        }

        /// <summary>
        /// Check whether <paramref name="argument"/> is null.
        /// </summary>
        /// <typeparam name="T">Parameter type.</typeparam>
        /// <param name="argument">Value to check.</param>
        /// <param name="argumentName">Function argument name.</param>
        /// <exception cref="T:System.ArgumentNullException">Throws
        /// <see cref="T:System.ArgumentNullException"/>.</exception>
        [DebuggerStepThrough]
        public static void NotNull < T >
            (
            T argument,
            string argumentName ) where T : class
        {
            if ( argument == null )
            {
                throw new ArgumentNullException ( argumentName );
            }
        }

        /// <summary>
        /// Check whether <paramref name="argument"/>is null or empty.
        /// </summary>
        /// <param name="argument">String to check.</param>
        /// <param name="argumentName">Name of the argument.</param>
        /// <exception cref="T:System.ArgumentNullException">Throws
        /// <see cref="T:System.ArgumentNullException"/>.</exception>
        [DebuggerStepThrough]
        public static void NotNullOrEmpty
            (
            string argument,
            string argumentName )
        {
            if ( string.IsNullOrEmpty ( argument ) )
            {
                throw new ArgumentNullException ( argumentName );
            }
        }

        /// <summary>
        /// Check whether <paramref name="argument"/>is null or empty.
        /// </summary>
        /// <param name="argument">Array to check.</param>
        /// <param name="argumentName">Name of the argument.</param>
        /// <exception cref="T:System.ArgumentNullException">Throws
        /// <see cref="T:System.ArgumentNullException"/>.</exception>
        [DebuggerStepThrough]
        public static void NotNullOrEmpty
            (
            Array argument,
            string argumentName )
        {
            if ( ( argument == null )
                 || ( argument.Length == 0 ) )
            {
                throw new ArgumentNullException ( argumentName );
            }
        }

        /// <summary>
        /// Check whether <paramref name="argument"/> is positive.
        /// </summary>
        /// <param name="argument">The argument.</param>
        /// <param name="argumentName">Name of the argument.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Throws <see cref="T:System.ArgumentOutOfRangeException"/>.
        /// </exception>
        public static void Positive
            (
            int argument,
            string argumentName )
        {
            if ( argument <= 0 )
            {
                throw new ArgumentOutOfRangeException ( argumentName );
            }
        }

        /// <summary>
        /// Check whether <paramref name="argument"/> is positive.
        /// </summary>
        /// <param name="argument">The argument.</param>
        /// <param name="argumentName">Name of the argument.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Throws <see cref="T:System.ArgumentOutOfRangeException"/>.
        /// </exception>
        public static void Positive
            (
            double argument,
            string argumentName )
        {
            if ( argument <= 0.0 )
            {
                throw new ArgumentOutOfRangeException ( argumentName );
            }
        }

        #endregion
    }
}
