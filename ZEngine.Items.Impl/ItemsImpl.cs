using ZEngine.Common.Utils.Manager;
using ZEngine.Items.Manager.Impl;
using ZEngine.Module;

namespace ZEngine.Items.Impl
{
    public class ItemsImpl : IModule
    {
        public void Init(Engine engine)
        {
            //register the itemmanager
            engine.GetManagerRegistry().Register<IItemTypeManager>(new ItemTypeManager());
        }
    }
}
