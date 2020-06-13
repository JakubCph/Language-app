using Flashy.Pages;
using System.ComponentModel;
using System.Windows.Controls;

namespace Flashy
{
    public class ViewsNavigator : System.ComponentModel.INotifyPropertyChanged, IViewsNavigator
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChaged(string argName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(argName));
        }
        public DisplayMode CurrentMode 
        {
            get => m_currentMode;
            set
            {
                if (CurrentMode == value)
                    return;

                m_currentMode = value;
                OnPropertyChaged(nameof(CurrentMode));
            }
        }
        public void ChangeMode(DisplayMode argMode)
        {
            CurrentMode = argMode;

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
        private DisplayMode m_currentMode = DisplayMode.Decks;

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