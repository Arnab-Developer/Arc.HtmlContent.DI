# HTML content DI

This is a library for 
[html content core](https://github.com/Arnab-Developer/ArnabDeveloper.HtmlContent.Core) 
dependency injection for ASP.NET.

Install from NuGet.

```
dotnet add package Arc.HtmlContent.DI
```

Use the below code in `Program.cs` to add `html content core` into ASP.NET DI.

```csharp
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddHtmlContentService();
```

There is a 
[WPF app](https://github.com/Arnab-Developer/ArnabDeveloper.HtmlContent.WpfApp) 
which uses this library to show HTML responses. This is to show how you can use this 
library in your app.