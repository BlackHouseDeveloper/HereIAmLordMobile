using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading.Tasks;
using HereIAmLordMobile.Services.Settings;
using HereIAmLordMobile.ViewModels.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HereIAmLordMobile
{
    public partial class App : Application
    {
        public static string BaseImageUrl { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/";
        ISettingsService _settingsService;

        public App()
        {
            InitializeComponent();

            InitApp();

            
        }

        private void InitApp()
        {
            _settingsService = ViewModelLocator.Resolve<ISettingsService>();
            if (!_settingsService.UseMocks)
                ViewModelLocator.UpdateDependencies(_settingsService.UseMocks);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
