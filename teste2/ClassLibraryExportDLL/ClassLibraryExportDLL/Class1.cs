using RGiesecke.DllExport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace ClassLibraryExportDLL
{
    public class Class1
    {
        [DllExport("SomaValor", CallingConvention = CallingConvention.StdCall)]
        public static int SomaValor(int a, int b)
        {
            return a + b;
        }

    }
}
