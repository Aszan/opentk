using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class EnvironmentMocks
    {
        public static OperatingSystem OSVersion
        {
            get
            {
                return new OperatingSystem();
            }
        }
    }

    public sealed class OperatingSystem
    {
        public Version Version = new Version(9, 9, 9, 9);
        private PlatformID _platform;
        private string _servicePack;
        private string _versionString;
    }


    [Serializable]
    public enum PlatformID
    {
        Win32S = 0,
        Win32Windows = 1,
        Win32NT = 2,
        WinCE = 3,
        Unix = 4,
        Xbox = 5,
        MacOSX = 6
    }
}
