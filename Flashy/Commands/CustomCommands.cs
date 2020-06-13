using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Flashy.Commands
{
	public static class CustomCommands
	{
		public static readonly RoutedUICommand AddDecks = new RoutedUICommand
			(
				"Add decks",
				"AddDecks",
				typeof(CustomCommands),
				new InputGestureCollection()
				{
					new KeyGesture(Key.F4)
				}
			);

		
		public static readonly RoutedUICommand LearnDeck = new RoutedUICommand
			(
				"Learn deck",
				"LearnDeck",
				typeof(CustomCommands),
				new InputGestureCollection()
				{
					new KeyGesture(Key.F1)
				}
			);

		public static readonly RoutedUICommand ViewDecks = new RoutedUICommand
			(
				"View decks",
				"ViewDecks",
				typeof(CustomCommands),
				new InputGestureCollection()
				{
					new KeyGesture(Key.F2)
				}
			);
	}
}
