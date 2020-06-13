using Flashy.Pages;
using System.ComponentModel;
using System.Windows.Controls;

namespace Flashy
{
    public class ViewsNavigator : System.ComponentModel.INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChaged(string argName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(argName));
        }

        public void ChangeMode(DisplayMode argMode)
        {
            switch (argMode)
            {
                case DisplayMode.LearningMode:
                    View = new LearningMode();
                    break;
                case DisplayMode.Decks:
                    View = new DecksOverview();
                    break;
                default:
                    break;
            }
        }

        private UserControl m_control;
        public UserControl View 
        { 
            get => m_control;
            set
            {
                if (value == m_control)
                    return;

                m_control = value;
                OnPropertyChaged(nameof(View));
            }
        }
    }
}