using ZEngine.Common.Manager;
using ZEngine.Common.MarkerAttribute;

namespace ZEngine.Items.Manager
{
    /// <summary>
    /// Manager for <see cref="IItem"/>s
    /// </summary>
    public interface IItemManager : IManager<IItem>
    {
        /// <summary>
        /// Get an item by its name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [Nullable]
        IItem GetByName(string name);
    }
}
