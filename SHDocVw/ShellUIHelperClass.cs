// Decompiled with JetBrains decompiler
// Type: SHDocVw.ShellUIHelperClass
// Assembly: ReBot, Version=3.9.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 147AC50F-40E8-4B39-8462-ADDDE720DD9F
// Assembly location: C:\Users\pcfor\Downloads\ReBot.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace SHDocVw
{
  [Guid("64AB4BB7-111E-11D1-8F79-00C04FC2FBE1")]
  [TypeLibType(2)]
  [ClassInterface(0)]
  [ComImport]
  public class ShellUIHelperClass : IShellUIHelper6, ShellUIHelper
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern ShellUIHelperClass();

    [TypeLibFunc(64)]
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ResetFirstBootMode();

    [DispId(2)]
    [TypeLibFunc(64)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ResetSafeMode();

    [DispId(3)]
    [TypeLibFunc(64)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void RefreshOfflineDesktop();

    [DispId(4)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void AddFavorite([MarshalAs(UnmanagedType.BStr), In] string URL, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Title);

    [DispId(5)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void AddChannel([MarshalAs(UnmanagedType.BStr), In] string URL);

    [DispId(6)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void AddDesktopComponent(
      [MarshalAs(UnmanagedType.BStr), In] string URL,
      [MarshalAs(UnmanagedType.BStr), In] string Type,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Left,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Top,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Width,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Height);

    [DispId(7)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern bool IsSubscribed([MarshalAs(UnmanagedType.BStr), In] string URL);

    [DispId(8)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void NavigateAndFind(
      [MarshalAs(UnmanagedType.BStr), In] string URL,
      [MarshalAs(UnmanagedType.BStr), In] string strQuery,
      [MarshalAs(UnmanagedType.Struct), In] ref object varTargetFrame);

    [DispId(9)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ImportExportFavorites([In] bool fImport, [MarshalAs(UnmanagedType.BStr), In] string strImpExpPath);

    [DispId(10)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void AutoCompleteSaveForm([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Form);

    [DispId(11)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void AutoScan(
      [MarshalAs(UnmanagedType.BStr), In] string strSearch,
      [MarshalAs(UnmanagedType.BStr), In] string strFailureUrl,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object pvarTargetFrame);

    [DispId(12)]
    [TypeLibFunc(64)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void AutoCompleteAttach([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Reserved);

    [DispId(13)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Struct)]
    public virtual extern object ShowBrowserUI([MarshalAs(UnmanagedType.BStr), In] string bstrName, [MarshalAs(UnmanagedType.Struct), In] ref object pvarIn);

    [DispId(14)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void AddSearchProvider([MarshalAs(UnmanagedType.BStr), In] string URL);

    [DispId(15)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void RunOnceShown();

    [DispId(16)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SkipRunOnce();

    [DispId(17)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void CustomizeSettings([In] bool fSQM, [In] bool fPhishing, [MarshalAs(UnmanagedType.BStr), In] string bstrLocale);

    [DispId(18)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern bool SqmEnabled();

    [DispId(19)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern bool PhishingEnabled();

    [DispId(20)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string BrandImageUri();

    [DispId(21)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SkipTabsWelcome();

    [DispId(22)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void DiagnoseConnection();

    [DispId(23)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void CustomizeClearType([In] bool fSet);

    [DispId(24)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern uint IsSearchProviderInstalled([MarshalAs(UnmanagedType.BStr), In] string URL);

    [DispId(25)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern bool IsSearchMigrated();

    [DispId(26)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string DefaultSearchProvider();

    [DispId(27)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void RunOnceRequiredSettingsComplete([In] bool fComplete);

    [DispId(28)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern bool RunOnceHasShown();

    [DispId(29)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public virtual extern string SearchGuideUrl();

    [DispId(30)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void AddService([MarshalAs(UnmanagedType.BStr), In] string URL);

    [DispId(31)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern uint IsServiceInstalled([MarshalAs(UnmanagedType.BStr), In] string URL, [MarshalAs(UnmanagedType.BStr), In] string Verb);

    [DispId(37)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern bool InPrivateFilteringEnabled();

    [DispId(32)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void AddToFavoritesBar([MarshalAs(UnmanagedType.BStr), In] string URL, [MarshalAs(UnmanagedType.BStr), In] string Title, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Type);

    [DispId(33)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void BuildNewTabPage();

    [DispId(34)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SetRecentlyClosedVisible([In] bool fVisible);

    [DispId(35)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SetActivitiesVisible([In] bool fVisible);

    [DispId(36)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ContentDiscoveryReset();

    [DispId(38)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern bool IsSuggestedSitesEnabled();

    [DispId(39)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void EnableSuggestedSites([In] bool fEnable);

    [DispId(40)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void NavigateToSuggestedSites([MarshalAs(UnmanagedType.BStr), In] string bstrRelativeUrl);

    [DispId(41)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ShowTabsHelp();

    [DispId(42)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ShowInPrivateHelp();

    [DispId(43)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern bool msIsSiteMode();

    [DispId(47)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msSiteModeShowThumbBar();

    [DispId(48)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Struct)]
    public virtual extern object msSiteModeAddThumbBarButton([MarshalAs(UnmanagedType.BStr), In] string bstrIconURL, [MarshalAs(UnmanagedType.BStr), In] string bstrTooltip);

    [DispId(46)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msSiteModeUpdateThumbBarButton(
      [MarshalAs(UnmanagedType.Struct), In] object ButtonID,
      [In] bool fEnabled,
      [In] bool fVisible);

    [DispId(44)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msSiteModeSetIconOverlay([MarshalAs(UnmanagedType.BStr), In] string IconUrl, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object pvarDescription);

    [DispId(45)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msSiteModeClearIconOverlay();

    [DispId(49)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msAddSiteMode();

    [DispId(51)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msSiteModeCreateJumpList([MarshalAs(UnmanagedType.BStr), In] string bstrHeader);

    [DispId(52)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msSiteModeAddJumpListItem(
      [MarshalAs(UnmanagedType.BStr), In] string bstrName,
      [MarshalAs(UnmanagedType.BStr), In] string bstrActionUri,
      [MarshalAs(UnmanagedType.BStr), In] string bstrIconUri,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object pvarWindowType);

    [DispId(53)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msSiteModeClearJumpList();

    [DispId(56)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msSiteModeShowJumpList();

    [DispId(54)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Struct)]
    public virtual extern object msSiteModeAddButtonStyle(
      [MarshalAs(UnmanagedType.Struct), In] object uiButtonID,
      [MarshalAs(UnmanagedType.BStr), In] string bstrIconURL,
      [MarshalAs(UnmanagedType.BStr), In] string bstrTooltip);

    [DispId(55)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msSiteModeShowButtonStyle([MarshalAs(UnmanagedType.Struct), In] object uiButtonID, [MarshalAs(UnmanagedType.Struct), In] object uiStyleID);

    [DispId(58)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msSiteModeActivate();

    [DispId(59)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Struct)]
    public virtual extern object msIsSiteModeFirstRun([In] bool fPreserveState);

    [DispId(57)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msAddTrackingProtectionList([MarshalAs(UnmanagedType.BStr), In] string URL, [MarshalAs(UnmanagedType.BStr), In] string bstrFilterName);

    [DispId(60)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern bool msTrackingProtectionEnabled();

    [DispId(61)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern bool msActiveXFilteringEnabled();

    [DispId(62)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Struct)]
    public virtual extern object msProvisionNetworks([MarshalAs(UnmanagedType.BStr), In] string bstrProvisioningXml);

    [DispId(63)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msReportSafeUrl();

    [DispId(64)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msSiteModeRefreshBadge();

    [DispId(65)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msSiteModeClearBadge();

    [DispId(66)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msDiagnoseConnectionUILess();

    [DispId(67)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msLaunchNetworkClientHelp();

    [DispId(68)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msChangeDefaultBrowser([In] bool fChange);

    [DispId(69)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msStopPeriodicTileUpdate();

    [DispId(70)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msStartPeriodicTileUpdate(
      [MarshalAs(UnmanagedType.Struct), In] object pollingUris,
      [MarshalAs(UnmanagedType.Struct), In, Optional] object startTime,
      [MarshalAs(UnmanagedType.Struct), In, Optional] object uiUpdateRecurrence);

    [DispId(75)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msStartPeriodicTileUpdateBatch(
      [MarshalAs(UnmanagedType.Struct), In] object pollingUris,
      [MarshalAs(UnmanagedType.Struct), In, Optional] object startTime,
      [MarshalAs(UnmanagedType.Struct), In, Optional] object uiUpdateRecurrence);

    [DispId(71)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msClearTile();

    [DispId(72)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msEnableTileNotificationQueue([In] bool fChange);

    [DispId(73)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Struct)]
    public virtual extern object msPinnedSiteState();

    [DispId(76)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msEnableTileNotificationQueueForSquare150x150([In] bool fChange);

    [DispId(77)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msEnableTileNotificationQueueForWide310x150([In] bool fChange);

    [DispId(78)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msEnableTileNotificationQueueForSquare310x310([In] bool fChange);

    [DispId(79)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msScheduledTileNotification(
      [MarshalAs(UnmanagedType.BStr), In] string bstrNotificationXml,
      [MarshalAs(UnmanagedType.BStr), In] string bstrNotificationId,
      [MarshalAs(UnmanagedType.BStr), In] string bstrNotificationTag,
      [MarshalAs(UnmanagedType.Struct), In, Optional] object startTime,
      [MarshalAs(UnmanagedType.Struct), In, Optional] object expirationTime);

    [DispId(80)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msRemoveScheduledTileNotification([MarshalAs(UnmanagedType.BStr), In] string bstrNotificationId);

    [DispId(81)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msStartPeriodicBadgeUpdate(
      [MarshalAs(UnmanagedType.BStr), In] string pollingUri,
      [MarshalAs(UnmanagedType.Struct), In, Optional] object startTime,
      [MarshalAs(UnmanagedType.Struct), In, Optional] object uiUpdateRecurrence);

    [DispId(82)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msStopPeriodicBadgeUpdate();

    [DispId(74)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void msLaunchInternetOptions();
  }
}
