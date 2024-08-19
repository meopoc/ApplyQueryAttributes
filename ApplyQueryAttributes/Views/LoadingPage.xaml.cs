using ApplyQueryAttributes.Helpers.General;
using ApplyQueryAttributes.Helpers.Views.Utilities;
using ApplyQueryAttributes.ViewModels;
using System.Diagnostics;

namespace ApplyQueryAttributes.Views;

public partial class LoadingPage : ContentPage, IAsyncInitialization
{
	private readonly LoadingPageViewModel? loadingPageViewModel;

    public Task Initialisation { get; private set; }

    public LoadingPage()
	{
        Tracker.WriteLine();

        InitializeComponent();

		BindingContext = loadingPageViewModel = IPlatformApplication.Current?.Services.GetService<LoadingPageViewModel>();

		Initialisation = Initialise();
	}

	#region Lifecycle

	private async Task Initialise()
	{
        Tracker.WriteLine();

        await loadingPageViewModel.Initialise();
	}

	protected override void OnAppearing()
	{
        Tracker.WriteLine();

        loadingPageViewModel.OnAppearing();
	}

	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
        Tracker.WriteLine();

        loadingPageViewModel.OnNavigatedTo(args);
	}

	protected override void OnNavigatingFrom(NavigatingFromEventArgs args)
	{
        Tracker.WriteLine();

        //loadingPageViewModel.OnNavigatingFrom(args);
    }

	protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
	{
        Tracker.WriteLine();

        //loadingPageViewModel.OnNavigatedFrom(args);
    }

	protected override void OnDisappearing()
	{
        Tracker.WriteLine();

        //loadingPageViewModel.OnDisappearing();
    }

	#endregion
}