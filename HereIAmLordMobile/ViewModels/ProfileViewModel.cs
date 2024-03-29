﻿using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using HereIAmLordMobile.Models.User;
using HereIAmLordMobile.Services.Settings;
using HereIAmLordMobile.ViewModels.Base;
using Xamarin.Forms;

namespace HereIAmLordMobile.ViewModels
{
    public class ProfileViewModel : ViewModelBase
    {
        private readonly ISettingsService _settingsService;
        //private readonly IOrderService _orderService;
        //private ObservableCollection<Order> _orders;

        public ProfileViewModel(ISettingsService settingsService)//, IOrderService orderService)
        {
            _settingsService = settingsService;
            //_orderService = orderService;
        }

        //public ObservableCollection<Order> Orders
        //{
        //    get { return _orders; }
        //    set
        //    {
        //        _orders = value;
        //        RaisePropertyChanged(() => Orders);
        //    }
        //}

        public ICommand LogoutCommand => new Command(async () => await LogoutAsync());

        //public ICommand OrderDetailCommand => new Command<Order>(async (order) => await OrderDetailAsync(order));

        public override async Task InitializeAsync(object navigationData)
        {
            IsBusy = true;

            // Get orders
            var authToken = _settingsService.AuthAccessToken;
            //var orders = await _orderService.GetOrdersAsync(authToken);
            //Orders = orders.ToObservableCollection();

            IsBusy = false;
        }

        private Task LogoutAsync()
        {
            IsBusy = true;

            // Logout
            //await NavigationService.NavigateToAsync<LoginViewModel>(new LogoutParameter { Logout = true });
            //await NavigationService.RemoveBackStackAsync();

            IsBusy = false;
        }

        //private async Task OrderDetailAsync(Order order)
        //{
        //    await NavigationService.NavigateToAsync<OrderDetailViewModel>(order);
        //}
    }
}