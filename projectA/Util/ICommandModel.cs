using System.Windows.Input;
using System;


namespace ICommandModelName{
    public  class ICommandModel : ICommand{
        private readonly Action<object> action; 
        private readonly Func<object,bool> canExecute;

        public event EventHandler CanExecuteChanged{
            add{CommandManager.RequerySuggested += value;}
            remove{CommandManager.RequerySuggested -= value;}
        }

        public bool CanExecute(object parameter){
            return this.canExecute(parameter);
        }
        public void Execute(object parameter){
            action(parameter);
        }
    }
}