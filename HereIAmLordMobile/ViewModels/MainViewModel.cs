﻿using HereIAmLordMobile.Models.Navigation;
using HereIAmLordMobile.ViewModels.Base;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


namespace HereIAmLordMobile.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand SettingsCommand => new Command(async () => await SettingsAsync());

        public override Task InitializeAsync(object navigationData)
        {
            IsBusy = true;

            //if (navigationData is TabParameter)
            //{
            //    // Change selected application tab
            //    var tabIndex = ((TabParameter)navigationData).TabIndex;
            //    MessagingCenter.Send(this, MessageKeys.ChangeTab, tabIndex);
            //}

            return base.InitializeAsync(navigationData);
        }

        private async Task SettingsAsync()
        {
            await NavigationService.NavigateToAsync<SettingsViewModel>();
        }

    }
}
