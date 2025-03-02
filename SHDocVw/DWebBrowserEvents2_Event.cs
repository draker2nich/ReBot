// Decompiled with JetBrains decompiler
// Type: SHDocVw.DWebBrowserEvents2_Event
// Assembly: ReBot, Version=3.9.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 147AC50F-40E8-4B39-8462-ADDDE720DD9F
// Assembly location: C:\Users\pcfor\Downloads\ReBot.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace SHDocVw
{
  [TypeLibType(16)]
  [ComEventInterface(typeof (DWebBrowserEvents2), typeof (DWebBrowserEvents2_EventProvider))]
  [ComVisible(false)]
  public interface DWebBrowserEvents2_Event
  {
    event DWebBrowserEvents2_StatusTextChangeEventHandler StatusTextChange;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_StatusTextChange(
      [In] DWebBrowserEvents2_StatusTextChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_StatusTextChange(
      [In] DWebBrowserEvents2_StatusTextChangeEventHandler obj0);

    event DWebBrowserEvents2_ProgressChangeEventHandler ProgressChange;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_ProgressChange([In] DWebBrowserEvents2_ProgressChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_ProgressChange([In] DWebBrowserEvents2_ProgressChangeEventHandler obj0);

    event DWebBrowserEvents2_CommandStateChangeEventHandler CommandStateChange;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_CommandStateChange(
      [In] DWebBrowserEvents2_CommandStateChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_CommandStateChange(
      [In] DWebBrowserEvents2_CommandStateChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_DownloadBegin([In] DWebBrowserEvents2_DownloadBeginEventHandler obj0);

    event DWebBrowserEvents2_DownloadBeginEventHandler DownloadBegin;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_DownloadBegin([In] DWebBrowserEvents2_DownloadBeginEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_DownloadComplete(
      [In] DWebBrowserEvents2_DownloadCompleteEventHandler obj0);

    event DWebBrowserEvents2_DownloadCompleteEventHandler DownloadComplete;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_DownloadComplete(
      [In] DWebBrowserEvents2_DownloadCompleteEventHandler obj0);

    event DWebBrowserEvents2_TitleChangeEventHandler TitleChange;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_TitleChange([In] DWebBrowserEvents2_TitleChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_TitleChange([In] DWebBrowserEvents2_TitleChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_PropertyChange([In] DWebBrowserEvents2_PropertyChangeEventHandler obj0);

    event DWebBrowserEvents2_PropertyChangeEventHandler PropertyChange;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_PropertyChange([In] DWebBrowserEvents2_PropertyChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_BeforeNavigate2(
      [In] DWebBrowserEvents2_BeforeNavigate2EventHandler obj0);

    event DWebBrowserEvents2_BeforeNavigate2EventHandler BeforeNavigate2;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_BeforeNavigate2(
      [In] DWebBrowserEvents2_BeforeNavigate2EventHandler obj0);

    event DWebBrowserEvents2_NewWindow2EventHandler NewWindow2;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_NewWindow2([In] DWebBrowserEvents2_NewWindow2EventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_NewWindow2([In] DWebBrowserEvents2_NewWindow2EventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_NavigateComplete2(
      [In] DWebBrowserEvents2_NavigateComplete2EventHandler obj0);

    event DWebBrowserEvents2_NavigateComplete2EventHandler NavigateComplete2;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_NavigateComplete2(
      [In] DWebBrowserEvents2_NavigateComplete2EventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_DocumentComplete(
      [In] DWebBrowserEvents2_DocumentCompleteEventHandler obj0);

    event DWebBrowserEvents2_DocumentCompleteEventHandler DocumentComplete;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_DocumentComplete(
      [In] DWebBrowserEvents2_DocumentCompleteEventHandler obj0);

    event DWebBrowserEvents2_OnQuitEventHandler OnQuit;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_OnQuit([In] DWebBrowserEvents2_OnQuitEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_OnQuit([In] DWebBrowserEvents2_OnQuitEventHandler obj0);

    event DWebBrowserEvents2_OnVisibleEventHandler OnVisible;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_OnVisible([In] DWebBrowserEvents2_OnVisibleEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_OnVisible([In] DWebBrowserEvents2_OnVisibleEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_OnToolBar([In] DWebBrowserEvents2_OnToolBarEventHandler obj0);

    event DWebBrowserEvents2_OnToolBarEventHandler OnToolBar;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_OnToolBar([In] DWebBrowserEvents2_OnToolBarEventHandler obj0);

    event DWebBrowserEvents2_OnMenuBarEventHandler OnMenuBar;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_OnMenuBar([In] DWebBrowserEvents2_OnMenuBarEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_OnMenuBar([In] DWebBrowserEvents2_OnMenuBarEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_OnStatusBar([In] DWebBrowserEvents2_OnStatusBarEventHandler obj0);

    event DWebBrowserEvents2_OnStatusBarEventHandler OnStatusBar;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_OnStatusBar([In] DWebBrowserEvents2_OnStatusBarEventHandler obj0);

    event DWebBrowserEvents2_OnFullScreenEventHandler OnFullScreen;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_OnFullScreen([In] DWebBrowserEvents2_OnFullScreenEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_OnFullScreen([In] DWebBrowserEvents2_OnFullScreenEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_OnTheaterMode([In] DWebBrowserEvents2_OnTheaterModeEventHandler obj0);

    event DWebBrowserEvents2_OnTheaterModeEventHandler OnTheaterMode;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_OnTheaterMode([In] DWebBrowserEvents2_OnTheaterModeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_WindowSetResizable(
      [In] DWebBrowserEvents2_WindowSetResizableEventHandler obj0);

    event DWebBrowserEvents2_WindowSetResizableEventHandler WindowSetResizable;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_WindowSetResizable(
      [In] DWebBrowserEvents2_WindowSetResizableEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_WindowSetLeft([In] DWebBrowserEvents2_WindowSetLeftEventHandler obj0);

    event DWebBrowserEvents2_WindowSetLeftEventHandler WindowSetLeft;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_WindowSetLeft([In] DWebBrowserEvents2_WindowSetLeftEventHandler obj0);

    event DWebBrowserEvents2_WindowSetTopEventHandler WindowSetTop;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_WindowSetTop([In] DWebBrowserEvents2_WindowSetTopEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_WindowSetTop([In] DWebBrowserEvents2_WindowSetTopEventHandler obj0);

    event DWebBrowserEvents2_WindowSetWidthEventHandler WindowSetWidth;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_WindowSetWidth([In] DWebBrowserEvents2_WindowSetWidthEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_WindowSetWidth([In] DWebBrowserEvents2_WindowSetWidthEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_WindowSetHeight(
      [In] DWebBrowserEvents2_WindowSetHeightEventHandler obj0);

    event DWebBrowserEvents2_WindowSetHeightEventHandler WindowSetHeight;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_WindowSetHeight(
      [In] DWebBrowserEvents2_WindowSetHeightEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_WindowClosing([In] DWebBrowserEvents2_WindowClosingEventHandler obj0);

    event DWebBrowserEvents2_WindowClosingEventHandler WindowClosing;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_WindowClosing([In] DWebBrowserEvents2_WindowClosingEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_ClientToHostWindow(
      [In] DWebBrowserEvents2_ClientToHostWindowEventHandler obj0);

    event DWebBrowserEvents2_ClientToHostWindowEventHandler ClientToHostWindow;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_ClientToHostWindow(
      [In] DWebBrowserEvents2_ClientToHostWindowEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_SetSecureLockIcon(
      [In] DWebBrowserEvents2_SetSecureLockIconEventHandler obj0);

    event DWebBrowserEvents2_SetSecureLockIconEventHandler SetSecureLockIcon;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_SetSecureLockIcon(
      [In] DWebBrowserEvents2_SetSecureLockIconEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_FileDownload([In] DWebBrowserEvents2_FileDownloadEventHandler obj0);

    event DWebBrowserEvents2_FileDownloadEventHandler FileDownload;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_FileDownload([In] DWebBrowserEvents2_FileDownloadEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_NavigateError([In] DWebBrowserEvents2_NavigateErrorEventHandler obj0);

    event DWebBrowserEvents2_NavigateErrorEventHandler NavigateError;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_NavigateError([In] DWebBrowserEvents2_NavigateErrorEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_PrintTemplateInstantiation(
      [In] DWebBrowserEvents2_PrintTemplateInstantiationEventHandler obj0);

    event DWebBrowserEvents2_PrintTemplateInstantiationEventHandler PrintTemplateInstantiation;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_PrintTemplateInstantiation(
      [In] DWebBrowserEvents2_PrintTemplateInstantiationEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_PrintTemplateTeardown(
      [In] DWebBrowserEvents2_PrintTemplateTeardownEventHandler obj0);

    event DWebBrowserEvents2_PrintTemplateTeardownEventHandler PrintTemplateTeardown;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_PrintTemplateTeardown(
      [In] DWebBrowserEvents2_PrintTemplateTeardownEventHandler obj0);

    event DWebBrowserEvents2_UpdatePageStatusEventHandler UpdatePageStatus;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_UpdatePageStatus(
      [In] DWebBrowserEvents2_UpdatePageStatusEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_UpdatePageStatus(
      [In] DWebBrowserEvents2_UpdatePageStatusEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_PrivacyImpactedStateChange(
      [In] DWebBrowserEvents2_PrivacyImpactedStateChangeEventHandler obj0);

    event DWebBrowserEvents2_PrivacyImpactedStateChangeEventHandler PrivacyImpactedStateChange;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_PrivacyImpactedStateChange(
      [In] DWebBrowserEvents2_PrivacyImpactedStateChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_NewWindow3([In] DWebBrowserEvents2_NewWindow3EventHandler obj0);

    event DWebBrowserEvents2_NewWindow3EventHandler NewWindow3;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_NewWindow3([In] DWebBrowserEvents2_NewWindow3EventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_SetPhishingFilterStatus(
      [In] DWebBrowserEvents2_SetPhishingFilterStatusEventHandler obj0);

    event DWebBrowserEvents2_SetPhishingFilterStatusEventHandler SetPhishingFilterStatus;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_SetPhishingFilterStatus(
      [In] DWebBrowserEvents2_SetPhishingFilterStatusEventHandler obj0);

    event DWebBrowserEvents2_WindowStateChangedEventHandler WindowStateChanged;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_WindowStateChanged(
      [In] DWebBrowserEvents2_WindowStateChangedEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_WindowStateChanged(
      [In] DWebBrowserEvents2_WindowStateChangedEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_NewProcess([In] DWebBrowserEvents2_NewProcessEventHandler obj0);

    event DWebBrowserEvents2_NewProcessEventHandler NewProcess;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_NewProcess([In] DWebBrowserEvents2_NewProcessEventHandler obj0);

    event DWebBrowserEvents2_ThirdPartyUrlBlockedEventHandler ThirdPartyUrlBlocked;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_ThirdPartyUrlBlocked(
      [In] DWebBrowserEvents2_ThirdPartyUrlBlockedEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_ThirdPartyUrlBlocked(
      [In] DWebBrowserEvents2_ThirdPartyUrlBlockedEventHandler obj0);

    event DWebBrowserEvents2_RedirectXDomainBlockedEventHandler RedirectXDomainBlocked;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_RedirectXDomainBlocked(
      [In] DWebBrowserEvents2_RedirectXDomainBlockedEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_RedirectXDomainBlocked(
      [In] DWebBrowserEvents2_RedirectXDomainBlockedEventHandler obj0);

    event DWebBrowserEvents2_BeforeScriptExecuteEventHandler BeforeScriptExecute;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_BeforeScriptExecute(
      [In] DWebBrowserEvents2_BeforeScriptExecuteEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_BeforeScriptExecute(
      [In] DWebBrowserEvents2_BeforeScriptExecuteEventHandler obj0);

    event DWebBrowserEvents2_WebWorkerStartedEventHandler WebWorkerStarted;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_WebWorkerStarted(
      [In] DWebBrowserEvents2_WebWorkerStartedEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_WebWorkerStarted(
      [In] DWebBrowserEvents2_WebWorkerStartedEventHandler obj0);

    event DWebBrowserEvents2_WebWorkerFinsihedEventHandler WebWorkerFinsihed;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_WebWorkerFinsihed(
      [In] DWebBrowserEvents2_WebWorkerFinsihedEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_WebWorkerFinsihed(
      [In] DWebBrowserEvents2_WebWorkerFinsihedEventHandler obj0);
  }
}
