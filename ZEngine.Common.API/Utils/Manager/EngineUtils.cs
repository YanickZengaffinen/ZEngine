using System;
using System.Collections.Generic;
using System.Text;
using ZEngine.Common.Manager;

namespace ZEngine.Common.Utils.Manager
{
    public static class EngineUtils
    {
        public static IManagerRegistry GetManagerRegistry(this Engine engine)
        {
            return engine.ServiceRegistry.GetService<IManagerRegistry>();
        }

    }
}
