using System;
using System.Collections.Generic;
using System.Text;

namespace ZEngine.Items.Core.Util
{
    public static class ItemUtil
    {
        /// <summary>
        /// Merges the another itemstack into this stack
        /// </summary>
        /// <returns>The amount of items that were shifted from other to this</returns>
        public static uint Merge(this IItemStack stack, IItemStack other)
        {
            uint itemsAdded = 0;
            if (stack.UnambiguousIdentifier.Equals(other.UnambiguousIdentifier))
            {
                itemsAdded = stack.Add(other.Size);
                other.Remove(itemsAdded);
            }

            return itemsAdded;
        }

    }
}
