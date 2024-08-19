using ApplyQueryAttributes.Helpers.General;
using ApplyQueryAttributes.Models.Dtos;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ApplyQueryAttributes.ViewModels
{
    public partial class MainPageViewModel : ViewModelBase
    {
        public Command EditorUnfocusedCommand { get; }

        public MainPageViewModel()
        {
            Tracker.WriteLine();

            ContentTemplates = new ObservableCollection<ContentTemplateDto> 
            { 
                new ContentTemplateDto()
                {
                    Type = 0,
                    Display = "This is a button",
                    Response = "",
                    ButtonText = "OK",
                },
                new ContentTemplateDto()
                {
                    Type = 1,
                    Display = "This is an Editor (1)",
                    Response = "",
                    ButtonText = "OK",
                },
                new ContentTemplateDto()
                {
                    Type = 1,
                    Display = "This is an Editor (2)",
                    Response = "A previous response",
                    ButtonText = "OK",
                },
            };

            EditorUnfocusedCommand = new Command(execute: () =>
            {
                //await EntryUnfocused(rfi);
            });
        }

        #region Properties       

        private ObservableCollection<ContentTemplateDto>? contentTemplates;
        public ObservableCollection<ContentTemplateDto>? ContentTemplates
        {
            get { return contentTemplates; }
            set { SetProperty(ref contentTemplates, value); }
        }

        #endregion

        #region Lifecycle

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async override Task Initialise()
        {
            Tracker.WriteLine();

            await base.Initialise();
        }

        /// <summary>
        /// 
        /// </summary>
        public async override void OnAppearing()
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
        private async Task Navigate(string page)
        {
            switch (page)
            {
                case "PageA":

                    await Shell.Current.GoToAsync($"{page}");

                    break;
                //case "PageWithFlyoutMenu_1":
                //    Shell.Current.FlyoutContent = IPlatformApplication.Current?.Services.GetService<FlyoutMenu>();

                //    await Shell.Current.GoToAsync($"///{page}", true);

                //    Shell.Current.FlyoutIsPresented = false;
                //    break;
                //case "Page2":

                //    await Shell.Current.GoToAsync($"///{page}", true);

                //    break;
                default:

                    await Shell.Current.GoToAsync($"{page}");

                    break;
            }
        }

        [RelayCommand]
        public async Task EditorUnfocusedRelay(ContentTemplateDto contentTemplate)
        {

        }

        [RelayCommand]
        public async Task ButtonSelected(ContentTemplateDto contentTemplate)
        {

        }

        #endregion
    }
}
