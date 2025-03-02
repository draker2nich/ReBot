// Decompiled with JetBrains decompiler
// Type: SHDocVw.DWebBrowserEvents_EventProvider
// Assembly: ReBot, Version=3.9.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 147AC50F-40E8-4B39-8462-ADDDE720DD9F
// Assembly location: C:\Users\pcfor\Downloads\ReBot.exe

using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

#nullable disable
namespace SHDocVw
{
  internal sealed class DWebBrowserEvents_EventProvider : DWebBrowserEvents_Event, IDisposable
  {
    private IConnectionPointContainer m_ConnectionPointContainer;
    private ArrayList m_aEventSinkHelpers;
    private IConnectionPoint m_ConnectionPoint;

    private void Init()
    {
      IConnectionPoint ppCP = (IConnectionPoint) null;
      Guid riid = new Guid(new byte[16]
      {
        (byte) 194,
        (byte) 42,
        (byte) 178,
        (byte) 234,
        (byte) 193,
        (byte) 48,
        (byte) 207,
        (byte) 17,
        (byte) 167,
        (byte) 235,
        (byte) 0,
        (byte) 0,
        (byte) 192,
        (byte) 91,
        (byte) 174,
        (byte) 11
      });
      this.m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
      this.m_ConnectionPoint = ppCP;
      this.m_aEventSinkHelpers = new ArrayList();
    }

    public virtual void add_BeforeNavigate([In] DWebBrowserEvents_BeforeNavigateEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_ConnectionPoint == null)
          this.Init();
        DWebBrowserEvents_SinkHelper pUnkSink = new DWebBrowserEvents_SinkHelper();
        int pdwCookie = 0;
        this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
        pUnkSink.m_dwCookie = pdwCookie;
        pUnkSink.m_BeforeNavigateDelegate = obj0;
        this.m_aEventSinkHelpers.Add((object) pUnkSink);
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void remove_BeforeNavigate([In] DWebBrowserEvents_BeforeNavigateEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_aEventSinkHelpers == null)
          return;
        int count = this.m_aEventSinkHelpers.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          DWebBrowserEvents_SinkHelper aEventSinkHelper = (DWebBrowserEvents_SinkHelper) this.m_aEventSinkHelpers[index];
          if (aEventSinkHelper.m_BeforeNavigateDelegate != null && ((aEventSinkHelper.m_BeforeNavigateDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.m_aEventSinkHelpers.RemoveAt(index);
            this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
              this.m_ConnectionPoint = (IConnectionPoint) null;
              this.m_aEventSinkHelpers = (ArrayList) null;
              return;
            }
            goto label_10;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_11;
label_10:
        return;
label_11:;
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void add_NavigateComplete(
      [In] DWebBrowserEvents_NavigateCompleteEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_ConnectionPoint == null)
          this.Init();
        DWebBrowserEvents_SinkHelper pUnkSink = new DWebBrowserEvents_SinkHelper();
        int pdwCookie = 0;
        this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
        pUnkSink.m_dwCookie = pdwCookie;
        pUnkSink.m_NavigateCompleteDelegate = obj0;
        this.m_aEventSinkHelpers.Add((object) pUnkSink);
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void remove_NavigateComplete(
      [In] DWebBrowserEvents_NavigateCompleteEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_aEventSinkHelpers == null)
          return;
        int count = this.m_aEventSinkHelpers.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          DWebBrowserEvents_SinkHelper aEventSinkHelper = (DWebBrowserEvents_SinkHelper) this.m_aEventSinkHelpers[index];
          if (aEventSinkHelper.m_NavigateCompleteDelegate != null && ((aEventSinkHelper.m_NavigateCompleteDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.m_aEventSinkHelpers.RemoveAt(index);
            this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
              this.m_ConnectionPoint = (IConnectionPoint) null;
              this.m_aEventSinkHelpers = (ArrayList) null;
              return;
            }
            goto label_10;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_11;
label_10:
        return;
label_11:;
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void add_StatusTextChange(
      [In] DWebBrowserEvents_StatusTextChangeEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_ConnectionPoint == null)
          this.Init();
        DWebBrowserEvents_SinkHelper pUnkSink = new DWebBrowserEvents_SinkHelper();
        int pdwCookie = 0;
        this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
        pUnkSink.m_dwCookie = pdwCookie;
        pUnkSink.m_StatusTextChangeDelegate = obj0;
        this.m_aEventSinkHelpers.Add((object) pUnkSink);
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void remove_StatusTextChange(
      [In] DWebBrowserEvents_StatusTextChangeEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_aEventSinkHelpers == null)
          return;
        int count = this.m_aEventSinkHelpers.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          DWebBrowserEvents_SinkHelper aEventSinkHelper = (DWebBrowserEvents_SinkHelper) this.m_aEventSinkHelpers[index];
          if (aEventSinkHelper.m_StatusTextChangeDelegate != null && ((aEventSinkHelper.m_StatusTextChangeDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.m_aEventSinkHelpers.RemoveAt(index);
            this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
              this.m_ConnectionPoint = (IConnectionPoint) null;
              this.m_aEventSinkHelpers = (ArrayList) null;
              return;
            }
            goto label_10;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_11;
label_10:
        return;
label_11:;
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void add_ProgressChange([In] DWebBrowserEvents_ProgressChangeEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_ConnectionPoint == null)
          this.Init();
        DWebBrowserEvents_SinkHelper pUnkSink = new DWebBrowserEvents_SinkHelper();
        int pdwCookie = 0;
        this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
        pUnkSink.m_dwCookie = pdwCookie;
        pUnkSink.m_ProgressChangeDelegate = obj0;
        this.m_aEventSinkHelpers.Add((object) pUnkSink);
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void remove_ProgressChange([In] DWebBrowserEvents_ProgressChangeEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_aEventSinkHelpers == null)
          return;
        int count = this.m_aEventSinkHelpers.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          DWebBrowserEvents_SinkHelper aEventSinkHelper = (DWebBrowserEvents_SinkHelper) this.m_aEventSinkHelpers[index];
          if (aEventSinkHelper.m_ProgressChangeDelegate != null && ((aEventSinkHelper.m_ProgressChangeDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.m_aEventSinkHelpers.RemoveAt(index);
            this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
              this.m_ConnectionPoint = (IConnectionPoint) null;
              this.m_aEventSinkHelpers = (ArrayList) null;
              return;
            }
            goto label_10;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_11;
label_10:
        return;
label_11:;
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void add_DownloadComplete(
      [In] DWebBrowserEvents_DownloadCompleteEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_ConnectionPoint == null)
          this.Init();
        DWebBrowserEvents_SinkHelper pUnkSink = new DWebBrowserEvents_SinkHelper();
        int pdwCookie = 0;
        this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
        pUnkSink.m_dwCookie = pdwCookie;
        pUnkSink.m_DownloadCompleteDelegate = obj0;
        this.m_aEventSinkHelpers.Add((object) pUnkSink);
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void remove_DownloadComplete(
      [In] DWebBrowserEvents_DownloadCompleteEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_aEventSinkHelpers == null)
          return;
        int count = this.m_aEventSinkHelpers.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          DWebBrowserEvents_SinkHelper aEventSinkHelper = (DWebBrowserEvents_SinkHelper) this.m_aEventSinkHelpers[index];
          if (aEventSinkHelper.m_DownloadCompleteDelegate != null && ((aEventSinkHelper.m_DownloadCompleteDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.m_aEventSinkHelpers.RemoveAt(index);
            this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
              this.m_ConnectionPoint = (IConnectionPoint) null;
              this.m_aEventSinkHelpers = (ArrayList) null;
              return;
            }
            goto label_10;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_11;
label_10:
        return;
label_11:;
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void add_CommandStateChange(
      [In] DWebBrowserEvents_CommandStateChangeEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_ConnectionPoint == null)
          this.Init();
        DWebBrowserEvents_SinkHelper pUnkSink = new DWebBrowserEvents_SinkHelper();
        int pdwCookie = 0;
        this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
        pUnkSink.m_dwCookie = pdwCookie;
        pUnkSink.m_CommandStateChangeDelegate = obj0;
        this.m_aEventSinkHelpers.Add((object) pUnkSink);
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void remove_CommandStateChange(
      [In] DWebBrowserEvents_CommandStateChangeEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_aEventSinkHelpers == null)
          return;
        int count = this.m_aEventSinkHelpers.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          DWebBrowserEvents_SinkHelper aEventSinkHelper = (DWebBrowserEvents_SinkHelper) this.m_aEventSinkHelpers[index];
          if (aEventSinkHelper.m_CommandStateChangeDelegate != null && ((aEventSinkHelper.m_CommandStateChangeDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.m_aEventSinkHelpers.RemoveAt(index);
            this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
              this.m_ConnectionPoint = (IConnectionPoint) null;
              this.m_aEventSinkHelpers = (ArrayList) null;
              return;
            }
            goto label_10;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_11;
label_10:
        return;
label_11:;
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void add_DownloadBegin([In] DWebBrowserEvents_DownloadBeginEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_ConnectionPoint == null)
          this.Init();
        DWebBrowserEvents_SinkHelper pUnkSink = new DWebBrowserEvents_SinkHelper();
        int pdwCookie = 0;
        this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
        pUnkSink.m_dwCookie = pdwCookie;
        pUnkSink.m_DownloadBeginDelegate = obj0;
        this.m_aEventSinkHelpers.Add((object) pUnkSink);
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void remove_DownloadBegin([In] DWebBrowserEvents_DownloadBeginEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_aEventSinkHelpers == null)
          return;
        int count = this.m_aEventSinkHelpers.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          DWebBrowserEvents_SinkHelper aEventSinkHelper = (DWebBrowserEvents_SinkHelper) this.m_aEventSinkHelpers[index];
          if (aEventSinkHelper.m_DownloadBeginDelegate != null && ((aEventSinkHelper.m_DownloadBeginDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.m_aEventSinkHelpers.RemoveAt(index);
            this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
              this.m_ConnectionPoint = (IConnectionPoint) null;
              this.m_aEventSinkHelpers = (ArrayList) null;
              return;
            }
            goto label_10;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_11;
label_10:
        return;
label_11:;
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void add_NewWindow([In] DWebBrowserEvents_NewWindowEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_ConnectionPoint == null)
          this.Init();
        DWebBrowserEvents_SinkHelper pUnkSink = new DWebBrowserEvents_SinkHelper();
        int pdwCookie = 0;
        this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
        pUnkSink.m_dwCookie = pdwCookie;
        pUnkSink.m_NewWindowDelegate = obj0;
        this.m_aEventSinkHelpers.Add((object) pUnkSink);
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void remove_NewWindow([In] DWebBrowserEvents_NewWindowEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_aEventSinkHelpers == null)
          return;
        int count = this.m_aEventSinkHelpers.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          DWebBrowserEvents_SinkHelper aEventSinkHelper = (DWebBrowserEvents_SinkHelper) this.m_aEventSinkHelpers[index];
          if (aEventSinkHelper.m_NewWindowDelegate != null && ((aEventSinkHelper.m_NewWindowDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.m_aEventSinkHelpers.RemoveAt(index);
            this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
              this.m_ConnectionPoint = (IConnectionPoint) null;
              this.m_aEventSinkHelpers = (ArrayList) null;
              return;
            }
            goto label_10;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_11;
label_10:
        return;
label_11:;
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void add_TitleChange([In] DWebBrowserEvents_TitleChangeEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_ConnectionPoint == null)
          this.Init();
        DWebBrowserEvents_SinkHelper pUnkSink = new DWebBrowserEvents_SinkHelper();
        int pdwCookie = 0;
        this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
        pUnkSink.m_dwCookie = pdwCookie;
        pUnkSink.m_TitleChangeDelegate = obj0;
        this.m_aEventSinkHelpers.Add((object) pUnkSink);
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void remove_TitleChange([In] DWebBrowserEvents_TitleChangeEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_aEventSinkHelpers == null)
          return;
        int count = this.m_aEventSinkHelpers.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          DWebBrowserEvents_SinkHelper aEventSinkHelper = (DWebBrowserEvents_SinkHelper) this.m_aEventSinkHelpers[index];
          if (aEventSinkHelper.m_TitleChangeDelegate != null && ((aEventSinkHelper.m_TitleChangeDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.m_aEventSinkHelpers.RemoveAt(index);
            this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
              this.m_ConnectionPoint = (IConnectionPoint) null;
              this.m_aEventSinkHelpers = (ArrayList) null;
              return;
            }
            goto label_10;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_11;
label_10:
        return;
label_11:;
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void add_FrameBeforeNavigate(
      [In] DWebBrowserEvents_FrameBeforeNavigateEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_ConnectionPoint == null)
          this.Init();
        DWebBrowserEvents_SinkHelper pUnkSink = new DWebBrowserEvents_SinkHelper();
        int pdwCookie = 0;
        this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
        pUnkSink.m_dwCookie = pdwCookie;
        pUnkSink.m_FrameBeforeNavigateDelegate = obj0;
        this.m_aEventSinkHelpers.Add((object) pUnkSink);
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void remove_FrameBeforeNavigate(
      [In] DWebBrowserEvents_FrameBeforeNavigateEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_aEventSinkHelpers == null)
          return;
        int count = this.m_aEventSinkHelpers.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          DWebBrowserEvents_SinkHelper aEventSinkHelper = (DWebBrowserEvents_SinkHelper) this.m_aEventSinkHelpers[index];
          if (aEventSinkHelper.m_FrameBeforeNavigateDelegate != null && ((aEventSinkHelper.m_FrameBeforeNavigateDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.m_aEventSinkHelpers.RemoveAt(index);
            this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
              this.m_ConnectionPoint = (IConnectionPoint) null;
              this.m_aEventSinkHelpers = (ArrayList) null;
              return;
            }
            goto label_10;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_11;
label_10:
        return;
label_11:;
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void add_FrameNavigateComplete(
      [In] DWebBrowserEvents_FrameNavigateCompleteEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_ConnectionPoint == null)
          this.Init();
        DWebBrowserEvents_SinkHelper pUnkSink = new DWebBrowserEvents_SinkHelper();
        int pdwCookie = 0;
        this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
        pUnkSink.m_dwCookie = pdwCookie;
        pUnkSink.m_FrameNavigateCompleteDelegate = obj0;
        this.m_aEventSinkHelpers.Add((object) pUnkSink);
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void remove_FrameNavigateComplete(
      [In] DWebBrowserEvents_FrameNavigateCompleteEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_aEventSinkHelpers == null)
          return;
        int count = this.m_aEventSinkHelpers.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          DWebBrowserEvents_SinkHelper aEventSinkHelper = (DWebBrowserEvents_SinkHelper) this.m_aEventSinkHelpers[index];
          if (aEventSinkHelper.m_FrameNavigateCompleteDelegate != null && ((aEventSinkHelper.m_FrameNavigateCompleteDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.m_aEventSinkHelpers.RemoveAt(index);
            this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
              this.m_ConnectionPoint = (IConnectionPoint) null;
              this.m_aEventSinkHelpers = (ArrayList) null;
              return;
            }
            goto label_10;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_11;
label_10:
        return;
label_11:;
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void add_FrameNewWindow([In] DWebBrowserEvents_FrameNewWindowEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_ConnectionPoint == null)
          this.Init();
        DWebBrowserEvents_SinkHelper pUnkSink = new DWebBrowserEvents_SinkHelper();
        int pdwCookie = 0;
        this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
        pUnkSink.m_dwCookie = pdwCookie;
        pUnkSink.m_FrameNewWindowDelegate = obj0;
        this.m_aEventSinkHelpers.Add((object) pUnkSink);
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void remove_FrameNewWindow([In] DWebBrowserEvents_FrameNewWindowEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_aEventSinkHelpers == null)
          return;
        int count = this.m_aEventSinkHelpers.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          DWebBrowserEvents_SinkHelper aEventSinkHelper = (DWebBrowserEvents_SinkHelper) this.m_aEventSinkHelpers[index];
          if (aEventSinkHelper.m_FrameNewWindowDelegate != null && ((aEventSinkHelper.m_FrameNewWindowDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.m_aEventSinkHelpers.RemoveAt(index);
            this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
              this.m_ConnectionPoint = (IConnectionPoint) null;
              this.m_aEventSinkHelpers = (ArrayList) null;
              return;
            }
            goto label_10;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_11;
label_10:
        return;
label_11:;
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void add_Quit([In] DWebBrowserEvents_QuitEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_ConnectionPoint == null)
          this.Init();
        DWebBrowserEvents_SinkHelper pUnkSink = new DWebBrowserEvents_SinkHelper();
        int pdwCookie = 0;
        this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
        pUnkSink.m_dwCookie = pdwCookie;
        pUnkSink.m_QuitDelegate = obj0;
        this.m_aEventSinkHelpers.Add((object) pUnkSink);
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void remove_Quit([In] DWebBrowserEvents_QuitEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_aEventSinkHelpers == null)
          return;
        int count = this.m_aEventSinkHelpers.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          DWebBrowserEvents_SinkHelper aEventSinkHelper = (DWebBrowserEvents_SinkHelper) this.m_aEventSinkHelpers[index];
          if (aEventSinkHelper.m_QuitDelegate != null && ((aEventSinkHelper.m_QuitDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.m_aEventSinkHelpers.RemoveAt(index);
            this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
              this.m_ConnectionPoint = (IConnectionPoint) null;
              this.m_aEventSinkHelpers = (ArrayList) null;
              return;
            }
            goto label_10;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_11;
label_10:
        return;
label_11:;
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void add_WindowMove([In] DWebBrowserEvents_WindowMoveEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_ConnectionPoint == null)
          this.Init();
        DWebBrowserEvents_SinkHelper pUnkSink = new DWebBrowserEvents_SinkHelper();
        int pdwCookie = 0;
        this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
        pUnkSink.m_dwCookie = pdwCookie;
        pUnkSink.m_WindowMoveDelegate = obj0;
        this.m_aEventSinkHelpers.Add((object) pUnkSink);
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void remove_WindowMove([In] DWebBrowserEvents_WindowMoveEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_aEventSinkHelpers == null)
          return;
        int count = this.m_aEventSinkHelpers.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          DWebBrowserEvents_SinkHelper aEventSinkHelper = (DWebBrowserEvents_SinkHelper) this.m_aEventSinkHelpers[index];
          if (aEventSinkHelper.m_WindowMoveDelegate != null && ((aEventSinkHelper.m_WindowMoveDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.m_aEventSinkHelpers.RemoveAt(index);
            this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
              this.m_ConnectionPoint = (IConnectionPoint) null;
              this.m_aEventSinkHelpers = (ArrayList) null;
              return;
            }
            goto label_10;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_11;
label_10:
        return;
label_11:;
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void add_WindowResize([In] DWebBrowserEvents_WindowResizeEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_ConnectionPoint == null)
          this.Init();
        DWebBrowserEvents_SinkHelper pUnkSink = new DWebBrowserEvents_SinkHelper();
        int pdwCookie = 0;
        this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
        pUnkSink.m_dwCookie = pdwCookie;
        pUnkSink.m_WindowResizeDelegate = obj0;
        this.m_aEventSinkHelpers.Add((object) pUnkSink);
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void remove_WindowResize([In] DWebBrowserEvents_WindowResizeEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_aEventSinkHelpers == null)
          return;
        int count = this.m_aEventSinkHelpers.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          DWebBrowserEvents_SinkHelper aEventSinkHelper = (DWebBrowserEvents_SinkHelper) this.m_aEventSinkHelpers[index];
          if (aEventSinkHelper.m_WindowResizeDelegate != null && ((aEventSinkHelper.m_WindowResizeDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.m_aEventSinkHelpers.RemoveAt(index);
            this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
              this.m_ConnectionPoint = (IConnectionPoint) null;
              this.m_aEventSinkHelpers = (ArrayList) null;
              return;
            }
            goto label_10;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_11;
label_10:
        return;
label_11:;
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void add_WindowActivate([In] DWebBrowserEvents_WindowActivateEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_ConnectionPoint == null)
          this.Init();
        DWebBrowserEvents_SinkHelper pUnkSink = new DWebBrowserEvents_SinkHelper();
        int pdwCookie = 0;
        this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
        pUnkSink.m_dwCookie = pdwCookie;
        pUnkSink.m_WindowActivateDelegate = obj0;
        this.m_aEventSinkHelpers.Add((object) pUnkSink);
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void remove_WindowActivate([In] DWebBrowserEvents_WindowActivateEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_aEventSinkHelpers == null)
          return;
        int count = this.m_aEventSinkHelpers.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          DWebBrowserEvents_SinkHelper aEventSinkHelper = (DWebBrowserEvents_SinkHelper) this.m_aEventSinkHelpers[index];
          if (aEventSinkHelper.m_WindowActivateDelegate != null && ((aEventSinkHelper.m_WindowActivateDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.m_aEventSinkHelpers.RemoveAt(index);
            this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
              this.m_ConnectionPoint = (IConnectionPoint) null;
              this.m_aEventSinkHelpers = (ArrayList) null;
              return;
            }
            goto label_10;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_11;
label_10:
        return;
label_11:;
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void add_PropertyChange([In] DWebBrowserEvents_PropertyChangeEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_ConnectionPoint == null)
          this.Init();
        DWebBrowserEvents_SinkHelper pUnkSink = new DWebBrowserEvents_SinkHelper();
        int pdwCookie = 0;
        this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
        pUnkSink.m_dwCookie = pdwCookie;
        pUnkSink.m_PropertyChangeDelegate = obj0;
        this.m_aEventSinkHelpers.Add((object) pUnkSink);
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void remove_PropertyChange([In] DWebBrowserEvents_PropertyChangeEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_aEventSinkHelpers == null)
          return;
        int count = this.m_aEventSinkHelpers.Count;
        int index = 0;
        if (0 >= count)
          return;
        do
        {
          DWebBrowserEvents_SinkHelper aEventSinkHelper = (DWebBrowserEvents_SinkHelper) this.m_aEventSinkHelpers[index];
          if (aEventSinkHelper.m_PropertyChangeDelegate != null && ((aEventSinkHelper.m_PropertyChangeDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
          {
            this.m_aEventSinkHelpers.RemoveAt(index);
            this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
            if (count <= 1)
            {
              Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
              this.m_ConnectionPoint = (IConnectionPoint) null;
              this.m_aEventSinkHelpers = (ArrayList) null;
              return;
            }
            goto label_10;
          }
          else
            ++index;
        }
        while (index < count);
        goto label_11;
label_10:
        return;
label_11:;
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public DWebBrowserEvents_EventProvider([In] object obj0)
    {
      this.m_ConnectionPointContainer = (IConnectionPointContainer) obj0;
    }

    public override void Finalize()
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_ConnectionPoint == null)
          return;
        int count = this.m_aEventSinkHelpers.Count;
        int index = 0;
        if (0 < count)
        {
          do
          {
            this.m_ConnectionPoint.Unadvise(((DWebBrowserEvents_SinkHelper) this.m_aEventSinkHelpers[index]).m_dwCookie);
            ++index;
          }
          while (index < count);
        }
        Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
      }
      catch (Exception ex)
      {
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void Dispose()
    {
      this.Finalize();
      GC.SuppressFinalize((object) this);
    }
  }
}
