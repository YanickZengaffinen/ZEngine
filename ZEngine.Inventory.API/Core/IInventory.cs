using System.Collections.Generic;
using System.Collections.Immutable;
using ZEngine.Common.MarkerAttribute;
using ZEngine.Items.Core;

namespace ZEngine.Inventory.Core
{
    public interface IInventory
    {
        /// <summary>
        /// Add an item to the inventory
        /// </summary>
        bool Add(IItem item);

        /// <summary>
        /// Removes an item from the inventory
        /// </summary>
        bool Remove(IItem item);
        
        /// <summary>
        /// Getter for all items
        /// </summary>
        [Immutable]
        IImmutableList<IItem> Items { get; }
    }
}
