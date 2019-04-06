using System;
using System.Collections.Generic;
using System.Text;
using ZEngine.Common.Manager;

namespace ZEngine.Items
{
    /// <summary>
    /// A type of an item... e.g. a computer
    /// </summary>
    public interface IItem : IIdentifiable
    {
        /// <summary>
        /// The name of the item
        /// </summary>
        string Name { get; }
    }
}
