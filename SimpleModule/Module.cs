using Prism.Ioc;
using Prism.Modularity;
using SimpleModule.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleModule
{
    public class Module : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation(typeof(ViewA), "ViewA");
            containerRegistry.RegisterForNavigation(typeof(ViewB), "ViewB");
            containerRegistry.RegisterForNavigation(typeof(ViewAC), "ViewAC");
            containerRegistry.RegisterForNavigation(typeof(ViewAD), "ViewAD");

        }
    }
}
