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
  [NotifyPropertyChangedFor(nameof(IsNotBusy))]
   private bool _isBusy;
   


   private bool IsNotBusy => !IsBusy;

}