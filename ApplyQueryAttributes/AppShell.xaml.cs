using ApplyQueryAttributes.Helpers.Views.Utilities;
using ApplyQueryAttributes.ViewModels;
using ApplyQueryAttributes.Views;
using System.ComponentModel;

namespace ApplyQueryAttributes
{
    public partial class AppShell : Shell, IAsyncInitialization
    {
        private readonly AppShellViewModel appShellViewModel;

        public Task Initialisation { get; private set; }

        public AppShell()
        {
            #region Non-Shell Routing Registration

            Routing.RegisterRoute("MainPage", typeof(MainPage));
            Routing.RegisterRoute("PageA", typeof(PageA));
            Routing.RegisterRoute("PageB", typeof(PageB));

            #endregion

            InitializeComponent();

            BindingContext = appShellViewModel = IPlatformApplication.Current?.Services.GetService<AppShellViewModel>();

            Initialisation = Initialise();

            PropertyChanged += AppShell_PropertyChanged;
        }

        #region Lifecycle

        private async Task Initialise()
        {
            await appShellViewModel.Initialise();
        }

        /// <summary>
        /// This fires when app starts and when app returns from being backgrounded(swiped close).
        /// </summary>
        protected override void OnAppearing()
        {
            appShellViewModel.OnAppearing();

            base.OnAppearing();
        }

        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            appShellViewModel.OnNavigatedTo(args);

            base.OnNavigatedTo(args);
        }

        protected override void OnNavigatingFrom(NavigatingFromEventArgs args)
        {
            appShellViewModel.OnNavigatingFrom(args);

            base.OnNavigatingFrom(args);
        }

        protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
        {
            appShellViewModel.OnNavigatedFrom(args);

            base.OnNavigatedFrom(args);
        }

        /// <summary>
        /// This fires when app is backgrounded(swiped close).
        /// </summary>
        protected override void OnDisappearing()
        {


            appShellViewModel.OnDisappearing();

            base.OnAppearing();
        }

        protected override void OnNavigating(ShellNavigatingEventArgs args)
        {
            //Tracker.WriteLine($"Current ({args?.Current?.Location?.OriginalString}) Target ({args?.Target?.Location?.OriginalString})");

            base.OnNavigating(args);
        }

        protected override void OnNavigated(ShellNavigatedEventArgs args)
        {
            //Tracker.WriteLine($"Current ({args?.Current?.Location?.OriginalString}) Previous ({args?.Previous?.Location?.OriginalString}) ");

            base.OnNavigated(args);
        }

        #endregion

        private void AppShell_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "FlyoutIsPresented")
            {

            }
        }
    }
}
