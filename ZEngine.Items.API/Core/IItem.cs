using System;
using System.Collections.Generic;
using System.Text;

namespace ZEngine.Items.Core
{
    public interface IItem
    {
        /// <summary>
        /// The type of this item
        /// </summary>
        IItemType ItemType { get; }

        /// <summary>
        /// An unambiguous identifier for this item..
        /// </summary>
        string UnambiguousIdentifier { get; }

    }
}
