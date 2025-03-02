// Decompiled with JetBrains decompiler
// Type: SHDocVw.DShellWindowsEvents_Event
// Assembly: ReBot, Version=3.9.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 147AC50F-40E8-4B39-8462-ADDDE720DD9F
// Assembly location: C:\Users\pcfor\Downloads\ReBot.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace SHDocVw
{
  [ComEventInterface(typeof (DShellWindowsEvents), typeof (DShellWindowsEvents_EventProvider))]
  [TypeLibType(16)]
  [ComVisible(false)]
  public interface DShellWindowsEvents_Event
  {
    event DShellWindowsEvents_WindowRegisteredEventHandler WindowRegistered;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_WindowRegistered(
      [In] DShellWindowsEvents_WindowRegisteredEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_WindowRegistered(
      [In] DShellWindowsEvents_WindowRegisteredEventHandler obj0);

    event DShellWindowsEvents_WindowRevokedEventHandler WindowRevoked;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_WindowRevoked([In] DShellWindowsEvents_WindowRevokedEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_WindowRevoked([In] DShellWindowsEvents_WindowRevokedEventHandler obj0);
  }
}
