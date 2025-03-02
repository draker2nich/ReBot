// Decompiled with JetBrains decompiler
// Type: SHDocVw.ShellWindowsClass
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
  [ComSourceInterfaces("SHDocVw.DShellWindowsEvents\0\0")]
  [Guid("9BA05972-F6A8-11CF-A442-00A0C90A8F39")]
  [ClassInterface(0)]
  [TypeLibType(2)]
  [DefaultMember("Item")]
  [ComImport]
  public class ShellWindowsClass : 
    IShellWindows,
    ShellWindows,
    DShellWindowsEvents_Event,
    IEnumerable
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern ShellWindowsClass();

    [DispId(1610743808)]
    public virtual extern int Count { [DispId(1610743808), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(0)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    public virtual extern object Item([MarshalAs(UnmanagedType.Struct), In, Optional] object index);

    [DispId(-4)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
    public virtual extern IEnumerator GetEnumerator();

    [DispId(1610743811)]
    [TypeLibFunc(64)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void Register([MarshalAs(UnmanagedType.IDispatch), In] object pid, [In] int HWND, [In] int swClass, out int plCookie);

    [TypeLibFunc(64)]
    [DispId(1610743812)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void RegisterPending(
      [In] int lThreadId,
      [MarshalAs(UnmanagedType.Struct), In] ref object pvarloc,
      [MarshalAs(UnmanagedType.Struct), In] ref object pvarlocRoot,
      [In] int swClass,
      out int plCookie);

    [TypeLibFunc(64)]
    [DispId(1610743813)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void Revoke([In] int lCookie);

    [TypeLibFunc(64)]
    [DispId(1610743814)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void OnNavigate([In] int lCookie, [MarshalAs(UnmanagedType.Struct), In] ref object pvarloc);

    [TypeLibFunc(64)]
    [DispId(1610743815)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void OnActivated([In] int lCookie, [In] bool fActive);

    [DispId(1610743816)]
    [TypeLibFunc(64)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IDispatch)]
    public virtual extern object FindWindowSW(
      [MarshalAs(UnmanagedType.Struct), In] ref object pvarloc,
      [MarshalAs(UnmanagedType.Struct), In] ref object pvarlocRoot,
      [In] int swClass,
      out int pHWND,
      [In] int swfwOptions);

    [DispId(1610743817)]
    [TypeLibFunc(64)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void OnCreated([In] int lCookie, [MarshalAs(UnmanagedType.IUnknown), In] object punk);

    [DispId(1610743818)]
    [TypeLibFunc(64)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ProcessAttachDetach([In] bool fAttach);

    public virtual extern event DShellWindowsEvents_WindowRegisteredEventHandler WindowRegistered;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_WindowRegistered(
      [In] DShellWindowsEvents_WindowRegisteredEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_WindowRegistered(
      [In] DShellWindowsEvents_WindowRegisteredEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_WindowRevoked([In] DShellWindowsEvents_WindowRevokedEventHandler obj0);

    public virtual extern event DShellWindowsEvents_WindowRevokedEventHandler WindowRevoked;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_WindowRevoked(
      [In] DShellWindowsEvents_WindowRevokedEventHandler obj0);
  }
}
