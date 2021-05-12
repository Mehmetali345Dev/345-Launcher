using System.Runtime.InteropServices;

namespace _345_Launcher
{
    public class Util
    {
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetPhysicallyInstalledSystemMemory(out int TotalMemoryInKilobytes);

        public static int? GetMemoryMb()
        {
            try
            {
                int value = 0;
                if (!GetPhysicallyInstalledSystemMemory(out value))
                    return null;

                return value / 1024;
            }
            catch
            {
                return null;
            }
        }
    }
}
