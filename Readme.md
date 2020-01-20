# Hosting a Blazor UI in a .NET Core WPF Application

A **proof of concept** project which hosts a WPF UI with a Blazor UI.

The application is hosting ASP.net Core in the same process as WPF.  This allows all of the C# code to run in the same process making the interop between the WPF and Blazor UI seamless.

The Blazor portion is essentially the stock Blazor template app with a minimum number of modifications to share state with the WPF portion.

The application is using [CEFSharp](https://github.com/cefsharp) to host the web content in the WPF UI. CefSharp enables a seamless hosting of HTML content with no airspace issues.

You can look at the Git history to see the steps necessary to create the app.  I tried to keep the history as "step by step" as possible.

![alt text](Images/WPFBlazor.gif "Screen Capture of Demo Application")
