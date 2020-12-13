using Module1.ViewModels;
using Module1.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace Module1
{
    public class Module1Module : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MPage2, MPage2ViewModel>();
        }
    }
}
