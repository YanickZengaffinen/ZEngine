using System;
using ZEngine.Common.MarkerAttribute;

namespace ZEngine.Items.Core.StdImpl
{
    /// <summary>
    /// Standardimplementation of <see cref="IItemStack"/>
    /// 
    /// - not limited in size
    /// </summary>
    public class ItemStack : IItemStack
    {
        public uint Size { get; private set; }

        [Notnull]
        public IItem Template { get; }
        
        public IItemType ItemType => Template.ItemType;
        public string UnambiguousIdentifier => Template.UnambiguousIdentifier;

        public ItemStack(IItem template, uint size = 1)
        {
            this.Template = template;
            this.Size = size;
        }

        public uint Add(uint amount)
        {
            Size += amount;
            return amount;
        }

        public uint Remove(uint amount)
        {
            Size -= amount;
            return Math.Min(Size + amount, amount);
        }
    }
}
