using Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using ZEngine.Common.MarkerAttribute;
using ZEngine.Common.UID.StdImpl;

namespace ZEngine.Items.Manager.Impl
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

        private Dictionary<int, IItemType> itemsById = new Dictionary<int, IItemType>();
        private UIDManager idManager = new UIDManager();

        public IItemType Get(int id)
        {
            return itemsById[id];
        }

        public IItemType GetByName(string name)
        {
            return itemsById.Values.First(item => item.Name.Equals(name));
        }

        public void Register(IItemType itemType)
        {
            if(itemsById.ContainsKey(itemType.ID) || 
                (!idManager.Block(itemType.ID) && itemType.IsStaticID))
            {
                logger.Warn($"ID {itemType.ID} already used by item {itemsById[itemType.ID].Name} --> will be overriden by {itemType.Name}");
            }

            itemsById[itemType.ID] = itemType;
        }

        public void Unregister(IItemType itemType)
        {
            itemsById.Remove(itemType.ID);

            idManager.Free(itemType.ID);
        }

        /// <summary>
        /// Generate the id for an item
        /// </summary>
        /// <returns></returns>
        public int GenerateID()
        {
            return idManager.Generate();
        }

    }
}
