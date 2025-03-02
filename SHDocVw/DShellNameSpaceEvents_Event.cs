// Decompiled with JetBrains decompiler
// Type: SHDocVw.DShellNameSpaceEvents_Event
// Assembly: ReBot, Version=3.9.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 147AC50F-40E8-4B39-8462-ADDDE720DD9F
// Assembly location: C:\Users\pcfor\Downloads\ReBot.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace SHDocVw
{
  [ComVisible(false)]
  [ComEventInterface(typeof (DShellNameSpaceEvents), typeof (DShellNameSpaceEvents_EventProvider))]
  [TypeLibType(16)]
  public interface DShellNameSpaceEvents_Event
  {
    event DShellNameSpaceEvents_FavoritesSelectionChangeEventHandler FavoritesSelectionChange;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_FavoritesSelectionChange(
      [In] DShellNameSpaceEvents_FavoritesSelectionChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_FavoritesSelectionChange(
      [In] DShellNameSpaceEvents_FavoritesSelectionChangeEventHandler obj0);

    event DShellNameSpaceEvents_SelectionChangeEventHandler SelectionChange;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_SelectionChange(
      [In] DShellNameSpaceEvents_SelectionChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_SelectionChange(
      [In] DShellNameSpaceEvents_SelectionChangeEventHandler obj0);

    event DShellNameSpaceEvents_DoubleClickEventHandler DoubleClick;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_DoubleClick([In] DShellNameSpaceEvents_DoubleClickEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_DoubleClick([In] DShellNameSpaceEvents_DoubleClickEventHandler obj0);

    event DShellNameSpaceEvents_InitializedEventHandler Initialized;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_Initialized([In] DShellNameSpaceEvents_InitializedEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_Initialized([In] DShellNameSpaceEvents_InitializedEventHandler obj0);
  }
}
