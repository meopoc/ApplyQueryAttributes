using ApplyQueryAttributes.Helpers.General;
using ApplyQueryAttributes.Helpers.Views.ContentTemplates;
using ApplyQueryAttributes.Helpers.Views.Utilities;
using ApplyQueryAttributes.ViewModels;

namespace ApplyQueryAttributes.Views;

public partial class MainPage : ContentPage, IAsyncInitialization
{
    private readonly MainPageViewModel? mainPageViewModel;

    public Task Initialisation { get; private set; }

    public MainPage(MainPageViewModel mainPageViewModel)
	{
        Tracker.WriteLine();

        InitializeComponent();

        BindingContext = this.mainPageViewModel = mainPageViewModel;

        Initialisation = Initialise();
    }

    #region Lifecycle

    private async Task Initialise()
    {
        Tracker.WriteLine();

        await mainPageViewModel?.Initialise();
    }

    protected override void OnAppearing()
    {
        Tracker.WriteLine();

        ContentTemplatesStackLayout.Clear();

        try
        {
            var count = 1;

            foreach (var contentTemplate in mainPageViewModel.ContentTemplates)
            {
                switch (contentTemplate.Type)
                {
                    case 0:

                        var buttonContentView = new ButtonContentView()
                        {
                            ControlTemplate = (ControlTemplate)this.Resources["ButtonTemplate"],
                            BindingContext = contentTemplate,
                            ButtonText = contentTemplate.ButtonText,
                            Count = count
                        };

                        ContentTemplatesStackLayout.Add(buttonContentView);

                        break;
                    case 1: 

                        var editorContentView = new EditorContentView()
                        {
                            ControlTemplate = (ControlTemplate)this.Resources["EditorTemplate"],
                            BindingContext = contentTemplate,
                            EditorUnfocusedCommand = mainPageViewModel.EditorUnfocusedCommand,
                            Count = count
                        };

                        ContentTemplatesStackLayout.Add(editorContentView);

                        break;
                }

                count++;
            }

            mainPageViewModel?.OnAppearing();
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        Tracker.WriteLine();

        mainPageViewModel?.OnNavigatedTo(args);
    }

    protected override void OnNavigatingFrom(NavigatingFromEventArgs args)
    {
        Tracker.WriteLine();

        mainPageViewModel?.OnNavigatingFrom(args);
    }

    protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
    {
        Tracker.WriteLine();

        mainPageViewModel?.OnNavigatedFrom(args);
    }

    protected override void OnDisappearing()
    {
        Tracker.WriteLine();

        mainPageViewModel?.OnDisappearing();
    }

    #endregion
}