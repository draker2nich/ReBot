// Decompiled with JetBrains decompiler
// Type: SHDocVw.DShellNameSpaceEvents_EventProvider
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
  internal sealed class DShellNameSpaceEvents_EventProvider : 
    DShellNameSpaceEvents_Event,
    IDisposable
  {
    private IConnectionPointContainer m_ConnectionPointContainer;
    private ArrayList m_aEventSinkHelpers;
    private IConnectionPoint m_ConnectionPoint;

    private void Init()
    {
      IConnectionPoint ppCP = (IConnectionPoint) null;
      Guid riid = new Guid(new byte[16]
      {
        (byte) 6,
        (byte) 104,
        (byte) 19,
        (byte) 85,
        (byte) 222,
        (byte) 178,
        (byte) 209,
        (byte) 17,
        (byte) 185,
        (byte) 242,
        (byte) 0,
        (byte) 160,
        (byte) 201,
        (byte) 139,
        (byte) 197,
        (byte) 71
      });
      this.m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
      this.m_ConnectionPoint = ppCP;
      this.m_aEventSinkHelpers = new ArrayList();
    }

    public virtual void add_FavoritesSelectionChange(
      [In] DShellNameSpaceEvents_FavoritesSelectionChangeEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_ConnectionPoint == null)
          this.Init();
        DShellNameSpaceEvents_SinkHelper pUnkSink = new DShellNameSpaceEvents_SinkHelper();
        int pdwCookie = 0;
        this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
        pUnkSink.m_dwCookie = pdwCookie;
        pUnkSink.m_FavoritesSelectionChangeDelegate = obj0;
        this.m_aEventSinkHelpers.Add((object) pUnkSink);
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void remove_FavoritesSelectionChange(
      [In] DShellNameSpaceEvents_FavoritesSelectionChangeEventHandler obj0)
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
          DShellNameSpaceEvents_SinkHelper aEventSinkHelper = (DShellNameSpaceEvents_SinkHelper) this.m_aEventSinkHelpers[index];
          if (aEventSinkHelper.m_FavoritesSelectionChangeDelegate != null && ((aEventSinkHelper.m_FavoritesSelectionChangeDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

    public virtual void add_SelectionChange(
      [In] DShellNameSpaceEvents_SelectionChangeEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_ConnectionPoint == null)
          this.Init();
        DShellNameSpaceEvents_SinkHelper pUnkSink = new DShellNameSpaceEvents_SinkHelper();
        int pdwCookie = 0;
        this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
        pUnkSink.m_dwCookie = pdwCookie;
        pUnkSink.m_SelectionChangeDelegate = obj0;
        this.m_aEventSinkHelpers.Add((object) pUnkSink);
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void remove_SelectionChange(
      [In] DShellNameSpaceEvents_SelectionChangeEventHandler obj0)
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
          DShellNameSpaceEvents_SinkHelper aEventSinkHelper = (DShellNameSpaceEvents_SinkHelper) this.m_aEventSinkHelpers[index];
          if (aEventSinkHelper.m_SelectionChangeDelegate != null && ((aEventSinkHelper.m_SelectionChangeDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

    public virtual void add_DoubleClick([In] DShellNameSpaceEvents_DoubleClickEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_ConnectionPoint == null)
          this.Init();
        DShellNameSpaceEvents_SinkHelper pUnkSink = new DShellNameSpaceEvents_SinkHelper();
        int pdwCookie = 0;
        this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
        pUnkSink.m_dwCookie = pdwCookie;
        pUnkSink.m_DoubleClickDelegate = obj0;
        this.m_aEventSinkHelpers.Add((object) pUnkSink);
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void remove_DoubleClick([In] DShellNameSpaceEvents_DoubleClickEventHandler obj0)
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
          DShellNameSpaceEvents_SinkHelper aEventSinkHelper = (DShellNameSpaceEvents_SinkHelper) this.m_aEventSinkHelpers[index];
          if (aEventSinkHelper.m_DoubleClickDelegate != null && ((aEventSinkHelper.m_DoubleClickDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

    public virtual void add_Initialized([In] DShellNameSpaceEvents_InitializedEventHandler obj0)
    {
      Monitor.Enter((object) this);
      try
      {
        if (this.m_ConnectionPoint == null)
          this.Init();
        DShellNameSpaceEvents_SinkHelper pUnkSink = new DShellNameSpaceEvents_SinkHelper();
        int pdwCookie = 0;
        this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
        pUnkSink.m_dwCookie = pdwCookie;
        pUnkSink.m_InitializedDelegate = obj0;
        this.m_aEventSinkHelpers.Add((object) pUnkSink);
      }
      finally
      {
        Monitor.Exit((object) this);
      }
    }

    public virtual void remove_Initialized([In] DShellNameSpaceEvents_InitializedEventHandler obj0)
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
          DShellNameSpaceEvents_SinkHelper aEventSinkHelper = (DShellNameSpaceEvents_SinkHelper) this.m_aEventSinkHelpers[index];
          if (aEventSinkHelper.m_InitializedDelegate != null && ((aEventSinkHelper.m_InitializedDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

    public DShellNameSpaceEvents_EventProvider([In] object obj0)
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
            this.m_ConnectionPoint.Unadvise(((DShellNameSpaceEvents_SinkHelper) this.m_aEventSinkHelpers[index]).m_dwCookie);
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
