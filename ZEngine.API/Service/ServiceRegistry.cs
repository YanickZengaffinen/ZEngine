using System;
using System.Collections.Generic;
using System.Text;

namespace ZEngine.Service
{
    public class ServiceRegistry
    {
        private static Dictionary<Type, object> services = new Dictionary<Type, object>();
        private static Dictionary<Type, int> servicePriorities = new Dictionary<Type, int>();

        /// <summary>
        /// Get a service of a specific type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetService<T>()
        {
            return (T)services[typeof(T)];
        }

        /// <summary>
        /// Register a new service or override an existing one
        /// 
        /// The service will only be overridden if the specified priority is higher than the one of the service that already exists
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="service"></param>
        /// <param name="priority"></param>
        public static void RegisterService<T>(T service, int priority = 0)
        {
            var key = typeof(T);
            if(!services.ContainsKey(key) || servicePriorities[key] < priority)
            {
                services.Add(key, service);
                servicePriorities.Add(key, priority);
            }
        }
    }
}
