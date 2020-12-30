using HidariueViewer.Core.Mvvm;
using HidariueViewer.Models;
using HidariueViewer.Services.Interfaces;
using Prism.Regions;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidariueViewer.Modules.Viewer.ViewModels
{
    class PackViewModel : RegionViewModelBase
    {
        public ReadOnlyReactiveCollection<Hidariue> Items { get; }

        public PackViewModel(IRegionManager regionManager, IHidariueService hidariueService) :
            base(regionManager)
        {
            this.Items = hidariueService.Hidariues;
        }
    }
}
