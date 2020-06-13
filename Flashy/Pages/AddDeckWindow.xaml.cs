using Flashy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Flashy.Pages
{
    /// <summary>
    /// Interaction logic for AddDeckWindow.xaml
    /// </summary>
    public partial class AddDeckWindow : Window
    {
        private readonly IDecksViewModel argDecksVM;

        public AddDeckWindow(IDecksViewModel argDecksVM)
            :base()
        {
            InitializeComponent();
            this.argDecksVM = argDecksVM;

            Loaded += SetKeyboardFocus;
        }

        private void SetKeyboardFocus(object sender, RoutedEventArgs e)
        {
            Keyboard.Focus(InputTextBox);
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            argDecksVM.AddDeckByName(InputTextBox.Text);
            InputTextBox.Text = "";
            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
