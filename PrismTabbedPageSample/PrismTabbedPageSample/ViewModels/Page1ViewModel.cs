using Module1.Views;
using Prism.Commands;
using Prism.Navigation;
using PrismTabbedPageSample.Views;
using Rg.Plugins.Popup.Contracts;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismTabbedPageSample.ViewModels
{
    public class Page1ViewModel
    {
        private DelegateCommand o;
        public DelegateCommand O =>
            o ?? (o = new DelegateCommand(ExecuteO));
        private readonly INavigationService navigationService1;
        private readonly IPopupNavigation popupNavigation;
        public Page1ViewModel(INavigationService navigationService,IPopupNavigation popupNavigation)
        {
            this.popupNavigation = popupNavigation;
            navigationService1 = navigationService;
        }
        async void ExecuteO()
        {
            await popupNavigation.PushAsync(new MPopup());
        }

        private DelegateCommand b;
        public DelegateCommand B =>
            b ?? (b = new DelegateCommand(ExecuteB));

        async void ExecuteB()
        {
            navigationService1.NavigateAsync(nameof(Page2));
        }
    }
}
