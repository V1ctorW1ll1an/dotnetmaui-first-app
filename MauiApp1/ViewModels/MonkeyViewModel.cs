using System.Collections.ObjectModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Models;
using MauiApp1.Services; 


namespace MauiApp1.ViewModels;

public partial class MonkeyViewModel : BaseViewModel
 {
   private readonly MonkeyService _monkeyService;
   
   public ObservableCollection<Monkey> Monkeys { get; } = new();
 
   public MonkeyViewModel(MonkeyService monkeyService)
   {
     this.Title = "Monkey finder";
     this._monkeyService = monkeyService;
   }

   [RelayCommand]
   private async Task GetMonkeysAsync()
   {
     if (IsBusy)
       return;
     try
     {
       IsBusy = true;
       var monkeys = await _monkeyService.GetMonkeys();

       if (Monkeys.Count != 0)
         Monkeys.Clear();

       foreach (var monkey in monkeys)
         Monkeys.Add(monkey);

     }
     catch (Exception ex)
     {
       Debug.WriteLine(ex);
       await Shell.Current.DisplayAlert(
         "Error!",
         $"Unable to gets monkeys: {ex.Message}",
         "OK");
     }
     finally
     {
       IsBusy = false;
     }
   }
 }