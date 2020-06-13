using Flashy.Extensions;
using Flashy.Pages;
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
        private readonly IViewsNavigator m_navigator;
        private readonly IDecksViewModel m_decksVM;

        public MainWindow()
        {
            InitializeComponent();
            m_navigator = MainView.FindResource("Navigator") as IViewsNavigator;
            m_decksVM = MainView.FindResource("DecksViewModel") as IDecksViewModel;
        }

        private void AddDecks(object sender, RoutedEventArgs e)
        {
            var window = new AddDeckWindow(m_decksVM);
            window.Show();
        }

        private void LearnDeck(object sender, RoutedEventArgs e)
        {
            m_navigator.ChangeMode(DisplayMode.LearningMode);
        }

        private void ViewDecks(object sender, RoutedEventArgs e)
        {
            m_navigator.ChangeMode(DisplayMode.Decks);
        }
    }
}
