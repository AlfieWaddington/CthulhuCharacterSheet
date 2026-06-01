using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CthulhuCharacterSheet
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {

        }//Constructor

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged ( string propertyName )
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }//OnPropertyChanged

        

    }//class

}//namespace
