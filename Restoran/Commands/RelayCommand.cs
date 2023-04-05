using Restoran.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Restoran.Commands
{
    public class RelayCommand : ICommand
    {
        private Action<object?> executeShowCommand;
        private Func<object?, bool> canExecuteShowCommand;

        public RelayCommand(Action<object?> executeShowCommand, Func<object?, bool> canExecuteShowCommand)
        {
            this.executeShowCommand = executeShowCommand;
            this.canExecuteShowCommand = canExecuteShowCommand;
        }

        public event EventHandler? CanExecuteChanged;

        public void Execute(object? parameter)
        {
            Window2 window2 = new Window2();
            window2.Show();
        }

        public bool CanExecute(object? parameter) => true;


    }
}