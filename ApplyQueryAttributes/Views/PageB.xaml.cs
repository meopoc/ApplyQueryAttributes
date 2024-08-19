using ApplyQueryAttributes.Helpers.General;
using ApplyQueryAttributes.Helpers.Views.Utilities;
using ApplyQueryAttributes.ViewModels;

namespace ApplyQueryAttributes.Views;

public partial class PageB : ContentPage, IAsyncInitialization
{
    public readonly PageBViewModel pageBViewModel;

    public Task Initialisation { get; private set; }

    public PageB(PageBViewModel pageBViewModel)
    {
        Tracker.WriteLine();

        InitializeComponent();

        BindingContext = this.pageBViewModel = pageBViewModel;

        Initialisation = Initialise();
    }

    #region Lifecycle

    private async Task Initialise()
    {
        Tracker.WriteLine();

        await pageBViewModel.Initialise();
    }

    protected override void OnAppearing()
    {
        Tracker.WriteLine();

        pageBViewModel.OnAppearing();

        base.OnAppearing();
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        Tracker.WriteLine();

        pageBViewModel.OnNavigatedTo(args);

        base.OnNavigatedTo(args);
    }

    protected override void OnNavigatingFrom(NavigatingFromEventArgs args)
    {
        Tracker.WriteLine();

        pageBViewModel.OnNavigatingFrom(args);

        base.OnNavigatingFrom(args);
    }

    protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
    {
        Tracker.WriteLine();

        pageBViewModel.OnNavigatedFrom(args);

        base.OnNavigatedFrom(args);
    }

    protected override void OnDisappearing()
    {
        Tracker.WriteLine();

        pageBViewModel.OnDisappearing();

        base.OnDisappearing();
    }

    #endregion
}