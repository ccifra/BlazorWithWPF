using System;
using System.Windows;

namespace WPFHostApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            BlazorUI.ServerManager.RunServer(Array.Empty<string>());
        }

        protected override void OnExit(ExitEventArgs e)
        {
            BlazorUI.ServerManager.StopServer();
            base.OnExit(e);
        }
    }
}
