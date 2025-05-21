SET cefsharpversion=135.0.220

..\nuget restore CefSharp.MinimalExample.sln

..\nuget update CefSharp.MinimalExample.WinForms\CefSharp.MinimalExample.WinForms.csproj -Id CefSharp.WinForms -Version %cefsharpversion%

dotnet add CefSharp.MinimalExample.WinForms\CefSharp.MinimalExample.WinForms.net472.csproj package CefSharp.WinForms -v %cefsharpversion%

dotnet add CefSharp.MinimalExample.WinForms\CefSharp.MinimalExample.WinForms.netcore.csproj package CefSharp.WinForms.NetCore -v %cefsharpversion%


pause