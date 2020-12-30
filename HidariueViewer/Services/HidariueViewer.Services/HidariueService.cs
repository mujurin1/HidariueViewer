using HidariueViewer.Models;
using HidariueViewer.Services.Interfaces;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace HidariueViewer.Services
{
    public class HidariueService : IHidariueService
    {
        public ReadOnlyReactiveCollection<Hidariue> Hidariues { get; }
        public ReactiveCommand<Hidariue> AddCommand { get; }
        public ReactiveCommand ResetCommand { get; }
        //public ReactiveCommand<Hidariue> UpdateCommand { get; }
        public ReactiveCommand<Hidariue> DeleteCommand { get; }

        public HidariueService()
        {
            this.AddCommand = new ReactiveCommand<Hidariue>();
            this.ResetCommand = new ReactiveCommand();
            //this.AddCommand = new ReactiveCommand<Hidariue>();
            this.DeleteCommand = new ReactiveCommand<Hidariue>();
            this.Hidariues = Observable.Merge(
                this.AddCommand
                    .Select(h => CollectionChanged<Hidariue>.Add(0, h)),
                this.ResetCommand
                    .Select(_ => CollectionChanged<Hidariue>.Reset),
                //this.UpdateCommand
                //    .Select(h => CollectionChanged<Hidariue>.Replace(Hidariues.IndexOf(h), h)),
                this.DeleteCommand
                    .Select(h => CollectionChanged<Hidariue>.Remove(Hidariues.IndexOf(h), h))
                ).ToReadOnlyReactiveCollection<Hidariue>();
        }
    }
}
