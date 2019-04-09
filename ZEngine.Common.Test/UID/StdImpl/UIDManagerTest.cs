using System;
using Xunit;
using ZEngine.Common.UID.StdImpl;

namespace ZEngine.Common.Test.UID.StdImpl
{
    public class UIDManagerTest
    {
        [Fact]
        public void TestBlocking()
        {
            UIDManager uidManager = new UIDManager();
            Assert.True(uidManager.Block(1));
            Assert.True(uidManager.Block(2));
            Assert.False(uidManager.Block(1));

            try
            {
                uidManager.Generate();
            }catch(Exception)
            {
                Assert.False(true);
            }
        }


    }
}
