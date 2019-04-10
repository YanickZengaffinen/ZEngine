using System;
using System.Collections.Generic;
using System.Text;

namespace ZEngine.Common.Manager
{
    /// <summary>
    /// Interfaces for all objects that are identifiable / have a unique ID
    /// </summary>
    public interface IIdentifiable
    {
        int ID { get; }

        /// <summary>
        /// Is the ID static or has it been generated at runtime
        /// </summary>
        bool IsStaticID { get; }
    }
}
