// Decompiled with JetBrains decompiler
// Type: SHDocVw.ShellWindows
// Assembly: ReBot, Version=3.9.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 147AC50F-40E8-4B39-8462-ADDDE720DD9F
// Assembly location: C:\Users\pcfor\Downloads\ReBot.exe

using System.Runtime.InteropServices;

#nullable disable
namespace SHDocVw
{
  [CoClass(typeof (ShellWindowsClass))]
  [Guid("85CB6900-4D95-11CF-960C-0080C7F4EE85")]
  [ComImport]
  public interface ShellWindows : IShellWindows, DShellWindowsEvents_Event
  {
  }
}
