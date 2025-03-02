// Decompiled with JetBrains decompiler
// Type: SHDocVw.IShellUIHelper
// Assembly: ReBot, Version=3.9.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 147AC50F-40E8-4B39-8462-ADDDE720DD9F
// Assembly location: C:\Users\pcfor\Downloads\ReBot.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace SHDocVw
{
  [Guid("729FE2F8-1EA8-11D1-8F85-00C04FC2FBE1")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IShellUIHelper
  {
    [TypeLibFunc(64)]
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ResetFirstBootMode();

    [DispId(2)]
    [TypeLibFunc(64)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ResetSafeMode();

    [TypeLibFunc(64)]
    [DispId(3)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RefreshOfflineDesktop();

    [DispId(4)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AddFavorite([MarshalAs(UnmanagedType.BStr), In] string URL, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Title);

    [DispId(5)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AddChannel([MarshalAs(UnmanagedType.BStr), In] string URL);

    [DispId(6)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AddDesktopComponent(
      [MarshalAs(UnmanagedType.BStr), In] string URL,
      [MarshalAs(UnmanagedType.BStr), In] string Type,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Left,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Top,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Width,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Height);

    [DispId(7)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    bool IsSubscribed([MarshalAs(UnmanagedType.BStr), In] string URL);

    [DispId(8)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void NavigateAndFind([MarshalAs(UnmanagedType.BStr), In] string URL, [MarshalAs(UnmanagedType.BStr), In] string strQuery, [MarshalAs(UnmanagedType.Struct), In] ref object varTargetFrame);

    [DispId(9)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ImportExportFavorites([In] bool fImport, [MarshalAs(UnmanagedType.BStr), In] string strImpExpPath);

    [DispId(10)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AutoCompleteSaveForm([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Form);

    [DispId(11)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AutoScan([MarshalAs(UnmanagedType.BStr), In] string strSearch, [MarshalAs(UnmanagedType.BStr), In] string strFailureUrl, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object pvarTargetFrame);

    [TypeLibFunc(64)]
    [DispId(12)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AutoCompleteAttach([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Reserved);

    [DispId(13)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Struct)]
    object ShowBrowserUI([MarshalAs(UnmanagedType.BStr), In] string bstrName, [MarshalAs(UnmanagedType.Struct), In] ref object pvarIn);
  }
}
