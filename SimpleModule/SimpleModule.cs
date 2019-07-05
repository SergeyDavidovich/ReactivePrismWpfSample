using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using SimpleModule.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleModule
{
    public class SimpleModule : IModule
    {
        private IRegionManager _regionManager;
        public SimpleModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>();
            containerRegistry.RegisterForNavigation<ViewB>();
            containerRegistry.RegisterForNavigation<ViewAC>();
            containerRegistry.RegisterForNavigation<ViewAD>();
            _regionManager.RequestNavigate("ContentRegion", "ViewB");
            _regionManager.RequestNavigate("ViewAInnerRegion", "ViewAC");
        }
    }
}
