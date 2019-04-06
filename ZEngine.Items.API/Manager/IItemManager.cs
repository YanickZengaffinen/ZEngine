using System;
using System.Collections.Generic;
using System.Text;
using ZEngine.Common.Manager;

namespace ZEngine.Items.Manager
{
    /// <summary>
    /// Manager for <see cref="IItem"/>s
    /// </summary>
    public interface IItemManager : IManager<IItem>
    {
        // TODO: GetByName() etc.
    }
}
