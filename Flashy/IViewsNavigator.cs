using System.Windows.Controls;

namespace Flashy
{
    public interface IViewsNavigator
    {
        UserControl View { get; set; }

        void ChangeMode(DisplayMode argMode);
    }
}