using System;
using System.Windows.Input;

namespace Commands.UnitTests;

public class DelegateCommandTests : CommandAdtTests
{
    protected override ICommand CreateSut()
    {
        return new DelegateCommand((_) => { }, (_) => true);
    }
    
    protected override ICommand CreateSut(Action<object?> execute)
    {
        return new DelegateCommand(execute, (_) => true);
    }

    protected override ICommand CreateSut(Func<object?, bool> canExecute)
    {
        return new DelegateCommand((_) => { }, canExecute);
    }

    protected override void ChangeCanExecute(ICommand sut)
    {
        var delegateCommand = sut as DelegateCommand;
        delegateCommand?.FireCanExecuteChanged();
    }
}