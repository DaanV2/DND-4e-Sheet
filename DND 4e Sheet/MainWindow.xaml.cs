using System;
using System.Windows;
using System.Windows.Controls;
using DaanV2.DND;
using DaanV2.DND.Pages;

namespace DND_4e_Sheet {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            this.InitializeComponent();
            PageController.LoadPage += this.PageController_LoadPage;
            this.TabView.Items.Add(TabController.Load(new StartPage()));
        }

        private void PageController_LoadPage(Object sender, Page e) {
            Int32 Index = this.TabView.Items.Add(TabController.Load(e));
            this.TabView.SelectedIndex = Index;
        }
    }
}
