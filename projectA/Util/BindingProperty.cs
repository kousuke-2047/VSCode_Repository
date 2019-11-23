using System;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace BindingPropertyName{
    public class BindingProperty : INotifyPropertyChanged{
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName]String propertyName =null){
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }
    }
}