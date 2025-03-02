// Decompiled with JetBrains decompiler
// Type: SHDocVw.InternetExplorer
// Assembly: ReBot, Version=3.9.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 147AC50F-40E8-4B39-8462-ADDDE720DD9F
// Assembly location: C:\Users\pcfor\Downloads\ReBot.exe

using System.Runtime.InteropServices;

#nullable disable
namespace SHDocVw
{
  [CoClass(typeof (InternetExplorerClass))]
  [Guid("D30C1661-CDAF-11D0-8A3E-00C04FC9E26E")]
  [ComImport]
  public interface InternetExplorer : IWebBrowser2, DWebBrowserEvents2_Event
  {
  }
}
