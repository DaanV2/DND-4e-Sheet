using System.Windows.Controls;

namespace DaanV2.DND.Pages {
    /// <summary>
    /// Interaction logic for CharacterPage.xaml
    /// </summary>
    public partial class CharacterPage : Page {
        public CharacterPage() {
            this.DataContext = new CharacterSheet();
            this.InitializeComponent();
        }
    }
}
