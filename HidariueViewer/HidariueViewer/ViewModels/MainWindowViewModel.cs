using Prism.Mvvm;
using Reactive.Bindings;

namespace HidariueViewer.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public ReactivePropertySlim<string> Title { get; }

        public MainWindowViewModel()
        {
            this.Title = new ReactivePropertySlim<string>("たいとる");
        }
    }
}
