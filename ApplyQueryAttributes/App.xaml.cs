using ApplyQueryAttributes.ViewModels;

namespace ApplyQueryAttributes
{
    public partial class App : Application
    {
        public App(MainPageViewModel mainPageViewModel)
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected async override void OnStart()
        {

        }
    }
}
