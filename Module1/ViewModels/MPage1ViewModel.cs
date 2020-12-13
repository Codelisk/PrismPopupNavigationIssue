using Module1.Views;
using Prism.Commands;
using Prism.Navigation;
using Rg.Plugins.Popup.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1.ViewModels
{
    public class MPage1ViewModel
    {
        private DelegateCommand o;
        public DelegateCommand O =>
            o ?? (o = new DelegateCommand(ExecuteO));
        private readonly INavigationService navigationService1;
        private readonly IPopupNavigation popupNavigation;
        public MPage1ViewModel(INavigationService navigationService, IPopupNavigation popupNavigation)
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
            await navigationService1.NavigateAsync(nameof(MPage2));
        }
    }
}
