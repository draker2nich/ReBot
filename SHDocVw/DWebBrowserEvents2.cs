﻿// Decompiled with JetBrains decompiler
// Type: SHDocVw.DWebBrowserEvents2
// Assembly: ReBot, Version=3.9.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 147AC50F-40E8-4B39-8462-ADDDE720DD9F
// Assembly location: C:\Users\pcfor\Downloads\ReBot.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace SHDocVw
{
  [Guid("34A715A0-6587-11D0-924A-0020AFC7AC4D")]
  [TypeLibType(4112)]
  [InterfaceType(2)]
  [ComImport]
  public interface DWebBrowserEvents2
  {
    [DispId(102)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void StatusTextChange([MarshalAs(UnmanagedType.BStr), In] string Text);

    [DispId(108)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ProgressChange([In] int Progress, [In] int ProgressMax);

    [DispId(105)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CommandStateChange([In] int Command, [In] bool Enable);

    [DispId(106)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DownloadBegin();

    [DispId(104)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DownloadComplete();

    [DispId(113)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void TitleChange([MarshalAs(UnmanagedType.BStr), In] string Text);

    [DispId(112)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PropertyChange([MarshalAs(UnmanagedType.BStr), In] string szProperty);

    [DispId(250)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void BeforeNavigate2(
      [MarshalAs(UnmanagedType.IDispatch), In] object pDisp,
      [MarshalAs(UnmanagedType.Struct), In] ref object URL,
      [MarshalAs(UnmanagedType.Struct), In] ref object Flags,
      [MarshalAs(UnmanagedType.Struct), In] ref object TargetFrameName,
      [MarshalAs(UnmanagedType.Struct), In] ref object PostData,
      [MarshalAs(UnmanagedType.Struct), In] ref object Headers,
      [In, Out] ref bool Cancel);

    [DispId(251)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void NewWindow2([MarshalAs(UnmanagedType.IDispatch), In, Out] ref object ppDisp, [In, Out] ref bool Cancel);

    [DispId(252)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void NavigateComplete2([MarshalAs(UnmanagedType.IDispatch), In] object pDisp, [MarshalAs(UnmanagedType.Struct), In] ref object URL);

    [DispId(259)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DocumentComplete([MarshalAs(UnmanagedType.IDispatch), In] object pDisp, [MarshalAs(UnmanagedType.Struct), In] ref object URL);

    [DispId(253)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnQuit();

    [DispId(254)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnVisible([In] bool Visible);

    [DispId(255)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnToolBar([In] bool ToolBar);

    [DispId(256)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnMenuBar([In] bool MenuBar);

    [DispId(257)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnStatusBar([In] bool StatusBar);

    [DispId(258)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnFullScreen([In] bool FullScreen);

    [DispId(260)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnTheaterMode([In] bool TheaterMode);

    [DispId(262)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void WindowSetResizable([In] bool Resizable);

    [DispId(264)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void WindowSetLeft([In] int Left);

    [DispId(265)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void WindowSetTop([In] int Top);

    [DispId(266)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void WindowSetWidth([In] int Width);

    [DispId(267)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void WindowSetHeight([In] int Height);

    [DispId(263)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void WindowClosing([In] bool IsChildWindow, [In, Out] ref bool Cancel);

    [DispId(268)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ClientToHostWindow([In, Out] ref int CX, [In, Out] ref int CY);

    [DispId(269)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SetSecureLockIcon([In] int SecureLockIcon);

    [DispId(270)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void FileDownload([In] bool ActiveDocument, [In, Out] ref bool Cancel);

    [DispId(271)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void NavigateError(
      [MarshalAs(UnmanagedType.IDispatch), In] object pDisp,
      [MarshalAs(UnmanagedType.Struct), In] ref object URL,
      [MarshalAs(UnmanagedType.Struct), In] ref object Frame,
      [MarshalAs(UnmanagedType.Struct), In] ref object StatusCode,
      [In, Out] ref bool Cancel);

    [DispId(225)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PrintTemplateInstantiation([MarshalAs(UnmanagedType.IDispatch), In] object pDisp);

    [DispId(226)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PrintTemplateTeardown([MarshalAs(UnmanagedType.IDispatch), In] object pDisp);

    [DispId(227)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void UpdatePageStatus([MarshalAs(UnmanagedType.IDispatch), In] object pDisp, [MarshalAs(UnmanagedType.Struct), In] ref object nPage, [MarshalAs(UnmanagedType.Struct), In] ref object fDone);

    [DispId(272)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PrivacyImpactedStateChange([In] bool bImpacted);

    [DispId(273)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void NewWindow3(
      [MarshalAs(UnmanagedType.IDispatch), In, Out] ref object ppDisp,
      [In, Out] ref bool Cancel,
      [In] uint dwFlags,
      [MarshalAs(UnmanagedType.BStr), In] string bstrUrlContext,
      [MarshalAs(UnmanagedType.BStr), In] string bstrUrl);

    [DispId(282)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SetPhishingFilterStatus([In] int PhishingFilterStatus);

    [DispId(283)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void WindowStateChanged([In] uint dwWindowStateFlags, [In] uint dwValidFlagsMask);

    [DispId(284)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void NewProcess([In] int lCauseFlag, [MarshalAs(UnmanagedType.IDispatch), In] object pWB2, [In, Out] ref bool Cancel);

    [DispId(285)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ThirdPartyUrlBlocked([MarshalAs(UnmanagedType.Struct), In] ref object URL, [In] uint dwCount);

    [DispId(286)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RedirectXDomainBlocked(
      [MarshalAs(UnmanagedType.IDispatch), In] object pDisp,
      [MarshalAs(UnmanagedType.Struct), In] ref object StartURL,
      [MarshalAs(UnmanagedType.Struct), In] ref object RedirectURL,
      [MarshalAs(UnmanagedType.Struct), In] ref object Frame,
      [MarshalAs(UnmanagedType.Struct), In] ref object StatusCode);

    [DispId(290)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void BeforeScriptExecute([MarshalAs(UnmanagedType.IDispatch), In] object pDispWindow);

    [DispId(288)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void WebWorkerStarted([In] uint dwUniqueID, [MarshalAs(UnmanagedType.BStr), In] string bstrWorkerLabel);

    [DispId(289)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void WebWorkerFinsihed([In] uint dwUniqueID);
  }
}
