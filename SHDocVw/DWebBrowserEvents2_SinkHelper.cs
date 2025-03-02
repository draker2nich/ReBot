// Decompiled with JetBrains decompiler
// Type: SHDocVw.DWebBrowserEvents2_SinkHelper
// Assembly: ReBot, Version=3.9.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 147AC50F-40E8-4B39-8462-ADDDE720DD9F
// Assembly location: C:\Users\pcfor\Downloads\ReBot.exe

using System.Runtime.InteropServices;

#nullable disable
namespace SHDocVw
{
  [TypeLibType(TypeLibTypeFlags.FHidden)]
  [ClassInterface(ClassInterfaceType.None)]
  public sealed class DWebBrowserEvents2_SinkHelper : DWebBrowserEvents2
  {
    public DWebBrowserEvents2_NewWindow3EventHandler m_NewWindow3Delegate;
    public DWebBrowserEvents2_SetPhishingFilterStatusEventHandler m_SetPhishingFilterStatusDelegate;
    public DWebBrowserEvents2_WindowStateChangedEventHandler m_WindowStateChangedDelegate;
    public DWebBrowserEvents2_NewProcessEventHandler m_NewProcessDelegate;
    public DWebBrowserEvents2_ThirdPartyUrlBlockedEventHandler m_ThirdPartyUrlBlockedDelegate;
    public DWebBrowserEvents2_RedirectXDomainBlockedEventHandler m_RedirectXDomainBlockedDelegate;
    public DWebBrowserEvents2_BeforeScriptExecuteEventHandler m_BeforeScriptExecuteDelegate;
    public DWebBrowserEvents2_WebWorkerStartedEventHandler m_WebWorkerStartedDelegate;
    public DWebBrowserEvents2_WebWorkerFinsihedEventHandler m_WebWorkerFinsihedDelegate;
    public DWebBrowserEvents2_StatusTextChangeEventHandler m_StatusTextChangeDelegate;
    public DWebBrowserEvents2_ProgressChangeEventHandler m_ProgressChangeDelegate;
    public DWebBrowserEvents2_CommandStateChangeEventHandler m_CommandStateChangeDelegate;
    public DWebBrowserEvents2_DownloadBeginEventHandler m_DownloadBeginDelegate;
    public DWebBrowserEvents2_DownloadCompleteEventHandler m_DownloadCompleteDelegate;
    public DWebBrowserEvents2_TitleChangeEventHandler m_TitleChangeDelegate;
    public DWebBrowserEvents2_PropertyChangeEventHandler m_PropertyChangeDelegate;
    public DWebBrowserEvents2_BeforeNavigate2EventHandler m_BeforeNavigate2Delegate;
    public DWebBrowserEvents2_NewWindow2EventHandler m_NewWindow2Delegate;
    public DWebBrowserEvents2_NavigateComplete2EventHandler m_NavigateComplete2Delegate;
    public DWebBrowserEvents2_DocumentCompleteEventHandler m_DocumentCompleteDelegate;
    public DWebBrowserEvents2_OnQuitEventHandler m_OnQuitDelegate;
    public DWebBrowserEvents2_OnVisibleEventHandler m_OnVisibleDelegate;
    public DWebBrowserEvents2_OnToolBarEventHandler m_OnToolBarDelegate;
    public DWebBrowserEvents2_OnMenuBarEventHandler m_OnMenuBarDelegate;
    public DWebBrowserEvents2_OnStatusBarEventHandler m_OnStatusBarDelegate;
    public DWebBrowserEvents2_OnFullScreenEventHandler m_OnFullScreenDelegate;
    public DWebBrowserEvents2_OnTheaterModeEventHandler m_OnTheaterModeDelegate;
    public DWebBrowserEvents2_WindowSetResizableEventHandler m_WindowSetResizableDelegate;
    public DWebBrowserEvents2_WindowSetLeftEventHandler m_WindowSetLeftDelegate;
    public DWebBrowserEvents2_WindowSetTopEventHandler m_WindowSetTopDelegate;
    public DWebBrowserEvents2_WindowSetWidthEventHandler m_WindowSetWidthDelegate;
    public DWebBrowserEvents2_WindowSetHeightEventHandler m_WindowSetHeightDelegate;
    public DWebBrowserEvents2_WindowClosingEventHandler m_WindowClosingDelegate;
    public DWebBrowserEvents2_ClientToHostWindowEventHandler m_ClientToHostWindowDelegate;
    public DWebBrowserEvents2_SetSecureLockIconEventHandler m_SetSecureLockIconDelegate;
    public DWebBrowserEvents2_FileDownloadEventHandler m_FileDownloadDelegate;
    public DWebBrowserEvents2_NavigateErrorEventHandler m_NavigateErrorDelegate;
    public DWebBrowserEvents2_PrintTemplateInstantiationEventHandler m_PrintTemplateInstantiationDelegate;
    public DWebBrowserEvents2_PrintTemplateTeardownEventHandler m_PrintTemplateTeardownDelegate;
    public DWebBrowserEvents2_UpdatePageStatusEventHandler m_UpdatePageStatusDelegate;
    public DWebBrowserEvents2_PrivacyImpactedStateChangeEventHandler m_PrivacyImpactedStateChangeDelegate;
    public int m_dwCookie;

    public virtual void NewWindow3(
      [In] ref object obj0,
      [In] ref bool obj1,
      [In] uint obj2,
      [In] string obj3,
      [In] string obj4)
    {
      if (this.m_NewWindow3Delegate == null)
        return;
      this.m_NewWindow3Delegate(ref obj0, ref obj1, obj2, obj3, obj4);
    }

    public virtual void SetPhishingFilterStatus([In] int obj0)
    {
      if (this.m_SetPhishingFilterStatusDelegate == null)
        return;
      this.m_SetPhishingFilterStatusDelegate(obj0);
    }

    public virtual void WindowStateChanged([In] uint obj0, [In] uint obj1)
    {
      if (this.m_WindowStateChangedDelegate == null)
        return;
      this.m_WindowStateChangedDelegate(obj0, obj1);
    }

    public virtual void NewProcess([In] int obj0, [In] object obj1, [In] ref bool obj2)
    {
      if (this.m_NewProcessDelegate == null)
        return;
      this.m_NewProcessDelegate(obj0, obj1, ref obj2);
    }

    public virtual void ThirdPartyUrlBlocked([In] ref object obj0, [In] uint obj1)
    {
      if (this.m_ThirdPartyUrlBlockedDelegate == null)
        return;
      this.m_ThirdPartyUrlBlockedDelegate(ref obj0, obj1);
    }

    public virtual void RedirectXDomainBlocked(
      [In] object obj0,
      [In] ref object obj1,
      [In] ref object obj2,
      [In] ref object obj3,
      [In] ref object obj4)
    {
      if (this.m_RedirectXDomainBlockedDelegate == null)
        return;
      this.m_RedirectXDomainBlockedDelegate(obj0, ref obj1, ref obj2, ref obj3, ref obj4);
    }

    public virtual void BeforeScriptExecute([In] object obj0)
    {
      if (this.m_BeforeScriptExecuteDelegate == null)
        return;
      this.m_BeforeScriptExecuteDelegate(obj0);
    }

    public virtual void WebWorkerStarted([In] uint obj0, [In] string obj1)
    {
      if (this.m_WebWorkerStartedDelegate == null)
        return;
      this.m_WebWorkerStartedDelegate(obj0, obj1);
    }

    public virtual void WebWorkerFinsihed([In] uint obj0)
    {
      if (this.m_WebWorkerFinsihedDelegate == null)
        return;
      this.m_WebWorkerFinsihedDelegate(obj0);
    }

    public virtual void StatusTextChange([In] string obj0)
    {
      if (this.m_StatusTextChangeDelegate == null)
        return;
      this.m_StatusTextChangeDelegate(obj0);
    }

    public virtual void ProgressChange([In] int obj0, [In] int obj1)
    {
      if (this.m_ProgressChangeDelegate == null)
        return;
      this.m_ProgressChangeDelegate(obj0, obj1);
    }

    public virtual void CommandStateChange([In] int obj0, [In] bool obj1)
    {
      if (this.m_CommandStateChangeDelegate == null)
        return;
      this.m_CommandStateChangeDelegate(obj0, obj1);
    }

    public virtual void DownloadBegin()
    {
      if (this.m_DownloadBeginDelegate == null)
        return;
      this.m_DownloadBeginDelegate();
    }

    public virtual void DownloadComplete()
    {
      if (this.m_DownloadCompleteDelegate == null)
        return;
      this.m_DownloadCompleteDelegate();
    }

    public virtual void TitleChange([In] string obj0)
    {
      if (this.m_TitleChangeDelegate == null)
        return;
      this.m_TitleChangeDelegate(obj0);
    }

    public virtual void PropertyChange([In] string obj0)
    {
      if (this.m_PropertyChangeDelegate == null)
        return;
      this.m_PropertyChangeDelegate(obj0);
    }

    public virtual void BeforeNavigate2(
      [In] object obj0,
      [In] ref object obj1,
      [In] ref object obj2,
      [In] ref object obj3,
      [In] ref object obj4,
      [In] ref object obj5,
      [In] ref bool obj6)
    {
      if (this.m_BeforeNavigate2Delegate == null)
        return;
      this.m_BeforeNavigate2Delegate(obj0, ref obj1, ref obj2, ref obj3, ref obj4, ref obj5, ref obj6);
    }

    public virtual void NewWindow2([In] ref object obj0, [In] ref bool obj1)
    {
      if (this.m_NewWindow2Delegate == null)
        return;
      this.m_NewWindow2Delegate(ref obj0, ref obj1);
    }

    public virtual void NavigateComplete2([In] object obj0, [In] ref object obj1)
    {
      if (this.m_NavigateComplete2Delegate == null)
        return;
      this.m_NavigateComplete2Delegate(obj0, ref obj1);
    }

    public virtual void DocumentComplete([In] object obj0, [In] ref object obj1)
    {
      if (this.m_DocumentCompleteDelegate == null)
        return;
      this.m_DocumentCompleteDelegate(obj0, ref obj1);
    }

    public virtual void OnQuit()
    {
      if (this.m_OnQuitDelegate == null)
        return;
      this.m_OnQuitDelegate();
    }

    public virtual void OnVisible([In] bool obj0)
    {
      if (this.m_OnVisibleDelegate == null)
        return;
      this.m_OnVisibleDelegate(obj0);
    }

    public virtual void OnToolBar([In] bool obj0)
    {
      if (this.m_OnToolBarDelegate == null)
        return;
      this.m_OnToolBarDelegate(obj0);
    }

    public virtual void OnMenuBar([In] bool obj0)
    {
      if (this.m_OnMenuBarDelegate == null)
        return;
      this.m_OnMenuBarDelegate(obj0);
    }

    public virtual void OnStatusBar([In] bool obj0)
    {
      if (this.m_OnStatusBarDelegate == null)
        return;
      this.m_OnStatusBarDelegate(obj0);
    }

    public virtual void OnFullScreen([In] bool obj0)
    {
      if (this.m_OnFullScreenDelegate == null)
        return;
      this.m_OnFullScreenDelegate(obj0);
    }

    public virtual void OnTheaterMode([In] bool obj0)
    {
      if (this.m_OnTheaterModeDelegate == null)
        return;
      this.m_OnTheaterModeDelegate(obj0);
    }

    public virtual void WindowSetResizable([In] bool obj0)
    {
      if (this.m_WindowSetResizableDelegate == null)
        return;
      this.m_WindowSetResizableDelegate(obj0);
    }

    public virtual void WindowSetLeft([In] int obj0)
    {
      if (this.m_WindowSetLeftDelegate == null)
        return;
      this.m_WindowSetLeftDelegate(obj0);
    }

    public virtual void WindowSetTop([In] int obj0)
    {
      if (this.m_WindowSetTopDelegate == null)
        return;
      this.m_WindowSetTopDelegate(obj0);
    }

    public virtual void WindowSetWidth([In] int obj0)
    {
      if (this.m_WindowSetWidthDelegate == null)
        return;
      this.m_WindowSetWidthDelegate(obj0);
    }

    public virtual void WindowSetHeight([In] int obj0)
    {
      if (this.m_WindowSetHeightDelegate == null)
        return;
      this.m_WindowSetHeightDelegate(obj0);
    }

    public virtual void WindowClosing([In] bool obj0, [In] ref bool obj1)
    {
      if (this.m_WindowClosingDelegate == null)
        return;
      this.m_WindowClosingDelegate(obj0, ref obj1);
    }

    public virtual void ClientToHostWindow([In] ref int obj0, [In] ref int obj1)
    {
      if (this.m_ClientToHostWindowDelegate == null)
        return;
      this.m_ClientToHostWindowDelegate(ref obj0, ref obj1);
    }

    public virtual void SetSecureLockIcon([In] int obj0)
    {
      if (this.m_SetSecureLockIconDelegate == null)
        return;
      this.m_SetSecureLockIconDelegate(obj0);
    }

    public virtual void FileDownload([In] bool obj0, [In] ref bool obj1)
    {
      if (this.m_FileDownloadDelegate == null)
        return;
      this.m_FileDownloadDelegate(obj0, ref obj1);
    }

    public virtual void NavigateError(
      [In] object obj0,
      [In] ref object obj1,
      [In] ref object obj2,
      [In] ref object obj3,
      [In] ref bool obj4)
    {
      if (this.m_NavigateErrorDelegate == null)
        return;
      this.m_NavigateErrorDelegate(obj0, ref obj1, ref obj2, ref obj3, ref obj4);
    }

    public virtual void PrintTemplateInstantiation([In] object obj0)
    {
      if (this.m_PrintTemplateInstantiationDelegate == null)
        return;
      this.m_PrintTemplateInstantiationDelegate(obj0);
    }

    public virtual void PrintTemplateTeardown([In] object obj0)
    {
      if (this.m_PrintTemplateTeardownDelegate == null)
        return;
      this.m_PrintTemplateTeardownDelegate(obj0);
    }

    public virtual void UpdatePageStatus([In] object obj0, [In] ref object obj1, [In] ref object obj2)
    {
      if (this.m_UpdatePageStatusDelegate == null)
        return;
      this.m_UpdatePageStatusDelegate(obj0, ref obj1, ref obj2);
    }

    public virtual void PrivacyImpactedStateChange([In] bool obj0)
    {
      if (this.m_PrivacyImpactedStateChangeDelegate == null)
        return;
      this.m_PrivacyImpactedStateChangeDelegate(obj0);
    }

    internal DWebBrowserEvents2_SinkHelper()
    {
      this.m_dwCookie = 0;
      this.m_NewWindow3Delegate = (DWebBrowserEvents2_NewWindow3EventHandler) null;
      this.m_SetPhishingFilterStatusDelegate = (DWebBrowserEvents2_SetPhishingFilterStatusEventHandler) null;
      this.m_WindowStateChangedDelegate = (DWebBrowserEvents2_WindowStateChangedEventHandler) null;
      this.m_NewProcessDelegate = (DWebBrowserEvents2_NewProcessEventHandler) null;
      this.m_ThirdPartyUrlBlockedDelegate = (DWebBrowserEvents2_ThirdPartyUrlBlockedEventHandler) null;
      this.m_RedirectXDomainBlockedDelegate = (DWebBrowserEvents2_RedirectXDomainBlockedEventHandler) null;
      this.m_BeforeScriptExecuteDelegate = (DWebBrowserEvents2_BeforeScriptExecuteEventHandler) null;
      this.m_WebWorkerStartedDelegate = (DWebBrowserEvents2_WebWorkerStartedEventHandler) null;
      this.m_WebWorkerFinsihedDelegate = (DWebBrowserEvents2_WebWorkerFinsihedEventHandler) null;
      this.m_StatusTextChangeDelegate = (DWebBrowserEvents2_StatusTextChangeEventHandler) null;
      this.m_ProgressChangeDelegate = (DWebBrowserEvents2_ProgressChangeEventHandler) null;
      this.m_CommandStateChangeDelegate = (DWebBrowserEvents2_CommandStateChangeEventHandler) null;
      this.m_DownloadBeginDelegate = (DWebBrowserEvents2_DownloadBeginEventHandler) null;
      this.m_DownloadCompleteDelegate = (DWebBrowserEvents2_DownloadCompleteEventHandler) null;
      this.m_TitleChangeDelegate = (DWebBrowserEvents2_TitleChangeEventHandler) null;
      this.m_PropertyChangeDelegate = (DWebBrowserEvents2_PropertyChangeEventHandler) null;
      this.m_BeforeNavigate2Delegate = (DWebBrowserEvents2_BeforeNavigate2EventHandler) null;
      this.m_NewWindow2Delegate = (DWebBrowserEvents2_NewWindow2EventHandler) null;
      this.m_NavigateComplete2Delegate = (DWebBrowserEvents2_NavigateComplete2EventHandler) null;
      this.m_DocumentCompleteDelegate = (DWebBrowserEvents2_DocumentCompleteEventHandler) null;
      this.m_OnQuitDelegate = (DWebBrowserEvents2_OnQuitEventHandler) null;
      this.m_OnVisibleDelegate = (DWebBrowserEvents2_OnVisibleEventHandler) null;
      this.m_OnToolBarDelegate = (DWebBrowserEvents2_OnToolBarEventHandler) null;
      this.m_OnMenuBarDelegate = (DWebBrowserEvents2_OnMenuBarEventHandler) null;
      this.m_OnStatusBarDelegate = (DWebBrowserEvents2_OnStatusBarEventHandler) null;
      this.m_OnFullScreenDelegate = (DWebBrowserEvents2_OnFullScreenEventHandler) null;
      this.m_OnTheaterModeDelegate = (DWebBrowserEvents2_OnTheaterModeEventHandler) null;
      this.m_WindowSetResizableDelegate = (DWebBrowserEvents2_WindowSetResizableEventHandler) null;
      this.m_WindowSetLeftDelegate = (DWebBrowserEvents2_WindowSetLeftEventHandler) null;
      this.m_WindowSetTopDelegate = (DWebBrowserEvents2_WindowSetTopEventHandler) null;
      this.m_WindowSetWidthDelegate = (DWebBrowserEvents2_WindowSetWidthEventHandler) null;
      this.m_WindowSetHeightDelegate = (DWebBrowserEvents2_WindowSetHeightEventHandler) null;
      this.m_WindowClosingDelegate = (DWebBrowserEvents2_WindowClosingEventHandler) null;
      this.m_ClientToHostWindowDelegate = (DWebBrowserEvents2_ClientToHostWindowEventHandler) null;
      this.m_SetSecureLockIconDelegate = (DWebBrowserEvents2_SetSecureLockIconEventHandler) null;
      this.m_FileDownloadDelegate = (DWebBrowserEvents2_FileDownloadEventHandler) null;
      this.m_NavigateErrorDelegate = (DWebBrowserEvents2_NavigateErrorEventHandler) null;
      this.m_PrintTemplateInstantiationDelegate = (DWebBrowserEvents2_PrintTemplateInstantiationEventHandler) null;
      this.m_PrintTemplateTeardownDelegate = (DWebBrowserEvents2_PrintTemplateTeardownEventHandler) null;
      this.m_UpdatePageStatusDelegate = (DWebBrowserEvents2_UpdatePageStatusEventHandler) null;
      this.m_PrivacyImpactedStateChangeDelegate = (DWebBrowserEvents2_PrivacyImpactedStateChangeEventHandler) null;
    }
  }
}
