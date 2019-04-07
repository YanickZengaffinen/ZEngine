using ZEngine.Common.MarkerAttribute;

namespace ZEngine.Common.Manager
{
    public interface IManager<T> where T : IIdentifiable
    {
        /// <summary>
        /// Register an identifiable
        /// </summary>
        void Register(T identifiable);

        /// <summary>
        /// Unregisters an identifiable
        /// </summary>
        void Unregister(T identifiable);

        /// <summary>
        /// Get an identifiable via its id
        /// </summary>
        /// <returns> Null if there exists no element with the given id </returns>
        [Nullable]
        T Get(long id);

        /// <summary>
        /// Get the next free id
        /// </summary>
        long GetNextID();
    }
}
