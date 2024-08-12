using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging;

namespace MauiAppSingleProject.ViewModels;

public partial class MainPageViewModel(ILogger<MainPageViewModel> logger) : ObservableObject
{

    [ObservableProperty]
    private string _counterBtnLbl = "Click me!";

    public int Count { get; set; } = 0;

    [RelayCommand]
    public void SignInAsync()
    {
        logger.LogInformation("SigInAsync");
        Count++;

        if (Count == 1)
            CounterBtnLbl = $"Clicked {Count} time";
        else
            CounterBtnLbl = $"Clicked {Count} times";

        SemanticScreenReader.Announce(CounterBtnLbl);
    }
}

