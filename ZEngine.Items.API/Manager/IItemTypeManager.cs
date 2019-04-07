using ZEngine.Common.Manager;
using ZEngine.Common.MarkerAttribute;

namespace ZEngine.Items
{
    /// <summary>
    /// Manager for <see cref="IItemType"/>s
    /// </summary>
    public interface IItemTypeManager : IManager<IItemType>
    {
        /// <summary>
        /// Get an item by its name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [Nullable]
        IItemType GetByName(string name);
    }
}
