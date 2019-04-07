using System;
using System.Collections;
using System.Collections.Generic;
using ZEngine.Common.MarkerAttribute;

namespace ZEngine.Common.Manager.StdImpl
{
    /// <summary>
    /// Registry which holds all managers
    /// </summary>
    [Singleton]
    [NotThreadSafe]
    public sealed class ManagerRegistry
    {
        public static ManagerRegistry Instance { get; } = new ManagerRegistry();
        private ManagerRegistry() { }

        private Dictionary<Type, object> managers = new Dictionary<Type, object>();

        /// <summary>
        /// Get the manager for a certain type of identifiable
        /// </summary>
        /// <returns> Returns null if there exists no manager for the identifiable type </returns>
        [MarkerAttribute.Nullable]
        public T GetManager<T>()
        {
            return (T)managers[typeof(T)];
        }

        /// <summary>
        /// Register a manager for a certain type of identifiable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="manager"></param>
        public void Register<T>(T manager)
        {
            managers.Add(typeof(T), manager);
        }
    }
}
