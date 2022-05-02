using System;
using System.Windows.Input;

namespace PCC.Libraries.Commands.UnitTests;

public class DelegateCommandTests : ICommandAdtTests
{
    protected override ICommand CreateSut()
    {
        return new DelegateCommand((o) => { }, (o) => true);
    }

    protected override ICommand CreateSut(Action<object> execute, Func<object, bool> canExecute)
    {
        return new DelegateCommand(execute, canExecute);
    }

    protected override ICommand CreateSut(Func<object, bool> canExecute)
    {
        return new DelegateCommand((s) => s.ToString(), canExecute);
    }

    protected override void ChangeCanExecute(ICommand sut)
    {
        var delegateCommand = sut as DelegateCommand;
        delegateCommand.FireCanExecuteChanged();
    }
}