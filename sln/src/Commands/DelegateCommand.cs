using System;
using System.Windows.Input;

namespace PCC.Libraries.Commands;

public class DelegateCommand : ICommand
{
    private readonly Func<object, bool> _canExecute;

    public DelegateCommand(Action<object> execute, Func<object,bool> canExecute)
    {
        _canExecute = canExecute;
    }

    public bool CanExecute(object? parameter)
    {
        return _canExecute(parameter);
    }

    public void Execute(object? parameter)
    {
        throw new NotImplementedException();
    }

    public event EventHandler? CanExecuteChanged;
}