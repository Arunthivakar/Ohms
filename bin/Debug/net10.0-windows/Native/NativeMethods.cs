using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace OhmsLaw.Native
{
    public static class NativeMethods
    {
        [DllImport(
            "NativeLib.dll",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int Voltage(int current, int resistance);

        [DllImport(
            "NativeLib.dll",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int Current(int voltage, int resistance);

        [DllImport(
    "NativeLib.dll",
    CallingConvention = CallingConvention.Cdecl)]
        public static extern int Resistance(int voltage, int current);
    }
}
