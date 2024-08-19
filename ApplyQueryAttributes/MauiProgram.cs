using ApplyQueryAttributes.Helpers.FontAwesome;
using ApplyQueryAttributes.ViewModels;
using ApplyQueryAttributes.ViewModels.Flyout;
using ApplyQueryAttributes.ViewModels.Flyout.DetailPages;
using ApplyQueryAttributes.Views;
using ApplyQueryAttributes.Views.Flyout.DetailPages;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;





#if __ANDROID__
#endif

#if __IOS__
#endif

namespace ApplyQueryAttributes
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFontAwesomeIconFonts();
                });

            #region Pages/ViewModels

            builder.Services.AddSingleton<AppShell>();
            builder.Services.AddSingleton<AppShellViewModel>();

            builder.Services.AddSingleton<LoadingPage>();
            builder.Services.AddSingleton<LoadingPageViewModel>();

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainPageViewModel>();

            builder.Services.AddSingleton<PageA>();
            builder.Services.AddSingleton<PageAViewModel>();

            builder.Services.AddSingleton<PageB>();
            builder.Services.AddSingleton<PageBViewModel>();

            builder.Services.AddSingleton<FlyoutMenu>();
            builder.Services.AddSingleton<FlyoutMenuViewModel>();

            builder.Services.AddSingleton<PageWithFlyoutMenu_1>();
            builder.Services.AddSingleton<PageWithFlyoutMenu_1ViewModel>();

            builder.Services.AddSingleton<PageWithFlyoutMenu_2>();
            builder.Services.AddSingleton<PageWithFlyoutMenu_2ViewModel>();

            #endregion

#if __ANDROID__
#elif __IOS__
#endif

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
