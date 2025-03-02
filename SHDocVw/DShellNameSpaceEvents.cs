// Decompiled with JetBrains decompiler
// Type: SHDocVw.DShellNameSpaceEvents
// Assembly: ReBot, Version=3.9.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 147AC50F-40E8-4B39-8462-ADDDE720DD9F
// Assembly location: C:\Users\pcfor\Downloads\ReBot.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace SHDocVw
{
  [Guid("55136806-B2DE-11D1-B9F2-00A0C98BC547")]
  [TypeLibType(4096)]
  [InterfaceType(2)]
  [ComImport]
  public interface DShellNameSpaceEvents
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void FavoritesSelectionChange(
      [In] int cItems,
      [In] int hItem,
      [MarshalAs(UnmanagedType.BStr), In] string strName,
      [MarshalAs(UnmanagedType.BStr), In] string strUrl,
      [In] int cVisits,
      [MarshalAs(UnmanagedType.BStr), In] string strDate,
      [In] int fAvailableOffline);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SelectionChange();

    [DispId(3)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DoubleClick();

    [DispId(4)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Initialized();
  }
}
