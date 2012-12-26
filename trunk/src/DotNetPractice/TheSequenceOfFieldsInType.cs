using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
namespace DotNetPractice
{
    [StructLayout(LayoutKind.Auto)]
    class TheSequenceOfFieldsInTypeAuto : Object
    {
    }

    [StructLayout(LayoutKind.Sequential)]
    class TheSequenceOfFieldsInTypeSequential
    { }

    [StructLayout(LayoutKind.Explicit)]
    class TheSequenceOfFieldsExplicit
    {
        [FieldOffset(0)]
        int test;
    }
}
