using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Views.InputMethods;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace ApplyQueryAttributes
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize |
        ConfigChanges.Orientation |
        ConfigChanges.UiMode |
        ConfigChanges.ScreenLayout |
        ConfigChanges.SmallestScreenSize |
        ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            AppCompatDelegate.DefaultNightMode = AppCompatDelegate.ModeNightNo;

            base.OnCreate(savedInstanceState);

            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
            TaskScheduler.UnobservedTaskException += TaskSchedulerOnUnobservedTaskException;
        }

        #region Lifecycle

        /// <summary>
        /// 
        /// </summary>
        protected override void OnStart()
        {
            base.OnStart();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override async void OnResume()
        {
            base.OnResume();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override void OnPause()
        {
            base.OnPause();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override void OnStop()
        {
            base.OnStop();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override void OnRestart()
        {
            base.OnRestart();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override void OnDestroy()
        {
            base.OnDestroy();
        }

        #endregion

        /// <summary>
        /// For Editor not unfocusing on click outside control
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public override bool DispatchTouchEvent(MotionEvent? e)
        {
            if (e!.Action == MotionEventActions.Down)
            {
                var focusedElement = CurrentFocus;

                if (focusedElement is EditText editText)
                {
                    var editTextLocation = new int[2];

                    editText.GetLocationOnScreen(editTextLocation);

                    var clearTextButtonWidth = 100;

                    var editTextRect = new Rect(editTextLocation[0], editTextLocation[1], editText.Width + clearTextButtonWidth, editText.Height);

                    var touchPosX = (int)e.RawX;

                    var touchPosY = (int)e.RawY;

                    if (!editTextRect.Contains(touchPosX, touchPosY))
                    {
                        editText.ClearFocus();

                        var inputService = GetSystemService(Context.InputMethodService) as InputMethodManager;

                        inputService?.HideSoftInputFromWindow(editText.WindowToken, 0);
                    }
                }
            }

            return base.DispatchTouchEvent(e);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Android.Content.PM.Permission[] grantResults)
        {
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        #region Exceptions

        private static void TaskSchedulerOnUnobservedTaskException(object? sender, UnobservedTaskExceptionEventArgs unobservedTaskExceptionEventArgs)
        {
            var exception = new Exception("TaskSchedulerOnUnobservedTaskException", unobservedTaskExceptionEventArgs.Exception);

            LogUnhandledException(exception, "TaskSchedulerOnUnobservedTaskException");
        }

        private static void CurrentDomainOnUnhandledException(object? sender, UnhandledExceptionEventArgs unhandledExceptionEventArgs)
        {
            var exception = unhandledExceptionEventArgs.ExceptionObject as Exception;

            LogUnhandledException(exception, "CurrentDomainOnUnhandledException");
        }

        internal static void LogUnhandledException(Exception ex, string source)
        {

        }

        #endregion
    }
}
