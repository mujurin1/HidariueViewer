using HidariueViewer.Models;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace HidariueViewer.Services.Interfaces
{
    public interface IHidariueService
    {
        ReadOnlyReactiveCollection<Hidariue> Hidariues { get; }
        ReactiveCommand<Hidariue> AddCommand { get; }
        ReactiveCommand ResetCommand { get; }
        //ReactiveCommand<Hidariue> UpdateCommand { get; }
        ReactiveCommand<Hidariue> DeleteCommand { get; }
    }
}
