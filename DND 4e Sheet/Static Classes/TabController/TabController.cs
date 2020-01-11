using System.Windows.Controls;
using DaanV2.DND.Pages;

namespace DaanV2.DND {
    ///DOLATER <summary>add description for class: TabController</summary>
    public static partial class TabController {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static TabItem Load(Page page) {
            if (page is CharacterPage CP) {
                return Load(CP);
            }

            TabItem Tab = new TabItem {
                Content = new Frame {
                    Content = page
                },
                Header = page.Title
            };

            return Tab;
        }

        public static TabItem Load(CharacterPage page) {
            TabItem Tab = new TabItem {
                Content = new Frame {
                    Content = page
                }
            };

            if (page.DataContext is CharacterSheet CS) {
                Tab.Header = $"{CS.Details.Name} - {CS.Details.Level}";
            }

            return Tab;
        }
    }
}
