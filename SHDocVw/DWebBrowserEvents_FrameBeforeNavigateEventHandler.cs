﻿// Decompiled with JetBrains decompiler
// Type: SHDocVw.DWebBrowserEvents_FrameBeforeNavigateEventHandler
// Assembly: ReBot, Version=3.9.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 147AC50F-40E8-4B39-8462-ADDDE720DD9F
// Assembly location: C:\Users\pcfor\Downloads\ReBot.exe

using System.Runtime.InteropServices;

#nullable disable
namespace SHDocVw
{
  [ComVisible(false)]
  [TypeLibType(16)]
  public delegate void DWebBrowserEvents_FrameBeforeNavigateEventHandler(
    [MarshalAs(UnmanagedType.BStr), In] string URL,
    int Flags,
    [MarshalAs(UnmanagedType.BStr)] string TargetFrameName,
    [MarshalAs(UnmanagedType.Struct)] ref object PostData,
    [MarshalAs(UnmanagedType.BStr)] string Headers,
    [In, Out] ref bool Cancel);
}
