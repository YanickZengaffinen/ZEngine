using Xunit;
using ZEngine.Common;
using ZEngine.Common.Impl;
using ZEngine.Common.Utils.Manager;
using ZEngine.Items.Core.StdImpl;
using ZEngine.Items.Impl;

namespace ZEngine.Items.Manager.Test
{
    public class ItemTypeManagerTest
    {
        private Engine engine;

        private void SetupEngine()
        {
            engine = new Engine(
                new CommonAPI(),
                new CommonImpl(),
                new ItemsAPI(),
                new ItemsImpl());
            engine.Init();
        }

        [Fact]
        public void TestModuleInit()
        {
            SetupEngine();
            Assert.NotNull(engine.GetManagerRegistry().GetManager<IItemTypeManager>());
        }

        [Fact]
        public void TestItemRegistration()
        {
            SetupEngine();

            var manager = engine.GetManagerRegistry().GetManager<IItemTypeManager>();

            var type0 = new ItemType(0, "0");
            var typeDynamic = new ItemType("test");

            manager.Register(type0);
            manager.Register(typeDynamic);

            Assert.Equal(manager.Get(0), type0);
            Assert.Equal(manager.Get(typeDynamic.ID), typeDynamic);
        }
    }
}
