using ApplyQueryAttributes.Helpers.Views.Utilities;
using ApplyQueryAttributes.ViewModels.Flyout.DetailPages;

namespace ApplyQueryAttributes.Views.Flyout.DetailPages;

//[QueryProperty(nameof(Test), "Test")]
public partial class PageWithFlyoutMenu_2 : ContentPage, IAsyncInitialization
{
    private readonly PageWithFlyoutMenu_2ViewModel PageWithFlyoutMenu_2ViewModel;

    public Task Initialisation { get; private set; }

    public PageWithFlyoutMenu_2(PageWithFlyoutMenu_2ViewModel PageWithFlyoutMenu_2ViewModel)
    {
        InitializeComponent();

        BindingContext = this.PageWithFlyoutMenu_2ViewModel = PageWithFlyoutMenu_2ViewModel;

        Initialisation = Initialise();
    }

    #region Lifecycle

    private async Task Initialise()
    {
        await PageWithFlyoutMenu_2ViewModel.Initialise();
    }

    protected override void OnAppearing()
    {
        PageWithFlyoutMenu_2ViewModel.OnAppearing();

        base.OnAppearing();
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        PageWithFlyoutMenu_2ViewModel.OnNavigatedTo(args);

        base.OnNavigatedTo(args);
    }

    protected override void OnNavigatingFrom(NavigatingFromEventArgs args)
    {
        PageWithFlyoutMenu_2ViewModel.OnNavigatingFrom(args);

        base.OnNavigatingFrom(args);
    }

    protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
    {
        PageWithFlyoutMenu_2ViewModel.OnNavigatedFrom(args);

        base.OnNavigatedFrom(args);
    }

    protected override void OnDisappearing()
    {
        PageWithFlyoutMenu_2ViewModel.OnDisappearing();

        base.OnDisappearing();
    }

    #endregion
}