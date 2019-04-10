using System;
using Xunit;
using ZEngine;
using ZEngine.Common.Manager.StdImpl;
using ZEngine.Items.Core.StdImpl;
using ZEngine.Items.Impl;

namespace ZEngine.Items.Test.Manager
{
    public class ItemTypeManagerTest
    {
        private void SetupEngine()
        {
            ManagerRegistry.Instance.CleanUp();
            new Engine(
                new ItemsAPI(),
                new ItemsImpl()).Init();
        }

        [Fact]
        public void TestModuleInit()
        {
            SetupEngine();
            Assert.NotNull(ManagerRegistry.Instance.GetManager<IItemTypeManager>());
        }

        [Fact]
        public void TestItemRegistration()
        {
            SetupEngine();

            var manager = ManagerRegistry.Instance.GetManager<IItemTypeManager>();

            var type0 = new ItemType(0, "0");
            var typeDynamic = new ItemType("test");

            manager.Register(type0);
            manager.Register(typeDynamic);

            Assert.Equal(manager.Get(0), type0);
            Assert.Equal(manager.Get(typeDynamic.ID), typeDynamic);
        }
    }
}
