using ZEngine.Common.Manager.StdImpl;
using ZEngine.Items.Impl.Manager;
using ZEngine.Items.Manager;
using ZEngine.Module;
using ZEngine.Service;

namespace ZEngine.Items.Impl
{
    public class ItemsImpl : IModule
    {
        public void Init()
        {
            //register the itemmanager
            ManagerRegistry.Instance.Register(new ItemManager());
        }
    }
}
