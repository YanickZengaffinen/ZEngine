using Logging;
using System;
using System.Linq;
using System.Reflection;
using ZEngine.Module;

namespace ZEngine
{
    public class Engine
    {
        private static readonly Logger logger = Logger.Of(typeof(Engine));

        private readonly string[] modules;

        /// <summary>
        /// C'tor
        /// </summary>
        /// <param name="modules"> All the full names of the modules that should be loaded </param>
        public Engine(params string[] modules)
        {
            this.modules = modules;
        }

        /// <summary>
        /// Startsup the ZEngine
        /// </summary>
        public void Init()
        {
            var assembly = Assembly.GetExecutingAssembly();

            foreach (string module in modules)
            {
                var type = assembly.GetTypes().First(t => t.FullName.Equals(module));
                if (type != null && typeof(IModule).IsAssignableFrom(type))
                {
                    try
                    {
                        (Activator.CreateInstance(type) as IModule).Init();
                    }
                    catch(Exception e)
                    {
                        logger.Error($"Failed to load module {module}. Error while instantiating module of type {type.FullName}.{Environment.NewLine}{e}");
                    }
                }
                else
                {
                    logger.Error($"Failed to load module {module} due to invalid type {type?.FullName}. Make sure the specified type exists in the assembly and inherits from {typeof(IModule).FullName}");
                }
            }
        }
    }
}
