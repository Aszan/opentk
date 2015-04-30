using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK
{
    public static class Mocks
    {
        public static IntPtr MarshalGetHINSTANCE(Module m)
        {
            return GetModuleHandle(m.Name);
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GetModuleHandle(string moduleName);

        public static void DebugIndent()
        {
            Debug.WriteLine("Indent >>");
        }

        public static void DebugUnindent()
        {
            Debug.WriteLine("<< Unindent");
        }

        public static void DebugFlush()
        {
            Debug.WriteLine("--Flush!--->");
        }
    }
}
