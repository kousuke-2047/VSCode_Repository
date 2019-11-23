using System;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace Util.BindingPropertyName{
    public class BindingProperty : INotifyPropertyChanged{
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged([CallerMemberName]String propertyName =null){
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }
    }
}