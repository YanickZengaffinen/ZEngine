using ZEngine.Common;
using ZEngine.Items;
using ZEngine.Module;
using ZEngine.Module.Dependencies;

namespace ZEngine.Inventory
{
    [ModuleDependency(ItemsAPI.MODULE)]
    [ModuleDependency(CommonAPI.MODULE)]
    public class InventoryAPI : IModule
    {
        public void Init(Engine engine)
        {

        }
    }
}
