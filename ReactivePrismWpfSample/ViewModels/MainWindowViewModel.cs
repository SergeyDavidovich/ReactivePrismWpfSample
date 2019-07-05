using Prism.Regions;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ReactivePrismWpfSample.ViewModels
{
    public class MainWindowViewModel : ReactiveObject, INavigationAware
    {
        private readonly IRegionManager _regionManager;
        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            NavigateToViewACommand = ReactiveCommand.Create(() => 
            regionManager.RequestNavigate("ContentRegion", "ViewA"));
            NavigateToViewBCommand = ReactiveCommand.Create(() => regionManager.RequestNavigate("ContentRegion", "ViewB"));
        }
        public ReactiveCommand<Unit,Unit> NavigateToViewACommand { get; set; }
        public ReactiveCommand<Unit,Unit> NavigateToViewBCommand { get; set; }

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
