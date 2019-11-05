using System;
using System.Windows.Input;

namespace MVVM_cyberforum.Infrastructure
{
    class RelayCommand : ICommand
    {
        private readonly Func<object, bool> _canExecute;
        private readonly Action<object> _onExecute;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _onExecute = execute;
            _canExecute = canExecute;
        }
        public bool CanExecute(object parametr) => _canExecute == null ? true : _canExecute.Invoke(parametr);
        public void Execute(object parametr) => _onExecute?.Invoke(parametr);
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }
    }
}
