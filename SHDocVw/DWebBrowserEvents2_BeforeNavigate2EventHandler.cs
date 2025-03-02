// Decompiled with JetBrains decompiler
// Type: SHDocVw.DWebBrowserEvents2_BeforeNavigate2EventHandler
// Assembly: ReBot, Version=3.9.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 147AC50F-40E8-4B39-8462-ADDDE720DD9F
// Assembly location: C:\Users\pcfor\Downloads\ReBot.exe

using System.Runtime.InteropServices;

#nullable disable
namespace SHDocVw
{
  [TypeLibType(16)]
  [ComVisible(false)]
  public delegate void DWebBrowserEvents2_BeforeNavigate2EventHandler(
    [MarshalAs(UnmanagedType.IDispatch), In] object pDisp,
    [MarshalAs(UnmanagedType.Struct), In] ref object URL,
    [MarshalAs(UnmanagedType.Struct), In] ref object Flags,
    [MarshalAs(UnmanagedType.Struct), In] ref object TargetFrameName,
    [MarshalAs(UnmanagedType.Struct), In] ref object PostData,
    [MarshalAs(UnmanagedType.Struct), In] ref object Headers,
    [In, Out] ref bool Cancel);
}
