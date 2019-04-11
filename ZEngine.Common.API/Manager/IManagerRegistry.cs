using ZEngine.Common.MarkerAttribute;

namespace ZEngine.Common.Manager
{
    public interface IManagerRegistry
    {
        /// <summary>
        /// Get the manager for a certain type of identifiable
        /// </summary>
        /// <returns> Returns null if there exists no manager for the identifiable type </returns>
        [Nullable]
        T GetManager<T>();

        /// <summary>
        /// Register a manager for a certain type of identifiable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="manager"></param>
        void Register<T>(T manager);
    }
}
