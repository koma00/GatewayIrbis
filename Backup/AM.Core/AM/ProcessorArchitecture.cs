/* ProcessorArchitecture.cs -- processor architecture enumeration.
   Ars Magna project, https://www.assembla.com/spaces/arsmagna */

#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace AM
{
    /// <summary>
    /// Processor architecture enumeration.
    /// </summary>
    public enum ProcessorArchitecture
    {
        /// <summary>
        /// Can't determine processor architecture.
        /// </summary>
        Unknown,

        /// <summary>
        /// Intel x86 or compatible processor architecture.
        /// </summary>
        X86,

        /// <summary>
        /// AMD x64 or compatible processor architecture.
        /// </summary>
        X64,

        /// <summary>
        /// Intel IA64 or compatible processor architecture.
        /// </summary>
        IA64
    }
}
