// Decompiled with JetBrains decompiler
// Type: SHDocVw.DShellWindowsEvents
// Assembly: ReBot, Version=3.9.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 147AC50F-40E8-4B39-8462-ADDDE720DD9F
// Assembly location: C:\Users\pcfor\Downloads\ReBot.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace SHDocVw
{
  [Guid("FE4106E0-399A-11D0-A48C-00A0C90A8F39")]
  [TypeLibType(4096)]
  [InterfaceType(2)]
  [ComImport]
  public interface DShellWindowsEvents
  {
    [DispId(200)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void WindowRegistered([In] int lCookie);

    [DispId(201)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void WindowRevoked([In] int lCookie);
  }
}
