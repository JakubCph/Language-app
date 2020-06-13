using Flashy.Model;
using System.Collections.Generic;

namespace Flashy.ViewModels
{
    public interface IDecksViewModel
    {
        ICollection<Deck> Decks { get; }

        void AddDeckByName(string argDeckName);
        void DeleteDeckByName(string argName);
    }
}