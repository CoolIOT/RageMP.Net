using System;
using System.Runtime.InteropServices;
using AlternateLife.RageMP.Net.Data;

namespace AlternateLife.RageMP.Net.Native
{
    internal static partial class Rage
    {
        internal static class TextLabel
        {
            [DllImport(_dllName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr TextLabel_GetColor(IntPtr textLabel);

            [DllImport(_dllName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void TextLabel_SetColor(IntPtr textLabel, ColorRgba color);

            [DllImport(_dllName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr TextLabel_GetText(IntPtr textLabel);

            [DllImport(_dllName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void TextLabel_SetText(IntPtr textLabel, IntPtr color);

            [DllImport(_dllName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern bool TextLabel_GetLOS(IntPtr textLabel);

            [DllImport(_dllName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void TextLabel_SetLOS(IntPtr textLabel, bool toggle);

            [DllImport(_dllName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern float TextLabel_GetDrawDistance(IntPtr textLabel);

            [DllImport(_dllName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void TextLabel_SetDrawDistance(IntPtr textLabel, float distance);

            [DllImport(_dllName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern uint TextLabel_GetFont(IntPtr textLabel);

            [DllImport(_dllName, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void TextLabel_SetFont(IntPtr textLabel, uint font);
        }
    }
}
