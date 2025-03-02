// Decompiled with JetBrains decompiler
// Type: SHDocVw.DShellNameSpaceEvents_SinkHelper
// Assembly: ReBot, Version=3.9.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 147AC50F-40E8-4B39-8462-ADDDE720DD9F
// Assembly location: C:\Users\pcfor\Downloads\ReBot.exe

using System.Runtime.InteropServices;

#nullable disable
namespace SHDocVw
{
  [ClassInterface(ClassInterfaceType.None)]
  [TypeLibType(TypeLibTypeFlags.FHidden)]
  public sealed class DShellNameSpaceEvents_SinkHelper : DShellNameSpaceEvents
  {
    public DShellNameSpaceEvents_FavoritesSelectionChangeEventHandler m_FavoritesSelectionChangeDelegate;
    public DShellNameSpaceEvents_SelectionChangeEventHandler m_SelectionChangeDelegate;
    public DShellNameSpaceEvents_DoubleClickEventHandler m_DoubleClickDelegate;
    public DShellNameSpaceEvents_InitializedEventHandler m_InitializedDelegate;
    public int m_dwCookie;

    public virtual void FavoritesSelectionChange(
      [In] int obj0,
      [In] int obj1,
      [In] string obj2,
      [In] string obj3,
      [In] int obj4,
      [In] string obj5,
      [In] int obj6)
    {
      if (this.m_FavoritesSelectionChangeDelegate == null)
        return;
      this.m_FavoritesSelectionChangeDelegate(obj0, obj1, obj2, obj3, obj4, obj5, obj6);
    }

    public virtual void SelectionChange()
    {
      if (this.m_SelectionChangeDelegate == null)
        return;
      this.m_SelectionChangeDelegate();
    }

    public virtual void DoubleClick()
    {
      if (this.m_DoubleClickDelegate == null)
        return;
      this.m_DoubleClickDelegate();
    }

    public virtual void Initialized()
    {
      if (this.m_InitializedDelegate == null)
        return;
      this.m_InitializedDelegate();
    }

    internal DShellNameSpaceEvents_SinkHelper()
    {
      this.m_dwCookie = 0;
      this.m_FavoritesSelectionChangeDelegate = (DShellNameSpaceEvents_FavoritesSelectionChangeEventHandler) null;
      this.m_SelectionChangeDelegate = (DShellNameSpaceEvents_SelectionChangeEventHandler) null;
      this.m_DoubleClickDelegate = (DShellNameSpaceEvents_DoubleClickEventHandler) null;
      this.m_InitializedDelegate = (DShellNameSpaceEvents_InitializedEventHandler) null;
    }
  }
}
