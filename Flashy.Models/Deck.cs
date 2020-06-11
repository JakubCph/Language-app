using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashy.Model
{
    public class Deck : INotifyPropertyChanged
    {
        ICollection<Card> m_cards;

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string argPropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(argPropertyName));
        }

        private string name;
        public string Name 
        {
            get => name;
            set 
            {
                if (value == Name)
                    return;

                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public Deck()
        {
            m_cards = new ObservableCollection<Card>();
        }

        public Deck(string argName)
            :this()
        {
            Name = argName;
        }
        public void AddCard(Card argCard)
        {
            m_cards.Add(argCard);
        }

        public void RemoveCard(Card argCard)
        {
            m_cards.Remove(argCard);
        }
    }
}
