// Decompiled with JetBrains decompiler
// Type: SHDocVw.DWebBrowserEvents2_NewWindow3EventHandler
// Assembly: ReBot, Version=3.9.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 147AC50F-40E8-4B39-8462-ADDDE720DD9F
// Assembly location: C:\Users\pcfor\Downloads\ReBot.exe

using System.Runtime.InteropServices;

#nullable disable
namespace SHDocVw
{
  [ComVisible(false)]
  [TypeLibType(16)]
  public delegate void DWebBrowserEvents2_NewWindow3EventHandler(
    [MarshalAs(UnmanagedType.IDispatch), In, Out] ref object ppDisp,
    [In, Out] ref bool Cancel,
    [In] uint dwFlags,
    [MarshalAs(UnmanagedType.BStr), In] string bstrUrlContext,
    [MarshalAs(UnmanagedType.BStr), In] string bstrUrl);
}
