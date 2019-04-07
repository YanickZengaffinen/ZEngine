using ZEngine.Common.Manager;
using ZEngine.Items;

namespace ZEngine.Inventory.Core
{
    public interface IInventory : IIdentifiable
    {
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
