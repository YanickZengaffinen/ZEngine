using ZEngine.Common.Manager;
using ZEngine.Items;

namespace ZEngine.Inventory.Core
{
    public interface IInventory : IIdentifiable
    {
        /// <summary>
        /// Try to add an item to the inventory
        /// </summary>
        /// <returns> True if the item has been successfully added </returns>
        bool TryAdd(IItem item);

        /// <summary>
        /// Try to remove an item from the inventory
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool TryRemove(IItem item);
    }
}
