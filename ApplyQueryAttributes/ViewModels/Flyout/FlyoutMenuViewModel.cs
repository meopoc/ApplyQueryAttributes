using ApplyQueryAttributes.Helpers.General;
using CommunityToolkit.Mvvm.Input;

namespace ApplyQueryAttributes.ViewModels.Flyout
{
    public partial class FlyoutMenuViewModel : ViewModelBase
    {
        public FlyoutMenuViewModel()
        {
            Tracker.WriteLine();

            Name = "Flyout Menu Name";
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

        #endregion

        #region Commands

        [RelayCommand]
        private async Task Navigate(string page)
        {
            switch (page)
            {
                case "MainPage":

                    Shell.Current.FlyoutIsPresented = false;

                    Shell.Current.FlyoutContent = null;

                    await Shell.Current.GoToAsync($"///LoadingPage/{page}");

                    break;
                case "PageWithFlyoutMenu_1":

                    await Shell.Current.GoToAsync($"///{page}");

                    Shell.Current.FlyoutIsPresented = false;

                    break;
                case "PageWithFlyoutMenu_2":

                    await Shell.Current.GoToAsync($"///{page}");

                    Shell.Current.FlyoutIsPresented = false;

                    break;
            }
        }

        #endregion

        public override void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            Tracker.WriteLine();

            base.ApplyQueryAttributes(query);
        }
    }
}
