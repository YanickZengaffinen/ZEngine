﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZEngine.Common.MarkerAttribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class Immutable : Attribute
    {
    }
}
