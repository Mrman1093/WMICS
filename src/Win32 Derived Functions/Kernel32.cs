using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using WMICS.PInvoke;

namespace WMICS {
    public class Kernel32 {
        public static MEMORYSTATUSEX GetMemoryStatus() {
            MEMORYSTATUSEX memStatus = new MEMORYSTATUSEX();
            memStatus.dwLength = (uint)Marshal.SizeOf(MEMORYSTATUSEX)
            if (GlobalMemoryStatusEx(memStatus)) {
                return memStatus;
            } else {
                int error = Marshal.GetLastWin32Error();
                throw new Win32Exception("[GlobalMemoryStatusEx()] failed with exit code [" + error + "].");
            }
        }
    }
}