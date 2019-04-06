using System;
using System.Collections.Generic;
using System.Text;

namespace ZEngine.Common.MarkerAttribute
{
    [AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class Notnull : Attribute
    {
    }
}
