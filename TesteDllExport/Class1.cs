using RGiesecke.DllExport;
using System;
using System.Runtime.InteropServices;

namespace TesteDllExport
{
    public class Class1
    {
        [DllExport("SomaValor", CallingConvention = CallingConvention.StdCall)]
        public static int SomaValor(int a, int b)
        {
            return a+b;
        }
    }
}
