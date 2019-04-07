using System.Collections;
using System.Collections.Generic;
using ZEngine.Common.Manager;
using ZEngine.Items;

namespace ZEngine.Inventory.Core
{
    public interface IInventory : IIdentifiable
    {
        /// <summary>
        /// The ids of all itemtypes that are present in this inventory
        /// </summary>
        IList<long> ItemIDs { get; }

        /// <summary>
        /// Indexer for the item amount of a specific type
        /// </summary>
        ulong this[long id] { get; }

        /// <summary>
        /// Try to add an item to the inventory
        /// </summary>
        /// <param name="item"></param>
        /// <param name="amount"></param>
        /// <returns> The amount of items added </returns>
        ulong TryAdd(IItemType item, ulong amount = 1);

        /// <summary>
        /// Try to remove a certain amount of items to the inventory
        /// </summary>
        /// <param name="item"></param>
        /// <param name="amount"></param>
        /// <returns> The amount of items removed </returns>
        ulong TryRemove(IItemType item, ulong amount = 1);
    }
}
