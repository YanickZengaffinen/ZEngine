using Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ZEngine.Module.Dependencies;
using Nullable = ZEngine.Common.MarkerAttribute.Nullable;

namespace ZEngine.Module
{
    public static class ModuleUtil
    {
        private static Logger logger = Logger.Of(typeof(ModuleUtil));
        public const string Prefix = "ZEngine";

        /// <summary>
        /// The full name of the API class of a module
        /// </summary>
        public static string GetModuleAPIClassName(string module)
        {
            return $"{Prefix}.{module}.{module}API";
        }

        /// <summary>
        /// The full name of the Impl class of a module
        /// </summary>
        public static string GetModuleImplClassName(string module)
        {
            return $"{Prefix}.{module}.Impl.{module}Impl";
        }

        /// <summary>
        /// Load a module from a full class name
        /// </summary>
        [Nullable]
        public static IModule GetModuleForClassName(string className)
        {
            var assembly = Assembly.GetExecutingAssembly();

            var type = assembly.GetTypes().First(t => t.FullName.Equals(className));
            if (type != null && typeof(IModule).IsAssignableFrom(type))
            {
                try
                {
                    return Activator.CreateInstance(type) as IModule;
                }
                catch (Exception e)
                {
                    logger.Error($"Failed to load module {className}. Error while instantiating module of type {type.FullName}.{Environment.NewLine}{e}");
                }
            }
            else
            {
                logger.Error($"Failed to load module {className} due to invalid type {type?.FullName}. Make sure the specified type exists in the assembly and inherits from {typeof(IModule).FullName}");
            }

            return null;
        }

        /// <summary>
        /// Gets all the dependencies of a module
        /// </summary>
        public static IList<string> GetModuleDependencies(IModule module)
        {
            return module.GetType().GetCustomAttributes<ModuleDependencyAttribute>()
                .Select(dependency => dependency.Module)
                .ToList();
        }
    }
}
