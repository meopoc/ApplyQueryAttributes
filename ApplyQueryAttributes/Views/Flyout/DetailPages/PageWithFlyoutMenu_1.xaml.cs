using ApplyQueryAttributes.Helpers.Views.Utilities;
using ApplyQueryAttributes.ViewModels.Flyout.DetailPages;

namespace ApplyQueryAttributes.Views.Flyout.DetailPages;

//[QueryProperty(nameof(Test), "Test")]
public partial class PageWithFlyoutMenu_1 : ContentPage, IAsyncInitialization
{
    private readonly PageWithFlyoutMenu_1ViewModel PageWithFlyoutMenu_1ViewModel;

    public Task Initialisation { get; private set; }

    public Guid JobId { get; set; }

    public PageWithFlyoutMenu_1(PageWithFlyoutMenu_1ViewModel PageWithFlyoutMenu_1ViewModel)
    {
        Console.WriteLine("**** ApplyQueryAttributes PageWithFlyoutMenu_1 Constructor");

        InitializeComponent();

        BindingContext = this.PageWithFlyoutMenu_1ViewModel = PageWithFlyoutMenu_1ViewModel;

        Initialisation = Initialise();
    }

    #region Lifecycle

    private async Task Initialise()
    {
        Console.WriteLine("**** ApplyQueryAttributes PageWithFlyoutMenu_1 Initialise");

        await PageWithFlyoutMenu_1ViewModel.Initialise();
    }

    protected override void OnAppearing()
    {
        Console.WriteLine("**** ApplyQueryAttributes PageWithFlyoutMenu_1 OnAppearing");

        PageWithFlyoutMenu_1ViewModel.OnAppearing();

        base.OnAppearing();
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        Console.WriteLine("**** ApplyQueryAttributes PageWithFlyoutMenu_1 OnNavigatedTo");

        PageWithFlyoutMenu_1ViewModel.OnNavigatedTo(args);

        base.OnNavigatedTo(args);
    }

    protected override void OnNavigatingFrom(NavigatingFromEventArgs args)
    {
        Console.WriteLine("**** ApplyQueryAttributes PageWithFlyoutMenu_1 OnNavigatingFrom");

        PageWithFlyoutMenu_1ViewModel.OnNavigatingFrom(args);

        base.OnNavigatingFrom(args);
    }

    protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
    {
        Console.WriteLine("**** ApplyQueryAttributes PageWithFlyoutMenu_1 OnNavigatedFrom");

        PageWithFlyoutMenu_1ViewModel.OnNavigatedFrom(args);

        base.OnNavigatedFrom(args);
    }

    protected override void OnDisappearing()
    {
        Console.WriteLine("**** ApplyQueryAttributes PageWithFlyoutMenu_1 OnDisappearing");

        PageWithFlyoutMenu_1ViewModel.OnDisappearing();

        base.OnDisappearing();
    }

    #endregion 
}