using ZEngine.Common;
using ZEngine.Module;
using ZEngine.Module.Dependencies;

namespace ZEngine.Items
{
    [ModuleDependency(CommonAPI.MODULE)]
    public class ItemsAPI : IModule
    {
        public const string MODULE = "Items";

        public void Init(Engine engine)
        {
        }
    }
}
