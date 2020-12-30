using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using System.Diagnostics;
using Reactive.Bindings;

namespace HidariueViewer.Models
{
    public class Hidariue
    {
        private static readonly string HidariueUrl =
            @"https://nicovideo.cdn.nimg.jp/web/img/base/head/icon/nico/{0:000}.gif";

        public int Number { get; }
        public BitmapImage Gif { get; }
        public ReactiveCommand ButtonCommand { get; }

        private static readonly List<Hidariue> hidariues = new();

        private Hidariue(int number)
        {
            this.Number = number;
            this.Gif = new BitmapImage(
                new Uri(string.Format(HidariueUrl, number)));
            this.ButtonCommand = new ReactiveCommand();
            ButtonCommand.Subscribe(_ => { });
        }

        public static Hidariue Generate(int number)
        {
            if (hidariues.FirstOrDefault(x => x.Number == number) is Hidariue h and not null)
                return h;
            return new Hidariue(number);
        }
    }
}
