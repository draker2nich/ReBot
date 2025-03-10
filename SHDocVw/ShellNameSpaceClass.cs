﻿// Decompiled with JetBrains decompiler
// Type: SHDocVw.ShellNameSpaceClass
// Assembly: ReBot, Version=3.9.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 147AC50F-40E8-4B39-8462-ADDDE720DD9F
// Assembly location: C:\Users\pcfor\Downloads\ReBot.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace SHDocVw
{
  [ClassInterface(0)]
  [ComSourceInterfaces("SHDocVw.DShellNameSpaceEvents\0\0")]
  [TypeLibType(2)]
  [Guid("55136805-B2DE-11D1-B9F2-00A0C98BC547")]
  [ComImport]
  public class ShellNameSpaceClass : IShellNameSpace, ShellNameSpace, DShellNameSpaceEvents_Event
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern ShellNameSpaceClass();

    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void MoveSelectionUp();

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void MoveSelectionDown();

    [DispId(3)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ResetSort();

    [DispId(4)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void NewFolder();

    [DispId(5)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void Synchronize();

    [DispId(6)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void Import();

    [DispId(7)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void Export();

    [DispId(8)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void InvokeContextMenuCommand([MarshalAs(UnmanagedType.BStr), In] string strCommand);

    [DispId(9)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void MoveSelectionTo();

    [DispId(10)]
    public virtual extern bool SubscriptionsEnabled { [DispId(10), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(11)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern bool CreateSubscriptionForSelection();

    [DispId(12)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern bool DeleteSubscriptionForSelection();

    [DispId(13)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SetRoot([MarshalAs(UnmanagedType.BStr), In] string bstrFullPath);

    [DispId(14)]
    public virtual extern int EnumOptions { [DispId(14), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(14), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(15)]
    public virtual extern object SelectedItem { [DispId(15), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; [DispId(15), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.IDispatch), In] set; }

    [DispId(16)]
    public virtual extern object Root { [DispId(16), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(16), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

    [DispId(17)]
    public virtual extern int Depth { [DispId(17), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(17), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(18)]
    public virtual extern uint Mode { [DispId(18), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(18), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(19)]
    public virtual extern uint Flags { [DispId(19), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(19), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(20)]
    public virtual extern uint TVFlags { [DispId(20), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(20), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(21)]
    public virtual extern string Columns { [DispId(21), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(21), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

    [DispId(22)]
    public virtual extern int CountViewTypes { [DispId(22), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(23)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SetViewType([In] int iType);

    [DispId(24)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    public virtual extern object SelectedItems();

    [DispId(25)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void Expand([MarshalAs(UnmanagedType.Struct), In] object var, int iDepth);

    [DispId(26)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void UnselectAll();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_FavoritesSelectionChange(
      [In] DShellNameSpaceEvents_FavoritesSelectionChangeEventHandler obj0);

    public virtual extern event DShellNameSpaceEvents_FavoritesSelectionChangeEventHandler FavoritesSelectionChange;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_FavoritesSelectionChange(
      [In] DShellNameSpaceEvents_FavoritesSelectionChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_SelectionChange(
      [In] DShellNameSpaceEvents_SelectionChangeEventHandler obj0);

    public virtual extern event DShellNameSpaceEvents_SelectionChangeEventHandler SelectionChange;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_SelectionChange(
      [In] DShellNameSpaceEvents_SelectionChangeEventHandler obj0);

    public virtual extern event DShellNameSpaceEvents_DoubleClickEventHandler DoubleClick;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_DoubleClick([In] DShellNameSpaceEvents_DoubleClickEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_DoubleClick([In] DShellNameSpaceEvents_DoubleClickEventHandler obj0);

    public virtual extern event DShellNameSpaceEvents_InitializedEventHandler Initialized;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_Initialized([In] DShellNameSpaceEvents_InitializedEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_Initialized([In] DShellNameSpaceEvents_InitializedEventHandler obj0);
  }
}
