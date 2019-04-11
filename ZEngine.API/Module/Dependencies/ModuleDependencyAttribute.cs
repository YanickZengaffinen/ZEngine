using System;
using System.Collections.Generic;
using System.Text;

namespace ZEngine.Module.Dependencies
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class ModuleDependencyAttribute : Attribute
    {

        public string Module { get; }

        public ModuleDependencyAttribute(string module)
        {
            this.Module = module;
        }
    }
}
