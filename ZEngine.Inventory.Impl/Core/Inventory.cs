using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using ZEngine.Common.Utils.Collections;
using ZEngine.Items.Core;

namespace ZEngine.Inventory.Core.Impl
{
    /// <summary>
    /// Standard implementation of <see cref="IInventory"/>
    /// 
    /// - infinite space
    /// - grouped by type
    /// </summary>
    public class Inventory : IInventory
    {
        public IImmutableList<IItem> Items => itemsByType.Values.SelectMany(x => x).ToImmutableList();

        /// <guide>
        /// The operation which will be performed the most is checking whether the inventory contains an item of a certain type.
        /// Hence we store them by type.
        /// </guide>
        private IDictionary<int, IList<IItem>> itemsByType = new Dictionary<int, IList<IItem>>();

        public bool Add(IItem item)
        {
            itemsByType.PutIfAbsent(item.ItemType.ID, (int id) => new List<IItem>()).Add(item);

            return true;
        }

        public bool Remove(IItem item)
        {
            if(itemsByType.TryGetValue(item.ItemType.ID, out IList<IItem> currentItems))
            {
                currentItems.Remove(item);
                if(currentItems.Count == 0)
                {
                    itemsByType.Remove(item.ItemType.ID);
                }

                return true;
            }

            return false;
        }
    }
}
