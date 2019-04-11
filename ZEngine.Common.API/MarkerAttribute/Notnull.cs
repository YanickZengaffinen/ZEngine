using System;
using System.Collections.Generic;
using System.Text;

namespace ZEngine.Common.MarkerAttribute
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class Notnull : Attribute
    {
    }
}
