using ZEngine.Common.Manager.StdImpl;
using ZEngine.Module;

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
