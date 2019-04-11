using Xunit;
using ZEngine.Common;
using ZEngine.Common.Impl;
using ZEngine.Items.Core.StdImpl;
using ZEngine.Items.Core.Util;
using ZEngine.Items.Impl;

namespace ZEngine.Items.Core.Test
{
    public class ItemStackTest
    {
        private void SetupEngine()
        {
            new Engine(ItemsAPI.MODULE).Init();
        }

        [Fact]
        public void MergeTest()
        {
            SetupEngine();

            var type = new ItemType("test");
            var item = new Item(type);

            var stackA1 = new ItemStack(item);
            var stackB = new ItemStack(item, 10);

            var stackA2 = new ItemStack(item);
            var stackC = new ItemStack(new Item(type));

            var stackA3 = new ItemStack(item);
            var stackD = new ItemStack(new Item(new ItemType("hello")));

            uint amount1 = stackA1.Merge(stackB);
            uint amount2 = stackA2.Merge(stackC);
            uint amount3 = stackA3.Merge(stackD);

            Assert.True(stackA1.Size == 11 && stackB.Size == 0 && amount1 == 10);
            Assert.True(stackA2.Size == 2 && stackC.Size == 0 && amount2 == 1);
            Assert.True(stackA3.Size == 1 && stackD.Size == 1 && amount3 == 0);
        }
    }
}
