# UnoFlyoutStyleIssue
Reproduces an issue with flyout styles in Uno

Uno.UI 3.0.0-dev.76

Reported as issue #3216

System.Exception
  Message=Failed to load UnoFlyoutStyleIssue.MainPage: System.InvalidOperationException: The resource menuFlyoutItemStyle cannot be found
  at UnoFlyoutStyleIssue.MainPage+<>c__DisplayClass2_0.<InitializeComponent>b__1 (UnoFlyoutStyleIssue.MainPage c3) [0x00001] in D:\Development\GitHub\UnoFlyoutStyleIssue\UnoFlyoutStyleIssue\UnoFlyoutStyleIssue.Droid\obj\Debug\90\g\XamlCodeGenerator\MainPage_523c63a278830d164cac6f1cfbdba873.g.cs:87 
  at Uno.Extensions.ObjectExtensions.Apply[TSource] (TSource source, System.Action`1[T] action) [0x00000] in D:\a\1\s\src\Uno.Core\Extensions\ObjectExtensions.cs:110 
  at UnoFlyoutStyleIssue.MainPage.InitializeComponent () [0x000bc] in D:\Development\GitHub\UnoFlyoutStyleIssue\UnoFlyoutStyleIssue\UnoFlyoutStyleIssue.Droid\obj\Debug\90\g\XamlCodeGenerator\MainPage_523c63a278830d164cac6f1cfbdba873.g.cs:81 
  at UnoFlyoutStyleIssue.MainPage..ctor () [0x00013] in D:\Development\GitHub\UnoFlyoutStyleIssue\UnoFlyoutStyleIssue\UnoFlyoutStyleIssue.Shared\MainPage.xaml.cs:27 
  at UnoFlyoutStyleIssue.Droid.MetadataBuilder_643.CreateInstance () [0x00000] in D:\Development\GitHub\UnoFlyoutStyleIssue\UnoFlyoutStyleIssue\UnoFlyoutStyleIssue.Droid\obj\Debug\90\g\BindableTypeProvidersSourceGenerator\BindableMetadata.g.cs:31058 
  at Windows.UI.Xaml.Controls.Frame.CreatePageInstance (System.Type sourcePageType) [0x00016] in d:\a\1\s\src\Uno.UI\UI\Xaml\Controls\Frame\Frame.cs:414 
  at Windows.UI.Xaml.PagePool.DequeuePage (System.Type pageType) [0x00007] in d:\a\1\s\src\Uno.UI\UI\Xaml\PagePool.cs:69 
  at Windows.UI.Xaml.Controls.Frame.CreatePageInstanceCached (System.Type sourcePageType) [0x00000] in d:\a\1\s\src\Uno.UI\UI\Xaml\Controls\Frame\Frame.cs:404 
  at Windows.UI.Xaml.Controls.Frame.InnerNavigate (Windows.UI.Xaml.Navigation.PageStackEntry entry, Windows.UI.Xaml.Navigation.NavigationMode mode) [0x0009b] in d:\a\1\s\src\Uno.UI\UI\Xaml\Controls\Frame\Frame.cs:311
