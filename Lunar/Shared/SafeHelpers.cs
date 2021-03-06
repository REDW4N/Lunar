using System;
using System.Runtime.CompilerServices;

namespace Lunar.Shared
{
    internal static class SafeHelpers
    {
        internal static IntPtr CreateSafePointer(int pointer)
        {
            return pointer >= 0 ? new IntPtr(pointer) : Unsafe.As<int, IntPtr>(ref pointer);
        }

        internal static IntPtr CreateSafePointer(long pointer)
        {
            return pointer >= 0 ? new IntPtr(pointer) : Unsafe.As<long, IntPtr>(ref pointer);
        }

        internal static int Xor(int left, int right)
        {
            return (int) ((uint) left ^ (uint) right);
        }

        internal static int Rotr(int left, int right)
        {
            return (int) (((uint) left >> right) | ((uint) left << (32 - right)));
        }
    }
}