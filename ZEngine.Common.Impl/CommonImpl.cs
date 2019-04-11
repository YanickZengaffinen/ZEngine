using ZEngine.Common.Manager;
using ZEngine.Common.Manager.Impl;
using ZEngine.Module;
using ZEngine.Service;

namespace ZEngine.Common.Impl
{
    public class CommonImpl : IModule
    {
        public void Init(Engine engine)
        {
            engine.ServiceRegistry.RegisterService<IManagerRegistry>(new ManagerRegistry());
        }
    }
}
