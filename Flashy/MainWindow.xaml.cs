using Flashy.Extensions;
using Flashy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Flashy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddDecks(object sender, RoutedEventArgs e)
        {
            var vm = Frame.DataContext as FlashcardViewModel;
            if (vm is null)
                return;
            var dialog = new Window();
            if (dialog.ShowDialog() == false)
                return; // operation canceled 

            vm.AddDeckByName("Sample");
        }

        private void ShowOptions(object sender, RoutedEventArgs e)
        {
           
        }

        private void txt1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var vm = Frame.DataContext as FlashcardViewModel;
            if (vm is null)
                return;
            vm.AddDeckByName("Sample");
        }
    }
}
