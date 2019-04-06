using System;
using System.Collections.Generic;
using System.Linq;
using ZEngine.Common.Manager;
using ZEngine.Common.MarkerAttribute;
using ZEngine.Items.Manager;

namespace ZEngine.Items.Impl.Manager
{
    /// <summary>
    /// The standard implementation of the <see cref="IItemManager"/>
    /// </summary>
    [NotThreadSafe]
    public class ItemManager : IItemManager
    {
        private Dictionary<long, IItem> itemsById = new Dictionary<long, IItem>();

        public IItem Get(long id)
        {
            return itemsById[id];
        }

        public IItem GetByName(string name)
        {
            return itemsById.Values.First(item => item.Name.Equals(name));
        }

        public void Register(IItem item)
        {
            itemsById.Add(item.ID, item);
        }

        public void Unregister(IItem item)
        {
            itemsById.Remove(item.ID);
        }
    }
}
