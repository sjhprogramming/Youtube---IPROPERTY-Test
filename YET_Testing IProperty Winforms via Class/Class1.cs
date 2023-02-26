using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YET_Testing_IProperty_Winforms_via_Class
{
    internal class Class1 : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _textToChange;

        public string TextToChange 
        {
            get { return _textToChange; }
            set 
            { 
                if (value == TextToChange) return;         // Don't update as the value has stayed the same!
                _textToChange = value;
                OnPropertyChanged(TextToChange);
            }
        
        }




    }
}
