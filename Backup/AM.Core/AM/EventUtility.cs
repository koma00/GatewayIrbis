/* EventUtility.cs -- Useful routines for event manipulations.
   Ars Magna project, https://www.assembla.com/spaces/arsmagna */

#region Using directives

using System;

#endregion

namespace AM
{
    /// <summary>
    /// Useful routines for event manipulations.
    /// </summary>
    public static class EventUtility
    {
//		#region Delegates
//
//		/// <summary>
//		/// Delegate for event arguments creation.
//		/// </summary>
//		/// <typeparam name="T">Type of event arguments.</typeparam>
//		/// <returns></returns>
//		public delegate T CreateEventArgs <T> ()
//			where T : EventArgs;
//
//		#endregion

        #region Public methods

        /// <summary>
        /// Raises the specified handler.
        /// </summary>
        /// <param name="handler">The handler.</param>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        /// <typeparam name="T">Type of event arguments</typeparam>
        public static void Raise < T >
            (
            EventHandler < T > handler,
            object sender,
            T args ) where T : EventArgs
        {
            if ( handler != null )
            {
                handler
                    (
                     sender,
                     args );
            }
        }

        /// <summary>
        /// Raises the specified handler.
        /// </summary>
        /// <param name="handler">The handler.</param>
        /// <param name="sender">The sender.</param>
        /// <typeparam name="T">Type of event arguments.</typeparam>
        public static void Raise < T >
            (
            EventHandler < T > handler,
            object sender ) where T : EventArgs
        {
            if ( handler != null )
            {
                handler
                    (
                     sender,
                     null );
            }
        }

        /// <summary>
        /// Raises the specified handler.
        /// </summary>
        /// <param name="handler">The handler.</param>
        /// <typeparam name="T">Type of event arguments.</typeparam>
        public static void Raise < T > ( EventHandler < T > handler )
            where T : EventArgs
        {
            if ( handler != null )
            {
                handler
                    (
                     null,
                     null );
            }
        }

//		/// <summary>
//		/// Raises the specified handler.
//		/// </summary>
//		/// <param name="handler">The handler.</param>
//		/// <param name="sender">The sender.</param>
//		/// <param name="creator">The creator.</param>
//		/// <typeparam name="T">Type of event arguments.</typeparam>
//		public static void Raise <T>
//			(
//			EventHandler <T> handler,
//			object sender,
//			CreateEventArgs <T> creator
//			)
//			where T : EventArgs
//		{
//			ArgumentUtility.NotNull ( creator, "creator" );
//			if ( handler != null )
//			{
//				handler ( sender, creator () );
//			}
//		}
//
//		/// <summary>
//		/// Raises the specified handler.
//		/// </summary>
//		/// <param name="handler">The handler.</param>
//		/// <param name="creator">The creator.</param>
//		/// <typeparam name="T">Type of event arguments.</typeparam>
//		public static void Raise <T>
//			(
//			EventHandler <T> handler,
//			CreateEventArgs <T> creator
//			)
//			where T : EventArgs
//		{
//			ArgumentUtility.NotNull ( creator, "creator" );
//			if ( handler != null )
//			{
//				handler ( null, creator () );
//			}
//		}

        #endregion
    }
}
