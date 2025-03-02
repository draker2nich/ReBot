// Decompiled with JetBrains decompiler
// Type: SHDocVw.DShellWindowsEvents_SinkHelper
// Assembly: ReBot, Version=3.9.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 147AC50F-40E8-4B39-8462-ADDDE720DD9F
// Assembly location: C:\Users\pcfor\Downloads\ReBot.exe

using System.Runtime.InteropServices;

#nullable disable
namespace SHDocVw
{
  [TypeLibType(TypeLibTypeFlags.FHidden)]
  [ClassInterface(ClassInterfaceType.None)]
  public sealed class DShellWindowsEvents_SinkHelper : DShellWindowsEvents
  {
    public DShellWindowsEvents_WindowRegisteredEventHandler m_WindowRegisteredDelegate;
    public DShellWindowsEvents_WindowRevokedEventHandler m_WindowRevokedDelegate;
    public int m_dwCookie;

    public virtual void WindowRegistered([In] int obj0)
    {
      if (this.m_WindowRegisteredDelegate == null)
        return;
      this.m_WindowRegisteredDelegate(obj0);
    }

    public virtual void WindowRevoked([In] int obj0)
    {
      if (this.m_WindowRevokedDelegate == null)
        return;
      this.m_WindowRevokedDelegate(obj0);
    }

    internal DShellWindowsEvents_SinkHelper()
    {
      this.m_dwCookie = 0;
      this.m_WindowRegisteredDelegate = (DShellWindowsEvents_WindowRegisteredEventHandler) null;
      this.m_WindowRevokedDelegate = (DShellWindowsEvents_WindowRevokedEventHandler) null;
    }
  }
}
