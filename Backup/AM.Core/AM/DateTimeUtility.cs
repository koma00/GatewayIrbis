/* DateTimeUtility.cs -- set of date/time manipulation routines
   Ars Magna project, https://www.assembla.com/spaces/arsmagna */

#region Using directives

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

#endregion

namespace AM
{
    /// <summary>
    /// Set of date/time manipulation routines.
    /// </summary>
    [Done]
    public static class DateTimeUtility
    {
        #region Properties

        /// <summary>
        /// Searches maximal date/time from given ones.
        /// </summary>
        /// <param name="first">First date/time.</param>
        /// <param name="other">Other dates/times.</param>
        /// <returns>Maximum.</returns>
        public static DateTime Max
            (
            DateTime first,
            params DateTime[] other )
        {
            DateTime result = first;
            foreach ( DateTime time in other )
            {
                if ( time > result )
                {
                    result = time;
                }
            }
            return result;
        }

        /// <summary>
        /// Searches minimal date/time from given ones.
        /// </summary>
        /// <param name="first">First date/time.</param>
        /// <param name="other">Other dates/times.</param>
        /// <returns>Minimum.</returns>
        public static DateTime Min
            (
            DateTime first,
            params DateTime[] other )
        {
            DateTime result = first;
            foreach ( DateTime time in other )
            {
                if ( time < result )
                {
                    result = time;
                }
            }
            return result;
        }

        /// <summary>
        /// Gets the date of next month first day.
        /// </summary>
        /// <value>Next month first day.</value>
        public static DateTime NextMonth
        {
            [DebuggerStepThrough]
            get
            {
                return ThisMonth.AddMonths ( 1 );
            }
        }

        /// <summary>
        /// Gets the date of next year first day.
        /// </summary>
        /// <value>Next year first day.</value>
        public static DateTime NextYear
        {
            [DebuggerStepThrough]
            get
            {
                return ThisYear.AddYears ( 1 );
            }
        }

        /// <summary>
        /// Gets the date of previous month first day.
        /// </summary>
        /// <value>Previous month first day.</value>
        public static DateTime PreviousMonth
        {
            [DebuggerStepThrough]
            get
            {
                return ThisMonth.AddMonths ( -1 );
            }
        }

        /// <summary>
        /// Gets the date of previous year first day.
        /// </summary>
        /// <value>Previous year first day.</value>
        public static DateTime PreviousYear
        {
            [DebuggerStepThrough]
            get
            {
                return ThisYear.AddYears ( -1 );
            }
        }

        /// <summary>
        /// Gets the date of current month first day.
        /// </summary>
        /// <value>Current month first day.</value>
        public static DateTime ThisMonth
        {
            [DebuggerStepThrough]
            get
            {
                DateTime today = DateTime.Today;
                return new DateTime
                    (
                    today.Year,
                    today.Month,
                    1 );
            }
        }

        /// <summary>
        /// Gets the date of current year first day.
        /// </summary>
        /// <value>Current year first day.</value>
        public static DateTime ThisYear
        {
            [DebuggerStepThrough]
            get
            {
                return new DateTime
                    (
                    DateTime.Today.Year,
                    1,
                    1 );
            }
        }

        /// <summary>
        /// Gets the date for tomorrow.
        /// </summary>
        /// <value>Tomorrow date.</value>
        public static DateTime Tomorrow
        {
            [DebuggerStepThrough]
            get
            {
                return DateTime.Today.AddDays ( 1.0 );
            }
        }

        /// <summary>
        /// Gets the for yesterday.
        /// </summary>
        /// <value>Yesterday date.</value>
        public static DateTime Yesterday
        {
            [DebuggerStepThrough]
            get
            {
                return DateTime.Today.AddDays ( -1.0 );
            }
        }

        #endregion

        #region Private members

        private static readonly DateTime _unixStart = new DateTime
            (
            1970,
            1,
            1 );

        #endregion

        #region Public methods

        /// <summary>
        /// Переводит указанную дату в формат Unix.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static long ToUnixTime ( DateTime dateTime )
        {
            return (long) ( ( dateTime - _unixStart ).TotalSeconds );
        }

        #endregion
    }
}
