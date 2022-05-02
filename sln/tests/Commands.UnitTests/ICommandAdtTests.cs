using System;
using System.Windows.Input;
using FluentAssertions;
using Xunit;

namespace PCC.Libraries.Commands.UnitTests;

public abstract class ICommandAdtTests
{
    protected abstract ICommand CreateSut();
    protected abstract ICommand CreateSut(Action<object> execute, Func<object, bool> canExecute);
    protected abstract ICommand CreateSut(Func<object, bool> canExecute);
    
    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void CanExecute_Returns_Correct_Value(bool expected)
    {
        var sut = CreateSut((state) => expected);

        sut.CanExecute(null).Should().Be(expected);
    }
    
    /*event EventHandler? CanExecuteChanged;

    bool CanExecute(object? parameter);

    void Execute(object? parameter);*/
}