using Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using ZEngine.Common.MarkerAttribute;

namespace ZEngine.Items.Impl
{
    /// <summary>
    /// 
    /// The standard implementation of the <see cref="IItemTypeManager"/>.
    /// 
    /// ID's of items are unique but only within the scope of an <see cref="ItemTypeManager"/>.
    /// If you are using static ID's make sure to keep those as low as possible... 
    /// your range for dynamic items will be limited to long.MaxValue - highest ID.
    /// 
    /// Will log a warning if two items use the same ID.
    /// 
    /// </summary>
    [NotThreadSafe]
    public class ItemTypeManager : IItemTypeManager
    {
        private static readonly Logger logger = Logger.Of(typeof(ItemTypeManager));

        private Dictionary<long, IItemType> itemsById = new Dictionary<long, IItemType>();
        private Stack<long> freeIDs = new Stack<long>();
        private long maxID = long.MinValue;

        public IItemType Get(long id)
        {
            return itemsById[id];
        }

        public IItemType GetByName(string name)
        {
            return itemsById.Values.First(item => item.Name.Equals(name));
        }

        public void Register(IItemType item)
        {
            if(itemsById.ContainsKey(item.ID))
            {
                logger.Warn($"ID {item.ID} already used by item {itemsById[item.ID].Name} --> will be overriden by {item.Name}");
            }

            itemsById.Add(item.ID, item);

            maxID = Math.Max(item.ID, maxID);
        }

        public void Unregister(IItemType item)
        {
            itemsById.Remove(item.ID);

            freeIDs.Push(item.ID);
        }

        public long GetNextID()
        {
            if(freeIDs.Count > 0)
            {
                return freeIDs.Pop();
            }
            else
            {
                return ++maxID;
            }
        }

    }
}
