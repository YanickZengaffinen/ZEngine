using System;
using System.Collections.Generic;
using System.Text;

namespace ZEngine.Common.Manager
{
    public interface IManager<T> where T : IIdentifiable
    {
        /// <summary>
        /// Register an identifiable
        /// </summary>
        /// <param name="identifiable"></param>
        void Register(IIdentifiable identifiable);

        /// <summary>
        /// Unregisters an identifiable
        /// </summary>
        /// <param name="identifiable"></param>
        void Unregister(IIdentifiable identifiable);

        /// <summary>
        /// Get an identifiable via its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Null if there exists no element with the given id </returns>
        T Get(long id);
    }
}
