// Decompiled with JetBrains decompiler
// Type: SHDocVw.DWebBrowserEvents_SinkHelper
// Assembly: ReBot, Version=3.9.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 147AC50F-40E8-4B39-8462-ADDDE720DD9F
// Assembly location: C:\Users\pcfor\Downloads\ReBot.exe

using System.Runtime.InteropServices;

#nullable disable
namespace SHDocVw
{
  [TypeLibType(TypeLibTypeFlags.FHidden)]
  [ClassInterface(ClassInterfaceType.None)]
  public sealed class DWebBrowserEvents_SinkHelper : DWebBrowserEvents
  {
    public DWebBrowserEvents_BeforeNavigateEventHandler m_BeforeNavigateDelegate;
    public DWebBrowserEvents_NavigateCompleteEventHandler m_NavigateCompleteDelegate;
    public DWebBrowserEvents_StatusTextChangeEventHandler m_StatusTextChangeDelegate;
    public DWebBrowserEvents_ProgressChangeEventHandler m_ProgressChangeDelegate;
    public DWebBrowserEvents_DownloadCompleteEventHandler m_DownloadCompleteDelegate;
    public DWebBrowserEvents_CommandStateChangeEventHandler m_CommandStateChangeDelegate;
    public DWebBrowserEvents_DownloadBeginEventHandler m_DownloadBeginDelegate;
    public DWebBrowserEvents_NewWindowEventHandler m_NewWindowDelegate;
    public DWebBrowserEvents_TitleChangeEventHandler m_TitleChangeDelegate;
    public DWebBrowserEvents_FrameBeforeNavigateEventHandler m_FrameBeforeNavigateDelegate;
    public DWebBrowserEvents_FrameNavigateCompleteEventHandler m_FrameNavigateCompleteDelegate;
    public DWebBrowserEvents_FrameNewWindowEventHandler m_FrameNewWindowDelegate;
    public DWebBrowserEvents_QuitEventHandler m_QuitDelegate;
    public DWebBrowserEvents_WindowMoveEventHandler m_WindowMoveDelegate;
    public DWebBrowserEvents_WindowResizeEventHandler m_WindowResizeDelegate;
    public DWebBrowserEvents_WindowActivateEventHandler m_WindowActivateDelegate;
    public DWebBrowserEvents_PropertyChangeEventHandler m_PropertyChangeDelegate;
    public int m_dwCookie;

    public virtual void BeforeNavigate(
      [In] string obj0,
      [In] int obj1,
      [In] string obj2,
      [In] ref object obj3,
      [In] string obj4,
      [In] ref bool obj5)
    {
      if (this.m_BeforeNavigateDelegate == null)
        return;
      this.m_BeforeNavigateDelegate(obj0, obj1, obj2, ref obj3, obj4, ref obj5);
    }

    public virtual void NavigateComplete([In] string obj0)
    {
      if (this.m_NavigateCompleteDelegate == null)
        return;
      this.m_NavigateCompleteDelegate(obj0);
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

    public virtual void DownloadComplete()
    {
      if (this.m_DownloadCompleteDelegate == null)
        return;
      this.m_DownloadCompleteDelegate();
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

    public virtual void NewWindow(
      [In] string obj0,
      [In] int obj1,
      [In] string obj2,
      [In] ref object obj3,
      [In] string obj4,
      [In] ref bool obj5)
    {
      if (this.m_NewWindowDelegate == null)
        return;
      this.m_NewWindowDelegate(obj0, obj1, obj2, ref obj3, obj4, ref obj5);
    }

    public virtual void TitleChange([In] string obj0)
    {
      if (this.m_TitleChangeDelegate == null)
        return;
      this.m_TitleChangeDelegate(obj0);
    }

    public virtual void FrameBeforeNavigate(
      [In] string obj0,
      [In] int obj1,
      [In] string obj2,
      [In] ref object obj3,
      [In] string obj4,
      [In] ref bool obj5)
    {
      if (this.m_FrameBeforeNavigateDelegate == null)
        return;
      this.m_FrameBeforeNavigateDelegate(obj0, obj1, obj2, ref obj3, obj4, ref obj5);
    }

    public virtual void FrameNavigateComplete([In] string obj0)
    {
      if (this.m_FrameNavigateCompleteDelegate == null)
        return;
      this.m_FrameNavigateCompleteDelegate(obj0);
    }

    public virtual void FrameNewWindow(
      [In] string obj0,
      [In] int obj1,
      [In] string obj2,
      [In] ref object obj3,
      [In] string obj4,
      [In] ref bool obj5)
    {
      if (this.m_FrameNewWindowDelegate == null)
        return;
      this.m_FrameNewWindowDelegate(obj0, obj1, obj2, ref obj3, obj4, ref obj5);
    }

    public virtual void Quit([In] ref bool obj0)
    {
      if (this.m_QuitDelegate == null)
        return;
      this.m_QuitDelegate(ref obj0);
    }

    public virtual void WindowMove()
    {
      if (this.m_WindowMoveDelegate == null)
        return;
      this.m_WindowMoveDelegate();
    }

    public virtual void WindowResize()
    {
      if (this.m_WindowResizeDelegate == null)
        return;
      this.m_WindowResizeDelegate();
    }

    public virtual void WindowActivate()
    {
      if (this.m_WindowActivateDelegate == null)
        return;
      this.m_WindowActivateDelegate();
    }

    public virtual void PropertyChange([In] string obj0)
    {
      if (this.m_PropertyChangeDelegate == null)
        return;
      this.m_PropertyChangeDelegate(obj0);
    }

    internal DWebBrowserEvents_SinkHelper()
    {
      this.m_dwCookie = 0;
      this.m_BeforeNavigateDelegate = (DWebBrowserEvents_BeforeNavigateEventHandler) null;
      this.m_NavigateCompleteDelegate = (DWebBrowserEvents_NavigateCompleteEventHandler) null;
      this.m_StatusTextChangeDelegate = (DWebBrowserEvents_StatusTextChangeEventHandler) null;
      this.m_ProgressChangeDelegate = (DWebBrowserEvents_ProgressChangeEventHandler) null;
      this.m_DownloadCompleteDelegate = (DWebBrowserEvents_DownloadCompleteEventHandler) null;
      this.m_CommandStateChangeDelegate = (DWebBrowserEvents_CommandStateChangeEventHandler) null;
      this.m_DownloadBeginDelegate = (DWebBrowserEvents_DownloadBeginEventHandler) null;
      this.m_NewWindowDelegate = (DWebBrowserEvents_NewWindowEventHandler) null;
      this.m_TitleChangeDelegate = (DWebBrowserEvents_TitleChangeEventHandler) null;
      this.m_FrameBeforeNavigateDelegate = (DWebBrowserEvents_FrameBeforeNavigateEventHandler) null;
      this.m_FrameNavigateCompleteDelegate = (DWebBrowserEvents_FrameNavigateCompleteEventHandler) null;
      this.m_FrameNewWindowDelegate = (DWebBrowserEvents_FrameNewWindowEventHandler) null;
      this.m_QuitDelegate = (DWebBrowserEvents_QuitEventHandler) null;
      this.m_WindowMoveDelegate = (DWebBrowserEvents_WindowMoveEventHandler) null;
      this.m_WindowResizeDelegate = (DWebBrowserEvents_WindowResizeEventHandler) null;
      this.m_WindowActivateDelegate = (DWebBrowserEvents_WindowActivateEventHandler) null;
      this.m_PropertyChangeDelegate = (DWebBrowserEvents_PropertyChangeEventHandler) null;
    }
  }
}
