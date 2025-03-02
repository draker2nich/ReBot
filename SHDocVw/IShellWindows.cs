// Decompiled with JetBrains decompiler
// Type: SHDocVw.IShellWindows
// Assembly: ReBot, Version=3.9.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 147AC50F-40E8-4B39-8462-ADDDE720DD9F
// Assembly location: C:\Users\pcfor\Downloads\ReBot.exe

using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace SHDocVw
{
  [TypeLibType(4160)]
  [Guid("85CB6900-4D95-11CF-960C-0080C7F4EE85")]
  [DefaultMember("Item")]
  [ComImport]
  public interface IShellWindows : IEnumerable
  {
    [DispId(1610743808)]
    int Count { [DispId(1610743808), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(0)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    object Item([MarshalAs(UnmanagedType.Struct), In, Optional] object index);

    [DispId(-4)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
    new IEnumerator GetEnumerator();

    [TypeLibFunc(64)]
    [DispId(1610743811)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Register([MarshalAs(UnmanagedType.IDispatch), In] object pid, [In] int HWND, [In] int swClass, out int plCookie);

    [DispId(1610743812)]
    [TypeLibFunc(64)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RegisterPending(
      [In] int lThreadId,
      [MarshalAs(UnmanagedType.Struct), In] ref object pvarloc,
      [MarshalAs(UnmanagedType.Struct), In] ref object pvarlocRoot,
      [In] int swClass,
      out int plCookie);

    [DispId(1610743813)]
    [TypeLibFunc(64)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Revoke([In] int lCookie);

    [DispId(1610743814)]
    [TypeLibFunc(64)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnNavigate([In] int lCookie, [MarshalAs(UnmanagedType.Struct), In] ref object pvarloc);

    [TypeLibFunc(64)]
    [DispId(1610743815)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnActivated([In] int lCookie, [In] bool fActive);

    [TypeLibFunc(64)]
    [DispId(1610743816)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    object FindWindowSW(
      [MarshalAs(UnmanagedType.Struct), In] ref object pvarloc,
      [MarshalAs(UnmanagedType.Struct), In] ref object pvarlocRoot,
      [In] int swClass,
      out int pHWND,
      [In] int swfwOptions);

    [DispId(1610743817)]
    [TypeLibFunc(64)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnCreated([In] int lCookie, [MarshalAs(UnmanagedType.IUnknown), In] object punk);

    [DispId(1610743818)]
    [TypeLibFunc(64)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ProcessAttachDetach([In] bool fAttach);
  }
}
