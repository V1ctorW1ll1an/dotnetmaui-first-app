using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1.ViewModels;

public partial class BaseViewModel: ObservableObject
{
  
  public BaseViewModel()
  {
  }

  [ObservableProperty] 
   private string _title;

  [ObservableProperty]
  [NotifyPropertyChangedFor(nameof(_isNotBusy))]
   private bool _isBusy;
   
   private bool _isNotBusy => !_isBusy;

}