using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Teht03
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void laske_Click(object sender, RoutedEventArgs e)
        {
            double korkeus; double leveys; double karmi;
            double value1 = double.Parse(KorkeusTeksti.Text);
            korkeus = value1;

            double value2 = double.Parse(LeveysTeksti.Text);
            leveys = value2;

            double value3 = double.Parse(KarminleveysTeksti.Text);
            karmi = value3;

            double lasipa = korkeus * leveys;
            double ikkunapa = (karmi + korkeus) * (leveys + karmi);
            double piiri = (karmi * 2 + leveys + korkeus) * 2;

            Ikkunanala.Text = ikkunapa.ToString("0.00");
            Lasinala.Text = lasipa.ToString("0.00");
            Karminpiiri.Text = piiri.ToString("0.00");
        }
    }
}
