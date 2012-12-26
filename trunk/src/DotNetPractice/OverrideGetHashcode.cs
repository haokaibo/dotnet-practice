using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;

namespace DotNetPractice
{
    class OverrideGetHashcode
    {
        public override Int32 GetHashCode()
        {
            return RuntimeHelpers.GetHashCode(this);
        }
    }
}
