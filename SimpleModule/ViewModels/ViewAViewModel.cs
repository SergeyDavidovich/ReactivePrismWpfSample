using Prism.Regions;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleModule.ViewModels
{
    public class ViewAViewModel : ReactiveObject, INavigationAware
    {
        private IRegionManager _regionManager;
        public ViewAViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
        }
    }
}
