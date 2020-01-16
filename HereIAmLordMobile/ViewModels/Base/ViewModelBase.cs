using System.Threading.Tasks;
using HereIAmLordMobile.Services.Dialog;
using HereIAmLordMobile.Services.Settings;


namespace HereIAmLordMobile.ViewModels.Base
{
    public abstract class ViewModelBase : ExtendedBindableObject
    {
        protected readonly IDialogService DialogService;
        
        private bool _isBusy;

        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }

            set
            {
                _isBusy = value;
                RaisePropertyChanged(() => IsBusy);
            }
        }

        public ViewModelBase()
        {
            DialogService = ViewModelLocator.Resolve<IDialogService>();
            

            var settingsService = ViewModelLocator.Resolve<ISettingsService>();

            GlobalSetting.Instance.BaseIdentityEndpoint = settingsService.IdentityEndpointBase;
            GlobalSetting.Instance.BaseGatewayShoppingEndpoint = settingsService.GatewayShoppingEndpointBase;
            GlobalSetting.Instance.BaseGatewayMarketingEndpoint = settingsService.GatewayMarketingEndpointBase;
        }

        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }
    }
}
