using System;
using System.Collections.Generic;
using System.Text;

namespace ZEngine.Service
{
    public interface IServiceRegistry
    {
        /// <summary>
        /// Get a service of a specific type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetService<T>();

        /// <summary>
        /// Register a new service or override an existing one
        /// 
        /// The service will only be overridden if the specified priority is higher than the one of the service that already exists
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="service"></param>
        /// <param name="priority"></param>
        void RegisterService<T>(T service, int priority = 0);
    }
}
