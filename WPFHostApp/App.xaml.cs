using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
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
            BlazorUI.Program.RunServer(Array.Empty<string>());
        }

        protected override void OnExit(ExitEventArgs e)
        {
            BlazorUI.Program.StopServer();
            base.OnExit(e);
        }
    }
}
