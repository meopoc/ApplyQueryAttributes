using ApplyQueryAttributes.Helpers.General;
using ApplyQueryAttributes.Helpers.Views.Utilities;
using ApplyQueryAttributes.ViewModels;

namespace ApplyQueryAttributes.Views;

public partial class PageA : ContentPage, IAsyncInitialization
{
    private readonly PageAViewModel pageAViewModel;

    public Task Initialisation { get; private set; }

    public PageA(PageAViewModel pageAViewModel)
    {
        Tracker.WriteLine();

        InitializeComponent();

        BindingContext = this.pageAViewModel = pageAViewModel;

        Initialisation = Initialise();
    }

    #region Lifecycle

    private async Task Initialise()
    {
        Tracker.WriteLine();

        await pageAViewModel.Initialise();
    }

    protected override void OnAppearing()
    {
        Tracker.WriteLine();

        pageAViewModel.OnAppearing();

        base.OnAppearing();
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        Tracker.WriteLine();

        pageAViewModel.OnNavigatedTo(args);

        base.OnNavigatedTo(args);
    }

    protected override void OnNavigatingFrom(NavigatingFromEventArgs args)
    {
        Tracker.WriteLine();

        pageAViewModel.OnNavigatingFrom(args);

        base.OnNavigatingFrom(args);
    }

    protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
    {
        Tracker.WriteLine();

        pageAViewModel.OnNavigatedFrom(args);

        base.OnNavigatedFrom(args);
    }

    protected override void OnDisappearing()
    {
        Tracker.WriteLine();

        pageAViewModel.OnDisappearing();

        base.OnDisappearing();
    }

    #endregion
}