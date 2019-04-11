using Logging;
using System.Collections.Generic;
using ZEngine.Module;
using ZEngine.Service;

namespace ZEngine
{
    public class Engine
    {
        private static readonly Logger logger = Logger.Of(typeof(Engine));

        public static Engine Current { get; private set; }

        private readonly string[] moduleNames;

        public IServiceRegistry ServiceRegistry { get; } = new ServiceRegistry();

        //names of all modules that are currently loaded
        private IList<string> loadedModules = new List<string>();

        /// <summary>
        /// C'tor
        /// </summary>
        /// <param name="modules"> All the names of all the modules that should be loaded </param>
        public Engine(params string[] modules)
        {
            Engine.Current = this;
            this.moduleNames = modules;
        }

        /// <summary>
        /// Startsup the ZEngine
        /// </summary>
        public void Init()
        {
            foreach(string moduleName in moduleNames)
            {
                LoadModule(moduleName);
            }
        }

        private void LoadModule(string moduleName)
        {
            if (!loadedModules.Contains(moduleName))
            {
                logger.Info($"Loading module {moduleName}");

                var apiModule = ModuleUtil.GetModuleForClassName(ModuleUtil.GetModuleAPIClassName(moduleName));
                if(apiModule != null)
                {
                    var deps = ModuleUtil.GetModuleDependencies(apiModule);
                    foreach (var dep in deps)
                    {
                        LoadModule(dep);
                    }

                    apiModule.Init(this);
                }
                else
                {
                    logger.Warn($"Missing API module class for {moduleName}");
                }

                var implModule = ModuleUtil.GetModuleForClassName(ModuleUtil.GetModuleImplClassName(moduleName));
                if(implModule != null)
                {
                    //TODO: do all dependencies have to be declared on the API?
                    implModule.Init(this);
                }
                else
                {
                    logger.Warn($"Missing Impl module class for {moduleName}");
                }

                loadedModules.Add(moduleName);
                logger.Info($"Finished loading module {moduleName}");
            }
        }
    }
}
