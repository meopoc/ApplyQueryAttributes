using ApplyQueryAttributes.Helpers.General;
using CommunityToolkit.Mvvm.Input;

namespace ApplyQueryAttributes.ViewModels
{
    public partial class PageAViewModel : ViewModelBase
    {
        public PageAViewModel()
        {
            Tracker.WriteLine();

            Name = "Page A";
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
            await Shell.Current.GoToAsync($"PageB", new Dictionary<string, object>
            {
                { "Test", "Test" }
            });
        }

        #endregion

        public override void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            Tracker.WriteLine();
        }
    }
}
