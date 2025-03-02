// Decompiled with JetBrains decompiler
// Type: SHDocVw.IShellUIHelper3
// Assembly: ReBot, Version=3.9.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 147AC50F-40E8-4B39-8462-ADDDE720DD9F
// Assembly location: C:\Users\pcfor\Downloads\ReBot.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace SHDocVw
{
  [TypeLibType(4160)]
  [Guid("528DF2EC-D419-40BC-9B6D-DCDBF9C1B25D")]
  [ComImport]
  public interface IShellUIHelper3 : IShellUIHelper2
  {
    [DispId(1)]
    [TypeLibFunc(64)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void ResetFirstBootMode();

    [TypeLibFunc(64)]
    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void ResetSafeMode();

    [DispId(3)]
    [TypeLibFunc(64)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void RefreshOfflineDesktop();

    [DispId(4)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void AddFavorite([MarshalAs(UnmanagedType.BStr), In] string URL, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Title);

    [DispId(5)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void AddChannel([MarshalAs(UnmanagedType.BStr), In] string URL);

    [DispId(6)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void AddDesktopComponent(
      [MarshalAs(UnmanagedType.BStr), In] string URL,
      [MarshalAs(UnmanagedType.BStr), In] string Type,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Left,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Top,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Width,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Height);

    [DispId(7)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new bool IsSubscribed([MarshalAs(UnmanagedType.BStr), In] string URL);

    [DispId(8)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void NavigateAndFind([MarshalAs(UnmanagedType.BStr), In] string URL, [MarshalAs(UnmanagedType.BStr), In] string strQuery, [MarshalAs(UnmanagedType.Struct), In] ref object varTargetFrame);

    [DispId(9)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void ImportExportFavorites([In] bool fImport, [MarshalAs(UnmanagedType.BStr), In] string strImpExpPath);

    [DispId(10)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void AutoCompleteSaveForm([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Form);

    [DispId(11)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void AutoScan([MarshalAs(UnmanagedType.BStr), In] string strSearch, [MarshalAs(UnmanagedType.BStr), In] string strFailureUrl, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object pvarTargetFrame);

    [TypeLibFunc(64)]
    [DispId(12)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void AutoCompleteAttach([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Reserved);

    [DispId(13)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Struct)]
    new object ShowBrowserUI([MarshalAs(UnmanagedType.BStr), In] string bstrName, [MarshalAs(UnmanagedType.Struct), In] ref object pvarIn);

    [DispId(14)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void AddSearchProvider([MarshalAs(UnmanagedType.BStr), In] string URL);

    [DispId(15)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void RunOnceShown();

    [DispId(16)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void SkipRunOnce();

    [DispId(17)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void CustomizeSettings([In] bool fSQM, [In] bool fPhishing, [MarshalAs(UnmanagedType.BStr), In] string bstrLocale);

    [DispId(18)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new bool SqmEnabled();

    [DispId(19)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new bool PhishingEnabled();

    [DispId(20)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    new string BrandImageUri();

    [DispId(21)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void SkipTabsWelcome();

    [DispId(22)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void DiagnoseConnection();

    [DispId(23)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void CustomizeClearType([In] bool fSet);

    [DispId(24)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new uint IsSearchProviderInstalled([MarshalAs(UnmanagedType.BStr), In] string URL);

    [DispId(25)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new bool IsSearchMigrated();

    [DispId(26)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    new string DefaultSearchProvider();

    [DispId(27)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void RunOnceRequiredSettingsComplete([In] bool fComplete);

    [DispId(28)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new bool RunOnceHasShown();

    [DispId(29)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    new string SearchGuideUrl();

    [DispId(30)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AddService([MarshalAs(UnmanagedType.BStr), In] string URL);

    [DispId(31)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    uint IsServiceInstalled([MarshalAs(UnmanagedType.BStr), In] string URL, [MarshalAs(UnmanagedType.BStr), In] string Verb);

    [DispId(37)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    bool InPrivateFilteringEnabled();

    [DispId(32)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AddToFavoritesBar([MarshalAs(UnmanagedType.BStr), In] string URL, [MarshalAs(UnmanagedType.BStr), In] string Title, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Type);

    [DispId(33)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void BuildNewTabPage();

    [DispId(34)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SetRecentlyClosedVisible([In] bool fVisible);

    [DispId(35)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SetActivitiesVisible([In] bool fVisible);

    [DispId(36)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ContentDiscoveryReset();

    [DispId(38)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    bool IsSuggestedSitesEnabled();

    [DispId(39)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void EnableSuggestedSites([In] bool fEnable);

    [DispId(40)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void NavigateToSuggestedSites([MarshalAs(UnmanagedType.BStr), In] string bstrRelativeUrl);

    [DispId(41)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ShowTabsHelp();

    [DispId(42)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ShowInPrivateHelp();
  }
}
