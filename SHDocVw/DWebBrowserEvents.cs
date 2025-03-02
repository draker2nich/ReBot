// Decompiled with JetBrains decompiler
// Type: SHDocVw.DWebBrowserEvents
// Assembly: ReBot, Version=3.9.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 147AC50F-40E8-4B39-8462-ADDDE720DD9F
// Assembly location: C:\Users\pcfor\Downloads\ReBot.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace SHDocVw
{
  [InterfaceType(2)]
  [TypeLibType(4112)]
  [Guid("EAB22AC2-30C1-11CF-A7EB-0000C05BAE0B")]
  [ComImport]
  public interface DWebBrowserEvents
  {
    [DispId(100)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void BeforeNavigate(
      [MarshalAs(UnmanagedType.BStr), In] string URL,
      int Flags,
      [MarshalAs(UnmanagedType.BStr)] string TargetFrameName,
      [MarshalAs(UnmanagedType.Struct)] ref object PostData,
      [MarshalAs(UnmanagedType.BStr)] string Headers,
      [In, Out] ref bool Cancel);

    [DispId(101)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void NavigateComplete([MarshalAs(UnmanagedType.BStr), In] string URL);

    [DispId(102)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void StatusTextChange([MarshalAs(UnmanagedType.BStr), In] string Text);

    [DispId(108)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ProgressChange([In] int Progress, [In] int ProgressMax);

    [DispId(104)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DownloadComplete();

    [DispId(105)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CommandStateChange([In] int Command, [In] bool Enable);

    [DispId(106)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DownloadBegin();

    [DispId(107)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void NewWindow(
      [MarshalAs(UnmanagedType.BStr), In] string URL,
      [In] int Flags,
      [MarshalAs(UnmanagedType.BStr), In] string TargetFrameName,
      [MarshalAs(UnmanagedType.Struct), In] ref object PostData,
      [MarshalAs(UnmanagedType.BStr), In] string Headers,
      [In, Out] ref bool Processed);

    [DispId(113)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void TitleChange([MarshalAs(UnmanagedType.BStr), In] string Text);

    [DispId(200)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void FrameBeforeNavigate(
      [MarshalAs(UnmanagedType.BStr), In] string URL,
      int Flags,
      [MarshalAs(UnmanagedType.BStr)] string TargetFrameName,
      [MarshalAs(UnmanagedType.Struct)] ref object PostData,
      [MarshalAs(UnmanagedType.BStr)] string Headers,
      [In, Out] ref bool Cancel);

    [DispId(201)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void FrameNavigateComplete([MarshalAs(UnmanagedType.BStr), In] string URL);

    [DispId(204)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void FrameNewWindow(
      [MarshalAs(UnmanagedType.BStr), In] string URL,
      [In] int Flags,
      [MarshalAs(UnmanagedType.BStr), In] string TargetFrameName,
      [MarshalAs(UnmanagedType.Struct), In] ref object PostData,
      [MarshalAs(UnmanagedType.BStr), In] string Headers,
      [In, Out] ref bool Processed);

    [DispId(103)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Quit([In, Out] ref bool Cancel);

    [DispId(109)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void WindowMove();

    [DispId(110)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void WindowResize();

    [DispId(111)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void WindowActivate();

    [DispId(112)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PropertyChange([MarshalAs(UnmanagedType.BStr), In] string Property);
  }
}
