/* StringUtility.cs -- bunch of useful string manipulation routines.
   Ars Magna project, https://www.assembla.com/spaces/arsmagna */

#region Using directives

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace AM
{
    /// <summary>
    /// Bunch of useful string manipulation routines.
    /// </summary>
    public static class StringUtility
    {
        /// <summary>
        /// Merges the lines.
        /// </summary>
        /// <param name="lines">The lines.</param>
        /// <returns></returns>
        public static string JoinLines ( this IEnumerable < string > lines )
        {
            string result = string.Join
                (
                 Environment.NewLine,
                 lines.ToArray () );
            return result;
        }

        /// <summary>
        /// Сравнивает символы с точностью до регистра.
        /// </summary>
        /// <param name="one">Первый символ.</param>
        /// <param name="two">Второй символ.</param>
        /// <returns>Символы совпадают с точностью до регистра.</returns>
        public static bool SameChar
            (
            this char one,
            char two )
        {
#if PocketPC
			return (char.ToUpper(one) == char.ToUpper(two));
#else
            return ( char.ToUpperInvariant ( one )
                     == char.ToUpperInvariant ( two ) );
#endif
        }

        /// <summary>
        /// Сравнивает строки с точностью до регистра.
        /// </summary>
        /// <param name="one">Первая строка.</param>
        /// <param name="two">Вторая строка.</param>
        /// <returns>Строки совпадают с точностью до регистра.</returns>
        public static bool SameString
            (
            this string one,
            string two )
        {
            return string.Compare
                       (
                        one,
                        two,
                        StringComparison.OrdinalIgnoreCase ) == 0;
        }


        /// <summary>
        /// Разбивает строку по указанному разделителю.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="delimiter"></param>
        /// <returns></returns>
        public static string[] SplitFirst
            (
            this string line,
            char delimiter )
        {
            int index = line.IndexOf ( delimiter );
            string[] result = ( index < 0 )
                                  ? new[]
                                    {
                                        line
                                    }
                                  : new[]
                                    {
                                        line.Substring
                                            (
                                             0,
                                             index ),
                                        line.Substring ( index + 1 )
                                    };
            return result;
        }

        /// <summary>
        /// Splits the text into lines.
        /// </summary>
        /// <param name="text">Text to split.</param>
        /// <returns>Array of lines.</returns>
        public static string[] SplitLines ( this string text )
        {
            return text.Split
                (
                 new[]
                 {
                     Environment.NewLine
                 },
                 StringSplitOptions.RemoveEmptyEntries );
        }
    }
}
