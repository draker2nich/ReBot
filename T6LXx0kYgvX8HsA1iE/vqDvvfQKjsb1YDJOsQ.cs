// Decompiled with JetBrains decompiler
// Type: T6LXx0kYgvX8HsA1iE.vqDvvfQKjsb1YDJOsQ
// Assembly: ReBot, Version=3.9.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 147AC50F-40E8-4B39-8462-ADDDE720DD9F
// Assembly location: C:\Users\pcfor\Downloads\ReBot.exe

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace T6LXx0kYgvX8HsA1iE
{
  internal class vqDvvfQKjsb1YDJOsQ
  {
    [DllImport("advapi32.dll", EntryPoint = "AdjustTokenPrivileges", SetLastError = true)]
    internal static extern bool NnAqB7KmSc(
      IntPtr _param0,
      bool _param1,
      ref vqDvvfQKjsb1YDJOsQ.zFP0IDsy0SDeG3DqGJ _param2,
      int _param3,
      IntPtr _param4,
      IntPtr _param5);

    [DllImport("kernel32.dll", EntryPoint = "GetCurrentProcess")]
    internal static extern IntPtr PqZqbLmPgl();

    [DllImport("advapi32.dll", EntryPoint = "InitiateSystemShutdownEx")]
    private static extern int D83qWiW4OH(
      string _param0,
      string _param1,
      int _param2,
      bool _param3,
      bool _param4);

    [DllImport("advapi32.dll", EntryPoint = "LookupPrivilegeValue", SetLastError = true)]
    internal static extern bool UosqguttV8(string _param0, string _param1, ref long _param2);

    [DllImport("advapi32.dll", EntryPoint = "OpenProcessToken", SetLastError = true)]
    internal static extern bool VZkqpuPJfr(IntPtr _param0, int _param1, ref IntPtr _param2);

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void R9IqamFYgJ()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int J9lqhgT6OO(bool _param0, bool _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public vqDvvfQKjsb1YDJOsQ()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object Rt0FOSOATu3uyWKF3pX(int _param0)
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool pTNifoOab44rGjFRyIf()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool v6ehEiOPTShO9VTfypo()
    {
      // ISSUE: unable to decompile the method.
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void t7Z6LhO1CX7fV1Wh7lL()
    {
      // ISSUE: unable to decompile the method.
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct zFP0IDsy0SDeG3DqGJ
    {
      public int Ax3XrJM2qi;
      public long QOwXf41AEl;
      public int uq7XK6bby2;
    }
  }
}
