using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DaanV2.Config;

namespace DND_4e_Sheet {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        private void Application_Startup(Object sender, StartupEventArgs e) {
            ConfigMapper.Preload(true);
            ResourceDictionary RS = new ResourceDictionary();
        }
    }
}
