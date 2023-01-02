using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1.ViewModels;


public partial class PeopleViewModel : ObservableObject
{
    [ObservableProperty]
    public string Title;

    [ObservableProperty]
    public int AnyNumber;

}