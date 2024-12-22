using System;
using System.Text;
using System.Runtime.InteropServices;
using WMICS.PInvoke;

namespace WMICS.PInvoke {
    internal static class NativeMethods {
        #region kernel32.dll

        // https://learn.microsoft.com/en-us/windows/win32/api/sysinfoapi/nf-sysinfoapi-globalmemorystatusex
        // https://www.pinvoke.net/default.aspx/kernel32.GlobalMemoryStatusEx
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool GlobalMemoryStatusEx([In, Out] MEMORYSTATUSEX lpBuffer);

        #endregion
    }
}