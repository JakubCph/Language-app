using Flashy.Commands;
using Flashy.Pages;
using Flashy.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Flashy
{
    public partial class ToollbarItemsComposer : INotifyPropertyChanged
    {
        public ToollbarItemsComposer()
        {
            Buttons = m_DeckSelectedButtons;
        }
                
        private readonly ObservableCollection<Button> m_DeckSelectedButtons = new ObservableCollection<Button>()
        {
            new Button(){Name = "DecksOverviewButton", Content = "Decks", Command = CustomCommands.ViewDecks},           
            new Button(){Name = "AddCardsButton", Content = "Add card"},
            new Button(){Name = "LearnButton", Content = "Learn", Command = CustomCommands.LearnDeck}
        };
        public void ProvideButtons(ToolbarConfigurationMode argMode)
        {
            switch (argMode)
            {
                case ToolbarConfigurationMode.NoDeckSelected:
                    Buttons = null;
                    break;
                case ToolbarConfigurationMode.DeckSelected:
                    Buttons = m_DeckSelectedButtons;
                    break;
                default:
                    Buttons = null;
                    break;
            }
        }

        private ObservableCollection<Button> m_buttons;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Button> Buttons 
        {
            get => m_buttons;
            set
            {
                if (Buttons == value)
                    return;

                m_buttons = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Buttons)));
            }
        }


    }
}
