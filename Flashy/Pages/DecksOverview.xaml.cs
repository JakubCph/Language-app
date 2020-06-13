using Flashy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Flashy.Pages
{
    /// <summary>
    /// Interaction logic for DecksOverview.xaml
    /// </summary>
    public partial class DecksOverview : UserControl
    {
        public DecksOverview()
        {
            InitializeComponent();
        }
       
        private void DeckList_LostFocus(object sender, RoutedEventArgs e)
        {
            DeckList.SelectedItem = null;
        }
    }
}
