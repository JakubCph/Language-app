using Flashy.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Flashy.ViewModels
{
    public class FlashcardViewModel
    {
        private const string DefaultDeck = "Default";

        public FlashcardViewModel()
        {
            Decks = new ObservableCollection<Deck>()
            {
                new Deck(DefaultDeck)
            };
        }

        public ICollection<Deck> Decks { get; }

        public void AddDeckByName(string argDeckName)
        {
            Decks.Add(new Deck(argDeckName));
        }
        public void DeleteDeckByName(string argName)
        {
            //Default deck cannot be deleted.
            if (argName.Equals(DefaultDeck))
                return;

            var deckToDelete = Decks.Where(d => d.Name.Equals(argName)).FirstOrDefault();
            if (deckToDelete != null)
                Decks.Remove(deckToDelete);
        }
    }
}
