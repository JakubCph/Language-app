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
        private readonly ViewsNavigator m_navigator;
        public MainWindow()
        {
            InitializeComponent();
            m_navigator = MainView.FindResource("Navigator") as ViewsNavigator;
        }

        private void AddDecks(object sender, RoutedEventArgs e)
        {
            m_navigator.ChangeMode(DisplayMode.Decks);
        }

        private void LearnDeck(object sender, RoutedEventArgs e)
        {
            m_navigator.ChangeMode(DisplayMode.LearningMode);
        }
    }
}
