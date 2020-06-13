using Flashy.Commands;
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

            InitializeCommandBindings();

        }

        private void InitializeCommandBindings()
        {
            var AddDecksCmdBinding = new CommandBinding(CustomCommands.AddDecks, AddDecksExecuted, AddDecksCanExecute);
            var LearnDeckCmdBinding = new CommandBinding(CustomCommands.LearnDeck, LearnDeckExecuted, LearnDeckCanExecute);
            var ViewDecksCmdBinding = new CommandBinding(CustomCommands.ViewDecks, ViewDecksExecuted, ViewDecksCanExecute);

            this.CommandBindings.Add(AddDecksCmdBinding);
            this.CommandBindings.Add(LearnDeckCmdBinding);
            this.CommandBindings.Add(ViewDecksCmdBinding);
        }

        private void AddDecksExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            var window = new AddDeckWindow(m_decksVM);
            window.Show();
        }
        private void AddDecksCanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;

        private void LearnDeckExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            m_navigator.ChangeMode(DisplayMode.LearningMode);
        }
        private void LearnDeckCanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        
        private void ViewDecksExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            m_navigator.ChangeMode(DisplayMode.Decks);
        }
        private void ViewDecksCanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
               
    }
}
