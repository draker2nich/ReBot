// Decompiled with JetBrains decompiler
// Type: SHDocVw.DShellWindowsEvents_EventProvider
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
  internal sealed class DShellWindowsEvents_EventProvider : DShellWindowsEvents_Event, IDisposable
  {
    private IConnectionPointContainer m_ConnectionPointContainer;
    private ArrayList m_aEventSinkHelpers;
    private IConnectionPoint m_ConnectionPoint;

    private void Init()
    {
      IConnectionPoint ppCP = (IConnectionPoint) null;
      Guid riid = new Guid(new byte[16]
      {
        (byte) 224,
        (byte) 6,
        (byte) 65,
        (byte) 254,
        (byte) 154,
        (byte) 57,
        (byte) 208,
        (byte) 17,
        (byte) 164,
        (byte) 140,
        (byte) 0,
        (byte) 160,
        (byte) 201,
        (byte) 10,
        (byte) 143,
        (byte) 57
      });
      this.m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
      this.m_ConnectionPoint = ppCP;
      this.m_aEventSinkHelpers = new ArrayList();
    }

    public virtual void add_WindowRegistered(
      [In] DShellWindowsEvents_WindowRegisteredEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_ConnectionPoint == null)
          this.Init();
        DShellWindowsEvents_SinkHelper pUnkSink = new DShellWindowsEvents_SinkHelper();
        int pdwCookie = 0;
        this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
        pUnkSink.m_dwCookie = pdwCookie;
        pUnkSink.m_WindowRegisteredDelegate = obj0;
        this.m_aEventSinkHelpers.Add((object) pUnkSink);
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void remove_WindowRegistered(
      [In] DShellWindowsEvents_WindowRegisteredEventHandler obj0)
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
          DShellWindowsEvents_SinkHelper aEventSinkHelper = (DShellWindowsEvents_SinkHelper) this.m_aEventSinkHelpers[index];
          if (aEventSinkHelper.m_WindowRegisteredDelegate != null && ((aEventSinkHelper.m_WindowRegisteredDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

    public virtual void add_WindowRevoked([In] DShellWindowsEvents_WindowRevokedEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_ConnectionPoint == null)
          this.Init();
        DShellWindowsEvents_SinkHelper pUnkSink = new DShellWindowsEvents_SinkHelper();
        int pdwCookie = 0;
        this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
        pUnkSink.m_dwCookie = pdwCookie;
        pUnkSink.m_WindowRevokedDelegate = obj0;
        this.m_aEventSinkHelpers.Add((object) pUnkSink);
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void remove_WindowRevoked([In] DShellWindowsEvents_WindowRevokedEventHandler obj0)
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
          DShellWindowsEvents_SinkHelper aEventSinkHelper = (DShellWindowsEvents_SinkHelper) this.m_aEventSinkHelpers[index];
          if (aEventSinkHelper.m_WindowRevokedDelegate != null && ((aEventSinkHelper.m_WindowRevokedDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

    public DShellWindowsEvents_EventProvider([In] object obj0)
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
            this.m_ConnectionPoint.Unadvise(((DShellWindowsEvents_SinkHelper) this.m_aEventSinkHelpers[index]).m_dwCookie);
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
