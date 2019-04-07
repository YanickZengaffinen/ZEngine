﻿using ZEngine.Common.Manager.StdImpl;

namespace ZEngine.Items.Core.StdImpl
{
    /// <summary>
    /// Standard implementation of <see cref="IItemType"/>
    /// </summary>
    public class ItemType : IItemType
    {
        public long ID { get; }

        public string Name { get; }

        public ItemType(long id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        /// <summary>
        /// C'tor for itemtypes that are created at runtime
        /// </summary>
        /// <param name="name"></param>
        public ItemType(string name) : 
            this(ManagerRegistry.Instance.GetManager<IItemType>().GetNextID(), name) { }
    }
}
