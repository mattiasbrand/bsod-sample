using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Gibraltar.Agent;

namespace LoupeBSOD
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Log.StartSession();
            base.OnStartup(e);
        }
        protected override void OnActivated(EventArgs e)
        {
            Log.Warning("Foo2", "bar", "baz");
            base.OnActivated(e);
        }
        protected override void OnExit(ExitEventArgs e)
        {
            Log.EndSession();
            base.OnExit(e);
        }
    }
}
