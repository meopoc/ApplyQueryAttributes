namespace ApplyQueryAttributes.ViewModels
{
    public class AppShellViewModel : ViewModelBase
    {
        public AppShellViewModel()
        {

        }

        #region Lifecycle

        public override async Task Initialise()
        {
            await base.Initialise();
        }

        /// <summary>
        /// This fires when app starts and when app returns from being backgrounded(swiped close).
        /// </summary>
        public override void OnAppearing()
        {
            base.OnAppearing();
        }

        public override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);
        }

        public override void OnNavigatingFrom(NavigatingFromEventArgs args)
        {
            base.OnNavigatingFrom(args);
        }

        public override void OnNavigatedFrom(NavigatedFromEventArgs args)
        {
            base.OnNavigatedFrom(args);
        }

        /// <summary>
        /// This fires when app is backgrounded(swiped close).
        /// </summary>
        public override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        #endregion
    }
}
