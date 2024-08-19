namespace ApplyQueryAttributes.ViewModels.Flyout.DetailPages
{
    public class PageWithFlyoutMenu_2ViewModel : ViewModelBase
    {
        public PageWithFlyoutMenu_2ViewModel()
        {
            Name = "PageWithFlyoutMenu_2";
        }

        #region Properties

        private string? name;
        public string? Name
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
            await base.Initialise();
        }

        /// <summary>
        /// Not working on iOS for when app moves to foreground
        /// </summary>
        public override void OnAppearing()
        {
            base.OnAppearing();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public override void OnNavigatingFrom(NavigatingFromEventArgs args)
        {
            base.OnNavigatingFrom(args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public override void OnNavigatedFrom(NavigatedFromEventArgs args)
        {
            base.OnNavigatedFrom(args);
        }

        /// <summary>
        /// Fires when screen turned off
        /// Not working on iOS for when app moves to background
        /// </summary>
        public override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        #endregion

        public override void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.ContainsKey("Test"))
            {
                var test = (string)query["Test"];
            }

            base.ApplyQueryAttributes(query);
        }
    }
}
