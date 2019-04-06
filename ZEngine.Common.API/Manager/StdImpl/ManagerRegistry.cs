using System;
using System.Collections.Generic;
using ZEngine.Common.MarkerAttribute;

namespace ZEngine.Common.Manager.StdImpl
{
    /// <summary>
    /// Standard implementation of the <see cref="IManagerRegistry"/>
    /// </summary>
    [Singleton]
    public sealed class ManagerRegistry
    {
        public static ManagerRegistry Instance { get; } = new ManagerRegistry();
        private ManagerRegistry() { }

        private Dictionary<Type, IManager<IIdentifiable>> managers = new Dictionary<Type, IManager<IIdentifiable>>();

        /// <summary>
        /// Get the manager for a certain type of identifiable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns> Returns null if there exists no manager for the identifiable type </returns>
        [MarkerAttribute.Nullable]
        public IManager<T> GetManager<T>() where T : IIdentifiable
        {
            return managers[typeof(T)] as IManager<T>;
        }

        /// <summary>
        /// Register a manager for a certain type of identifiable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="manager"></param>
        public void Register<T>(IManager<T> manager) where T : IIdentifiable
        {
            managers.Add(typeof(T), manager as IManager<IIdentifiable>);
        }
    }
}
