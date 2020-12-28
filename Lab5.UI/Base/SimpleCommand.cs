using System;
using System.Windows.Input;

namespace Lab5.Base
{
    class SimpleCommand: ICommand
    {
        public SimpleCommand(Action<object> executionAction)
        {
            _executionAction = executionAction;
        }

        private readonly Action<object> _executionAction;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) => _executionAction.Invoke(parameter);
    }
}
