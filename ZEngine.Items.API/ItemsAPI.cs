using System;
using System.Collections.Generic;
using System.Text;
using ZEngine.Logging;
using ZEngine.Module;

namespace ZEngine.Items
{
    public class ItemsAPI : IModule
    {
        private static readonly Logger logger = Logger.Of(typeof(ItemsAPI));

        public void Init()
        {
            logger.Info("Initializing ItemsAPI");

            logger.Info("ItemsAPI initialized successfully");
        }
    }
}
