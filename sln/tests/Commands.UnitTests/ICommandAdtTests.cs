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
    protected abstract ICommand CreateSut(Action<object> execute);
    protected abstract void ChangeCanExecute(ICommand sut);
    
    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void CanExecute_Returns_Correct_Value(bool expected)
    {
        var sut = CreateSut((state) => (bool)state);

        sut.CanExecute(expected).Should().Be(expected);
    }

    [Fact]
    public void CanExecuteChanged_Fires_When_CanExecute_Changed()
    {
        var invoked = false;
        var sut = CreateSut();
        sut.CanExecuteChanged += (o, e) => invoked = true;
        
        ChangeCanExecute(sut);

        invoked.Should().BeTrue();
    }

    [Fact]
    public void Execute_Successful_Invokes_Action()
    {
        var expectedArg = new object();
        var invoked = false;
        var sut = CreateSut(new Action<object>((o) => invoked = ReferenceEquals(o, expectedArg)));

    bool CanExecute(object? parameter);

    void Execute(object? parameter);*/
}