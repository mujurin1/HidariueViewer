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

namespace HidariueViewer.Modules.Header.ViewModels
{
    class PackViewModel : RegionViewModelBase
    {
        public ReactivePropertySlim<int> Number { get; }
        public ReactiveCommand AddCommand { get; }
        private bool isHoge = false;

        public PackViewModel(IRegionManager regionManager, IHidariueService hidariueService) :
            base(regionManager)
        {
            this.Number = new ReactivePropertySlim<int>(0);
            this.AddCommand = new ReactiveCommand();
            AddCommand.Subscribe(_ =>
            {
                var hidariue = RandomHidariue();
                hidariueService.AddCommand.Execute(hidariue);
            });
        }

        private Hidariue RandomHidariue()
        {
            var rnd = new Random();
            return Hidariue.Generate(rnd.Next(999));
        }
    }
}
