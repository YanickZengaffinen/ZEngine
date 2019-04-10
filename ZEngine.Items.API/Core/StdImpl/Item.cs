using System;
using System.Collections.Generic;
using System.Text;

namespace ZEngine.Items.Core.StdImpl
{
    /// <summary>
    /// Standard implementation of <see cref="IItem"/>
    /// </summary>
    public class Item : IItem
    {
        public IItemType ItemType { get; private set; }
        public string UnambiguousIdentifier => GetUnambiguousIdentifier();

        public Item(IItemType itemType)
        {
            this.ItemType = itemType;
        }

        /// <summary>
        /// Method that generates the unambiguous identifier for this item.
        /// Override this to generate your own unique identifier.
        /// </summary>
        /// 
        /// <guide>
        /// If you wish to have subtypes for items use "ItemType.ID:SubType.ID"
        /// Include all your dynamic item stats here... e.g. the health of a pickaxe.
        /// </guide>
        protected virtual string GetUnambiguousIdentifier()
        {
            return ItemType.ID.ToString();
        }
    }
}
