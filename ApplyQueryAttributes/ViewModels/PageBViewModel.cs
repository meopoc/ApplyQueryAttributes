using ApplyQueryAttributes.Helpers.General;
using ApplyQueryAttributes.Views;
using CommunityToolkit.Mvvm.Input;

namespace ApplyQueryAttributes.ViewModels
{
    public partial class PageBViewModel : ViewModelBase
    {
        public PageBViewModel()
        {
            Tracker.WriteLine();

            Name = "Page B";
        }

        #region Properties

        private string name;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        #endregion

        #region Lifecycle

        /// <summary>
        /// 
        /// </summary>
        public override async Task Initialise()
        {
            Tracker.WriteLine();

            await base.Initialise();
        }

        /// <summary>
        /// Not working on iOS for when app moves to foreground
        /// </summary>
        public override void OnAppearing()
        {
            Tracker.WriteLine();

            base.OnAppearing();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public async override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            Tracker.WriteLine();

            base.OnNavigatedTo(args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public override void OnNavigatingFrom(NavigatingFromEventArgs args)
        {
            Tracker.WriteLine();

            base.OnNavigatingFrom(args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public override void OnNavigatedFrom(NavigatedFromEventArgs args)
        {
            Tracker.WriteLine();

            base.OnNavigatedFrom(args);
        }

        /// <summary>
        /// Fires when screen turned off
        /// Not working on iOS for when app moves to background
        /// </summary>
        public override void OnDisappearing()
        {
            Tracker.WriteLine();

            base.OnDisappearing();
        }

        #endregion

        #region Commands

        [RelayCommand]
        private async Task Navigate()
        {
            Shell.Current.FlyoutContent = IPlatformApplication.Current?.Services.GetService<FlyoutMenu>();

            await Shell.Current.GoToAsync($"///PageWithFlyoutMenu_1", new Dictionary<string, object>
            {
                { "Test", "Test" }
            });

            //await Shell.Current.GoToAsync($"///PageWithFlyoutMenu_2", new Dictionary<string, object>
            //{
            //    { "Test", "Test" }
            //});

            Shell.Current.FlyoutIsPresented = false;
        }

        #endregion

        public override void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            Tracker.WriteLine();

            base.ApplyQueryAttributes(query);
        }
    }
}
