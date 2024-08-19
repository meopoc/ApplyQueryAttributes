using ApplyQueryAttributes.Helpers.General;
using ApplyQueryAttributes.Views;

namespace ApplyQueryAttributes.ViewModels
{
    public class LoadingPageViewModel : ViewModelBase
    {
        public LoadingPageViewModel()
        {
            Tracker.WriteLine();
        }

        #region Properties

        #endregion

        #region Lifecycle

        public async override Task Initialise()
        {
            Tracker.WriteLine();

            await base.Initialise();
        }

        public override void OnAppearing()
        {
            Tracker.WriteLine();

            base.OnAppearing();
        }

        public async override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            Tracker.WriteLine();

            await Shell.Current.GoToAsync($"{nameof(MainPage)}");

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
    }
}
