// Decompiled with JetBrains decompiler
// Type: SHDocVw.InternetExplorerClass
// Assembly: ReBot, Version=3.9.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 147AC50F-40E8-4B39-8462-ADDDE720DD9F
// Assembly location: C:\Users\pcfor\Downloads\ReBot.exe

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace SHDocVw
{
  [ClassInterface(0)]
  [Guid("0002DF01-0000-0000-C000-000000000046")]
  [DefaultMember("Name")]
  [ComSourceInterfaces("SHDocVw.DWebBrowserEvents2\0SHDocVw.DWebBrowserEvents\0\0")]
  [TypeLibType(2)]
  [ComImport]
  public class InternetExplorerClass : 
    IWebBrowser2,
    InternetExplorer,
    DWebBrowserEvents2_Event,
    IWebBrowserApp,
    DWebBrowserEvents_Event
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern InternetExplorerClass();

    [DispId(100)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void GoBack();

    [DispId(101)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void GoForward();

    [DispId(102)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void GoHome();

    [DispId(103)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void GoSearch();

    [DispId(104)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void Navigate(
      [MarshalAs(UnmanagedType.BStr), In] string URL,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Flags,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object TargetFrameName,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PostData,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Headers);

    [DispId(-550)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void Refresh();

    [DispId(105)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void Refresh2([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Level);

    [DispId(106)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void Stop();

    [DispId(200)]
    public virtual extern object Application { [DispId(200), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

    [DispId(201)]
    public virtual extern object Parent { [DispId(201), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

    [DispId(202)]
    public virtual extern object Container { [DispId(202), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

    [DispId(203)]
    public virtual extern object Document { [DispId(203), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

    [DispId(204)]
    public virtual extern bool TopLevelContainer { [DispId(204), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(205)]
    public virtual extern string Type { [DispId(205), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

    [DispId(206)]
    public virtual extern int Left { [DispId(206), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(206), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(207)]
    public virtual extern int Top { [DispId(207), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(207), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(208)]
    public virtual extern int Width { [DispId(208), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(208), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(209)]
    public virtual extern int Height { [DispId(209), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(209), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(210)]
    public virtual extern string LocationName { [DispId(210), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

    [DispId(211)]
    public virtual extern string LocationURL { [DispId(211), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

    [DispId(212)]
    public virtual extern bool Busy { [DispId(212), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(300)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void Quit();

    [DispId(301)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ClientToWindow([In, Out] ref int pcx, [In, Out] ref int pcy);

    [DispId(302)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void PutProperty([MarshalAs(UnmanagedType.BStr), In] string Property, [MarshalAs(UnmanagedType.Struct), In] object vtValue);

    [DispId(303)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Struct)]
    public virtual extern object GetProperty([MarshalAs(UnmanagedType.BStr), In] string Property);

    [DispId(0)]
    public virtual extern string Name { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

    [DispId(-515)]
    public virtual extern int HWND { [DispId(-515), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(400)]
    public virtual extern string FullName { [DispId(400), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

    [DispId(401)]
    public virtual extern string Path { [DispId(401), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

    [DispId(402)]
    public virtual extern bool Visible { [DispId(402), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(402), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(403)]
    public virtual extern bool StatusBar { [DispId(403), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(403), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(404)]
    public virtual extern string StatusText { [DispId(404), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(404), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

    [DispId(405)]
    public virtual extern int ToolBar { [DispId(405), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(405), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(406)]
    public virtual extern bool MenuBar { [DispId(406), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(406), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(407)]
    public virtual extern bool FullScreen { [DispId(407), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(407), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(500)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void Navigate2(
      [MarshalAs(UnmanagedType.Struct), In] ref object URL,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Flags,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object TargetFrameName,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PostData,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Headers);

    [DispId(501)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern OLECMDF QueryStatusWB([In] OLECMDID cmdID);

    [DispId(502)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ExecWB(
      [In] OLECMDID cmdID,
      [In] OLECMDEXECOPT cmdexecopt,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object pvaIn,
      [MarshalAs(UnmanagedType.Struct), In, Out, Optional] ref object pvaOut);

    [DispId(503)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ShowBrowserBar(
      [MarshalAs(UnmanagedType.Struct), In] ref object pvaClsid,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object pvarShow,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object pvarSize);

    [DispId(-525)]
    public virtual extern tagREADYSTATE ReadyState { [TypeLibFunc(4), DispId(-525), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(550)]
    public virtual extern bool Offline { [DispId(550), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(550), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(551)]
    public virtual extern bool Silent { [DispId(551), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(551), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(552)]
    public virtual extern bool RegisterAsBrowser { [DispId(552), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(552), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(553)]
    public virtual extern bool RegisterAsDropTarget { [DispId(553), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(553), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(554)]
    public virtual extern bool TheaterMode { [DispId(554), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(554), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(555)]
    public virtual extern bool AddressBar { [DispId(555), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(555), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(556)]
    public virtual extern bool Resizable { [DispId(556), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(556), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IWebBrowserApp_GoBack();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IWebBrowserApp_GoForward();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IWebBrowserApp_GoHome();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IWebBrowserApp_GoSearch();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IWebBrowserApp_Navigate(
      [MarshalAs(UnmanagedType.BStr), In] string URL,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Flags,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object TargetFrameName,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PostData,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Headers);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IWebBrowserApp_Refresh();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IWebBrowserApp_Refresh2([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Level);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IWebBrowserApp_Stop();

    public virtual extern object IWebBrowserApp_Application { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

    public virtual extern object IWebBrowserApp_Parent { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

    public virtual extern object IWebBrowserApp_Container { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

    public virtual extern object IWebBrowserApp_Document { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

    public virtual extern bool IWebBrowserApp_TopLevelContainer { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    public virtual extern string IWebBrowserApp_Type { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

    public virtual extern int IWebBrowserApp_Left { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    public virtual extern int IWebBrowserApp_Top { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    public virtual extern int IWebBrowserApp_Width { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    public virtual extern int IWebBrowserApp_Height { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    public virtual extern string IWebBrowserApp_LocationName { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

    public virtual extern string IWebBrowserApp_LocationURL { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

    public virtual extern bool IWebBrowserApp_Busy { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IWebBrowserApp_Quit();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IWebBrowserApp_ClientToWindow([In, Out] ref int pcx, [In, Out] ref int pcy);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void IWebBrowserApp_PutProperty([MarshalAs(UnmanagedType.BStr), In] string Property, [MarshalAs(UnmanagedType.Struct), In] object vtValue);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Struct)]
    public virtual extern object IWebBrowserApp_GetProperty([MarshalAs(UnmanagedType.BStr), In] string Property);

    public virtual extern string IWebBrowserApp_Name { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

    public virtual extern int IWebBrowserApp_HWND { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    public virtual extern string IWebBrowserApp_FullName { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

    public virtual extern string IWebBrowserApp_Path { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

    public virtual extern bool IWebBrowserApp_Visible { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    public virtual extern bool IWebBrowserApp_StatusBar { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    public virtual extern string IWebBrowserApp_StatusText { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

    public virtual extern int IWebBrowserApp_ToolBar { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    public virtual extern bool IWebBrowserApp_MenuBar { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    public virtual extern bool IWebBrowserApp_FullScreen { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    public virtual extern event DWebBrowserEvents2_StatusTextChangeEventHandler StatusTextChange;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_StatusTextChange(
      [In] DWebBrowserEvents2_StatusTextChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_StatusTextChange(
      [In] DWebBrowserEvents2_StatusTextChangeEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_ProgressChangeEventHandler ProgressChange;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_ProgressChange([In] DWebBrowserEvents2_ProgressChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_ProgressChange(
      [In] DWebBrowserEvents2_ProgressChangeEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_CommandStateChangeEventHandler CommandStateChange;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_CommandStateChange(
      [In] DWebBrowserEvents2_CommandStateChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_CommandStateChange(
      [In] DWebBrowserEvents2_CommandStateChangeEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_DownloadBeginEventHandler DownloadBegin;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_DownloadBegin([In] DWebBrowserEvents2_DownloadBeginEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_DownloadBegin(
      [In] DWebBrowserEvents2_DownloadBeginEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_DownloadCompleteEventHandler DownloadComplete;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_DownloadComplete(
      [In] DWebBrowserEvents2_DownloadCompleteEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_DownloadComplete(
      [In] DWebBrowserEvents2_DownloadCompleteEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_TitleChangeEventHandler TitleChange;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_TitleChange([In] DWebBrowserEvents2_TitleChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_TitleChange([In] DWebBrowserEvents2_TitleChangeEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_PropertyChangeEventHandler PropertyChange;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_PropertyChange([In] DWebBrowserEvents2_PropertyChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_PropertyChange(
      [In] DWebBrowserEvents2_PropertyChangeEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_BeforeNavigate2EventHandler BeforeNavigate2;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_BeforeNavigate2(
      [In] DWebBrowserEvents2_BeforeNavigate2EventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_BeforeNavigate2(
      [In] DWebBrowserEvents2_BeforeNavigate2EventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_NewWindow2([In] DWebBrowserEvents2_NewWindow2EventHandler obj0);

    public virtual extern event DWebBrowserEvents2_NewWindow2EventHandler NewWindow2;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_NewWindow2([In] DWebBrowserEvents2_NewWindow2EventHandler obj0);

    public virtual extern event DWebBrowserEvents2_NavigateComplete2EventHandler NavigateComplete2;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_NavigateComplete2(
      [In] DWebBrowserEvents2_NavigateComplete2EventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_NavigateComplete2(
      [In] DWebBrowserEvents2_NavigateComplete2EventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_DocumentComplete(
      [In] DWebBrowserEvents2_DocumentCompleteEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_DocumentCompleteEventHandler DocumentComplete;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_DocumentComplete(
      [In] DWebBrowserEvents2_DocumentCompleteEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_OnQuitEventHandler OnQuit;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_OnQuit([In] DWebBrowserEvents2_OnQuitEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_OnQuit([In] DWebBrowserEvents2_OnQuitEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_OnVisibleEventHandler OnVisible;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_OnVisible([In] DWebBrowserEvents2_OnVisibleEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_OnVisible([In] DWebBrowserEvents2_OnVisibleEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_OnToolBarEventHandler OnToolBar;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_OnToolBar([In] DWebBrowserEvents2_OnToolBarEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_OnToolBar([In] DWebBrowserEvents2_OnToolBarEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_OnMenuBar([In] DWebBrowserEvents2_OnMenuBarEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_OnMenuBarEventHandler OnMenuBar;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_OnMenuBar([In] DWebBrowserEvents2_OnMenuBarEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_OnStatusBar([In] DWebBrowserEvents2_OnStatusBarEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_OnStatusBarEventHandler OnStatusBar;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_OnStatusBar([In] DWebBrowserEvents2_OnStatusBarEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_OnFullScreen([In] DWebBrowserEvents2_OnFullScreenEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_OnFullScreenEventHandler OnFullScreen;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_OnFullScreen([In] DWebBrowserEvents2_OnFullScreenEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_OnTheaterModeEventHandler OnTheaterMode;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_OnTheaterMode([In] DWebBrowserEvents2_OnTheaterModeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_OnTheaterMode(
      [In] DWebBrowserEvents2_OnTheaterModeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_WindowSetResizable(
      [In] DWebBrowserEvents2_WindowSetResizableEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_WindowSetResizableEventHandler WindowSetResizable;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_WindowSetResizable(
      [In] DWebBrowserEvents2_WindowSetResizableEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_WindowSetLeftEventHandler WindowSetLeft;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_WindowSetLeft([In] DWebBrowserEvents2_WindowSetLeftEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_WindowSetLeft(
      [In] DWebBrowserEvents2_WindowSetLeftEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_WindowSetTopEventHandler WindowSetTop;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_WindowSetTop([In] DWebBrowserEvents2_WindowSetTopEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_WindowSetTop([In] DWebBrowserEvents2_WindowSetTopEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_WindowSetWidthEventHandler WindowSetWidth;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_WindowSetWidth([In] DWebBrowserEvents2_WindowSetWidthEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_WindowSetWidth(
      [In] DWebBrowserEvents2_WindowSetWidthEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_WindowSetHeightEventHandler WindowSetHeight;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_WindowSetHeight(
      [In] DWebBrowserEvents2_WindowSetHeightEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_WindowSetHeight(
      [In] DWebBrowserEvents2_WindowSetHeightEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_WindowClosingEventHandler WindowClosing;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_WindowClosing([In] DWebBrowserEvents2_WindowClosingEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_WindowClosing(
      [In] DWebBrowserEvents2_WindowClosingEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_ClientToHostWindowEventHandler ClientToHostWindow;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_ClientToHostWindow(
      [In] DWebBrowserEvents2_ClientToHostWindowEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_ClientToHostWindow(
      [In] DWebBrowserEvents2_ClientToHostWindowEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_SetSecureLockIcon(
      [In] DWebBrowserEvents2_SetSecureLockIconEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_SetSecureLockIconEventHandler SetSecureLockIcon;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_SetSecureLockIcon(
      [In] DWebBrowserEvents2_SetSecureLockIconEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_FileDownloadEventHandler FileDownload;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_FileDownload([In] DWebBrowserEvents2_FileDownloadEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_FileDownload([In] DWebBrowserEvents2_FileDownloadEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_NavigateErrorEventHandler NavigateError;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_NavigateError([In] DWebBrowserEvents2_NavigateErrorEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_NavigateError(
      [In] DWebBrowserEvents2_NavigateErrorEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_PrintTemplateInstantiationEventHandler PrintTemplateInstantiation;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_PrintTemplateInstantiation(
      [In] DWebBrowserEvents2_PrintTemplateInstantiationEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_PrintTemplateInstantiation(
      [In] DWebBrowserEvents2_PrintTemplateInstantiationEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_PrintTemplateTeardown(
      [In] DWebBrowserEvents2_PrintTemplateTeardownEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_PrintTemplateTeardownEventHandler PrintTemplateTeardown;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_PrintTemplateTeardown(
      [In] DWebBrowserEvents2_PrintTemplateTeardownEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_UpdatePageStatus(
      [In] DWebBrowserEvents2_UpdatePageStatusEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_UpdatePageStatusEventHandler UpdatePageStatus;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_UpdatePageStatus(
      [In] DWebBrowserEvents2_UpdatePageStatusEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_PrivacyImpactedStateChange(
      [In] DWebBrowserEvents2_PrivacyImpactedStateChangeEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_PrivacyImpactedStateChangeEventHandler PrivacyImpactedStateChange;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_PrivacyImpactedStateChange(
      [In] DWebBrowserEvents2_PrivacyImpactedStateChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_NewWindow3([In] DWebBrowserEvents2_NewWindow3EventHandler obj0);

    public virtual extern event DWebBrowserEvents2_NewWindow3EventHandler NewWindow3;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_NewWindow3([In] DWebBrowserEvents2_NewWindow3EventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_SetPhishingFilterStatus(
      [In] DWebBrowserEvents2_SetPhishingFilterStatusEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_SetPhishingFilterStatusEventHandler SetPhishingFilterStatus;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_SetPhishingFilterStatus(
      [In] DWebBrowserEvents2_SetPhishingFilterStatusEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_WindowStateChanged(
      [In] DWebBrowserEvents2_WindowStateChangedEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_WindowStateChangedEventHandler WindowStateChanged;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_WindowStateChanged(
      [In] DWebBrowserEvents2_WindowStateChangedEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_NewProcess([In] DWebBrowserEvents2_NewProcessEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_NewProcessEventHandler NewProcess;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_NewProcess([In] DWebBrowserEvents2_NewProcessEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_ThirdPartyUrlBlockedEventHandler ThirdPartyUrlBlocked;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_ThirdPartyUrlBlocked(
      [In] DWebBrowserEvents2_ThirdPartyUrlBlockedEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_ThirdPartyUrlBlocked(
      [In] DWebBrowserEvents2_ThirdPartyUrlBlockedEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_RedirectXDomainBlockedEventHandler RedirectXDomainBlocked;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_RedirectXDomainBlocked(
      [In] DWebBrowserEvents2_RedirectXDomainBlockedEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_RedirectXDomainBlocked(
      [In] DWebBrowserEvents2_RedirectXDomainBlockedEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_BeforeScriptExecute(
      [In] DWebBrowserEvents2_BeforeScriptExecuteEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_BeforeScriptExecuteEventHandler BeforeScriptExecute;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_BeforeScriptExecute(
      [In] DWebBrowserEvents2_BeforeScriptExecuteEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_WebWorkerStarted(
      [In] DWebBrowserEvents2_WebWorkerStartedEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_WebWorkerStartedEventHandler WebWorkerStarted;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_WebWorkerStarted(
      [In] DWebBrowserEvents2_WebWorkerStartedEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_WebWorkerFinsihed(
      [In] DWebBrowserEvents2_WebWorkerFinsihedEventHandler obj0);

    public virtual extern event DWebBrowserEvents2_WebWorkerFinsihedEventHandler WebWorkerFinsihed;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_WebWorkerFinsihed(
      [In] DWebBrowserEvents2_WebWorkerFinsihedEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_BeforeNavigate([In] DWebBrowserEvents_BeforeNavigateEventHandler obj0);

    public virtual extern event DWebBrowserEvents_BeforeNavigateEventHandler BeforeNavigate;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_BeforeNavigate(
      [In] DWebBrowserEvents_BeforeNavigateEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_NavigateComplete(
      [In] DWebBrowserEvents_NavigateCompleteEventHandler obj0);

    public virtual extern event DWebBrowserEvents_NavigateCompleteEventHandler NavigateComplete;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_NavigateComplete(
      [In] DWebBrowserEvents_NavigateCompleteEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DWebBrowserEvents_Event_add_StatusTextChange(
      [In] DWebBrowserEvents_StatusTextChangeEventHandler obj0);

    public virtual extern event DWebBrowserEvents_StatusTextChangeEventHandler DWebBrowserEvents_Event_StatusTextChange;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DWebBrowserEvents_Event_remove_StatusTextChange(
      [In] DWebBrowserEvents_StatusTextChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DWebBrowserEvents_Event_add_ProgressChange(
      [In] DWebBrowserEvents_ProgressChangeEventHandler obj0);

    public virtual extern event DWebBrowserEvents_ProgressChangeEventHandler DWebBrowserEvents_Event_ProgressChange;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DWebBrowserEvents_Event_remove_ProgressChange(
      [In] DWebBrowserEvents_ProgressChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DWebBrowserEvents_Event_add_DownloadComplete(
      [In] DWebBrowserEvents_DownloadCompleteEventHandler obj0);

    public virtual extern event DWebBrowserEvents_DownloadCompleteEventHandler DWebBrowserEvents_Event_DownloadComplete;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DWebBrowserEvents_Event_remove_DownloadComplete(
      [In] DWebBrowserEvents_DownloadCompleteEventHandler obj0);

    public virtual extern event DWebBrowserEvents_CommandStateChangeEventHandler DWebBrowserEvents_Event_CommandStateChange;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DWebBrowserEvents_Event_add_CommandStateChange(
      [In] DWebBrowserEvents_CommandStateChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DWebBrowserEvents_Event_remove_CommandStateChange(
      [In] DWebBrowserEvents_CommandStateChangeEventHandler obj0);

    public virtual extern event DWebBrowserEvents_DownloadBeginEventHandler DWebBrowserEvents_Event_DownloadBegin;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DWebBrowserEvents_Event_add_DownloadBegin(
      [In] DWebBrowserEvents_DownloadBeginEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DWebBrowserEvents_Event_remove_DownloadBegin(
      [In] DWebBrowserEvents_DownloadBeginEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_NewWindow([In] DWebBrowserEvents_NewWindowEventHandler obj0);

    public virtual extern event DWebBrowserEvents_NewWindowEventHandler NewWindow;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_NewWindow([In] DWebBrowserEvents_NewWindowEventHandler obj0);

    public virtual extern event DWebBrowserEvents_TitleChangeEventHandler DWebBrowserEvents_Event_TitleChange;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DWebBrowserEvents_Event_add_TitleChange(
      [In] DWebBrowserEvents_TitleChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DWebBrowserEvents_Event_remove_TitleChange(
      [In] DWebBrowserEvents_TitleChangeEventHandler obj0);

    public virtual extern event DWebBrowserEvents_FrameBeforeNavigateEventHandler FrameBeforeNavigate;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_FrameBeforeNavigate(
      [In] DWebBrowserEvents_FrameBeforeNavigateEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_FrameBeforeNavigate(
      [In] DWebBrowserEvents_FrameBeforeNavigateEventHandler obj0);

    public virtual extern event DWebBrowserEvents_FrameNavigateCompleteEventHandler FrameNavigateComplete;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_FrameNavigateComplete(
      [In] DWebBrowserEvents_FrameNavigateCompleteEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_FrameNavigateComplete(
      [In] DWebBrowserEvents_FrameNavigateCompleteEventHandler obj0);

    public virtual extern event DWebBrowserEvents_FrameNewWindowEventHandler FrameNewWindow;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_FrameNewWindow([In] DWebBrowserEvents_FrameNewWindowEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_FrameNewWindow(
      [In] DWebBrowserEvents_FrameNewWindowEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_Quit([In] DWebBrowserEvents_QuitEventHandler obj0);

    public virtual extern event DWebBrowserEvents_QuitEventHandler DWebBrowserEvents_Event_Quit;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_Quit([In] DWebBrowserEvents_QuitEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_WindowMove([In] DWebBrowserEvents_WindowMoveEventHandler obj0);

    public virtual extern event DWebBrowserEvents_WindowMoveEventHandler WindowMove;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_WindowMove([In] DWebBrowserEvents_WindowMoveEventHandler obj0);

    public virtual extern event DWebBrowserEvents_WindowResizeEventHandler WindowResize;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_WindowResize([In] DWebBrowserEvents_WindowResizeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_WindowResize([In] DWebBrowserEvents_WindowResizeEventHandler obj0);

    public virtual extern event DWebBrowserEvents_WindowActivateEventHandler WindowActivate;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void add_WindowActivate([In] DWebBrowserEvents_WindowActivateEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void remove_WindowActivate(
      [In] DWebBrowserEvents_WindowActivateEventHandler obj0);

    public virtual extern event DWebBrowserEvents_PropertyChangeEventHandler DWebBrowserEvents_Event_PropertyChange;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DWebBrowserEvents_Event_add_PropertyChange(
      [In] DWebBrowserEvents_PropertyChangeEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DWebBrowserEvents_Event_remove_PropertyChange(
      [In] DWebBrowserEvents_PropertyChangeEventHandler obj0);
  }
}
