using Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ZEngine.Module;

namespace ZEngine
{
    public class Engine
    {
        private static readonly Logger logger = Logger.Of(typeof(Engine));

        private readonly string[] moduleNames;
        public IList<IModule> Modules { get; private set; }

        /// <summary>
        /// C'tor if you already have instances of the modules
        /// </summary>
        public Engine(params IModule[] modules)
        {
            this.Modules = modules;
        }

        /// <summary>
        /// C'tor
        /// </summary>
        /// <param name="modules"> All the full names of the modules that should be loaded </param>
        public Engine(params string[] modules)
        {
            this.moduleNames = modules;
        }

        /// <summary>
        /// Startsup the ZEngine
        /// </summary>
        public void Init()
        {
            if (Modules == null)
            {
                Modules = new List<IModule>(moduleNames.Length);
                var assembly = Assembly.GetExecutingAssembly();

                foreach (string module in moduleNames)
                {
                    string m = String.Join<string>(",", assembly.GetTypes().Select(x => x.FullName).ToArray());
                    var type = assembly.GetTypes().First(t => t.FullName.Equals(module));
                    if (type != null && typeof(IModule).IsAssignableFrom(type))
                    {
                        try
                        {
                            Modules.Add(Activator.CreateInstance(type) as IModule);
                        }
                        catch (Exception e)
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

            foreach(var module in Modules)
            {
                module.Init();
            }
        }
    }
}
