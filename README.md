# Commands

Example:

```

public class ViewModel
{

  public ViewModel()
  {
    SomeCommand = new DelegateCommand(CanExecuteSomeCommand, ExecuteSomeCommand);
  }
  
  public ICommand SomeCommand { get; private set; }
  
  private bool CanExecuteSomeCommand(object? state)
  {
    
  }
  
  private void ExecuteSomeCommand(object? state)
  {
  
  }
}

```
