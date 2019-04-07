using System.Collections.Generic;
using System.Linq;
using ZEngine.Inventory.Core;
using ZEngine.Items;

namespace ZEngine.Inventory.Impl.Core
{
    /// <summary>
    /// A simple inventory
    /// - unlimited space
    /// - unordered
    /// </summary>
    public class Inventory : IInventory
    {
        private Dictionary<long, ulong> itemAmounts = new Dictionary<long, ulong>(); //the amount of items per type

        public long ID { get; private set; } = long.MinValue;
        public ulong this[long id] => itemAmounts.ContainsKey(id) ? itemAmounts[id] : 0;
        public IList<long> ItemIDs => itemAmounts.Keys.ToList();

        public ulong TryAdd(IItemType item, ulong amount = 1)
        {
            if(itemAmounts.ContainsKey(item.ID))
            {
                itemAmounts[item.ID] += amount;
            }
            else
            {
                itemAmounts.Add(item.ID, amount);
            }

            return amount;
        }

        public ulong TryRemove(IItemType item, ulong amount = 1)
        {
            if (itemAmounts.TryGetValue(item.ID, out ulong currentAmount))
            {
                if (currentAmount > amount)
                {
                    itemAmounts[item.ID] -= amount;
                    return amount;
                }
                else
                {
                    itemAmounts.Remove(item.ID);
                    return currentAmount;
                }
            }

            return 0;
        }
    }
}
