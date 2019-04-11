using System;
using System.Collections.Generic;
using System.Text;

namespace ZEngine.Common.MarkerAttribute
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class Singleton : Attribute
    {
    }
}
