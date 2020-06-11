using System;
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

namespace Flashy.Model
{
    public class Card : INotifyPropertyChanged
    {
        string Picture { get; set; }
        public string ForeignWord { get; set; }
        public string Translation { get; set; }
        public string ForeignWordRecording { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string argPropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(argPropertyName));
        }

        public void TellHowWellYouKnowWord() { throw new NotImplementedException(); }


    }
}