using System;
using System.Collections.Generic;
using System.Text;
using ZEngine.Common.API.Manager.StdImpl;

namespace ZEngine.Common.API.Test.StdImpl
{
    public class ManagerRegistryTest
    {
        /// <summary>
        /// Test if a service can be registered an unregistered
        /// </summary>
        void BasicTest()
        {
            ManagerRegistry.Instance.register<>( new Imag);
        }
    }
}
