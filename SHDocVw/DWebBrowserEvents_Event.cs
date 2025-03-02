// Decompiled with JetBrains decompiler
// Type: SHDocVw.DWebBrowserEvents_Event
// Assembly: ReBot, Version=3.9.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 147AC50F-40E8-4B39-8462-ADDDE720DD9F
// Assembly location: C:\Users\pcfor\Downloads\ReBot.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace SHDocVw
{
  [ComVisible(false)]
  [TypeLibType(16)]
  [ComEventInterface(typeof (DWebBrowserEvents), typeof (DWebBrowserEvents_EventProvider))]
  public interface DWebBrowserEvents_Event
  {
    event DWebBrowserEvents_BeforeNavigateEventHandler BeforeNavigate;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_BeforeNavigate([In] DWebBrowserEvents_BeforeNavigateEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_BeforeNavigate([In] DWebBrowserEvents_BeforeNavigateEventHandler obj0);

    event DWebBrowserEvents_NavigateCompleteEventHandler NavigateComplete;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_NavigateComplete(
      [In] DWebBrowserEvents_NavigateCompleteEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_NavigateComplete(
      [In] DWebBrowserEvents_NavigateCompleteEventHandler obj0);

    event DWebBrowserEvents_StatusTextChangeEventHandler StatusTextChange;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_StatusTextChange(
      [In] DWebBrowserEvents_StatusTextChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_StatusTextChange(
      [In] DWebBrowserEvents_StatusTextChangeEventHandler obj0);

    event DWebBrowserEvents_ProgressChangeEventHandler ProgressChange;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_ProgressChange([In] DWebBrowserEvents_ProgressChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_ProgressChange([In] DWebBrowserEvents_ProgressChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_DownloadComplete(
      [In] DWebBrowserEvents_DownloadCompleteEventHandler obj0);

    event DWebBrowserEvents_DownloadCompleteEventHandler DownloadComplete;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_DownloadComplete(
      [In] DWebBrowserEvents_DownloadCompleteEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_CommandStateChange(
      [In] DWebBrowserEvents_CommandStateChangeEventHandler obj0);

    event DWebBrowserEvents_CommandStateChangeEventHandler CommandStateChange;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_CommandStateChange(
      [In] DWebBrowserEvents_CommandStateChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_DownloadBegin([In] DWebBrowserEvents_DownloadBeginEventHandler obj0);

    event DWebBrowserEvents_DownloadBeginEventHandler DownloadBegin;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_DownloadBegin([In] DWebBrowserEvents_DownloadBeginEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_NewWindow([In] DWebBrowserEvents_NewWindowEventHandler obj0);

    event DWebBrowserEvents_NewWindowEventHandler NewWindow;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_NewWindow([In] DWebBrowserEvents_NewWindowEventHandler obj0);

    event DWebBrowserEvents_TitleChangeEventHandler TitleChange;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_TitleChange([In] DWebBrowserEvents_TitleChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_TitleChange([In] DWebBrowserEvents_TitleChangeEventHandler obj0);

    event DWebBrowserEvents_FrameBeforeNavigateEventHandler FrameBeforeNavigate;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_FrameBeforeNavigate(
      [In] DWebBrowserEvents_FrameBeforeNavigateEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_FrameBeforeNavigate(
      [In] DWebBrowserEvents_FrameBeforeNavigateEventHandler obj0);

    event DWebBrowserEvents_FrameNavigateCompleteEventHandler FrameNavigateComplete;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_FrameNavigateComplete(
      [In] DWebBrowserEvents_FrameNavigateCompleteEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_FrameNavigateComplete(
      [In] DWebBrowserEvents_FrameNavigateCompleteEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_FrameNewWindow([In] DWebBrowserEvents_FrameNewWindowEventHandler obj0);

    event DWebBrowserEvents_FrameNewWindowEventHandler FrameNewWindow;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_FrameNewWindow([In] DWebBrowserEvents_FrameNewWindowEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_Quit([In] DWebBrowserEvents_QuitEventHandler obj0);

    event DWebBrowserEvents_QuitEventHandler Quit;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_Quit([In] DWebBrowserEvents_QuitEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_WindowMove([In] DWebBrowserEvents_WindowMoveEventHandler obj0);

    event DWebBrowserEvents_WindowMoveEventHandler WindowMove;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_WindowMove([In] DWebBrowserEvents_WindowMoveEventHandler obj0);

    event DWebBrowserEvents_WindowResizeEventHandler WindowResize;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_WindowResize([In] DWebBrowserEvents_WindowResizeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_WindowResize([In] DWebBrowserEvents_WindowResizeEventHandler obj0);

    event DWebBrowserEvents_WindowActivateEventHandler WindowActivate;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_WindowActivate([In] DWebBrowserEvents_WindowActivateEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_WindowActivate([In] DWebBrowserEvents_WindowActivateEventHandler obj0);

    event DWebBrowserEvents_PropertyChangeEventHandler PropertyChange;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_PropertyChange([In] DWebBrowserEvents_PropertyChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_PropertyChange([In] DWebBrowserEvents_PropertyChangeEventHandler obj0);
  }
}
