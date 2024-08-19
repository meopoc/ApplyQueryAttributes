using ApplyQueryAttributes.Helpers.Views.Utilities;
using ApplyQueryAttributes.ViewModels.Flyout;

namespace ApplyQueryAttributes.Views;

//[QueryProperty(nameof(Test), "Test")]
public partial class FlyoutMenu : ContentView, IAsyncInitialization
{
    private readonly FlyoutMenuViewModel? flyoutMenuViewModel;

    public Task Initialisation { get; private set; }

    public Guid JobId { get; set; }

    public FlyoutMenu(FlyoutMenuViewModel flyoutMenuViewModel)
    {
        Console.WriteLine("**** ApplyQueryAttributes FlyoutMenu Constructor");

        InitializeComponent();

        BindingContext = this.flyoutMenuViewModel = flyoutMenuViewModel;

        Initialisation = Initialise();
    }

    #region Lifecycle

    private async Task Initialise()
    {
        Console.WriteLine("**** ApplyQueryAttributes FlyoutMenu Initialise");

        await flyoutMenuViewModel.Initialise();
    }

    #endregion
}