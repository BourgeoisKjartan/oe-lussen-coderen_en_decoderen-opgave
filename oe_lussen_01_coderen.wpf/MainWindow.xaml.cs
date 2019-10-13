using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace oe_lussen_01_coderen.wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCodeer_Click(object sender, RoutedEventArgs e)
        {
            txtOnder.Text = Codeer(txtBoven.Text);
        }

        private void BtnDecodeer_Click(object sender, RoutedEventArgs e)
        {
            txtBoven.Text = Decodeer(txtOnder.Text);
        }
        string Codeer(string bron)
        {
            // hier komt de code
            return "retourneer de eenvoudig gecodeerde tekst hier";
        }
        string Decodeer(string bron)
        {
            // hier komt de code
            return "retourneer de eenvoudig gedecodeerde tekst hier";
        }

        private void BtnCodeerComplexer_Click(object sender, RoutedEventArgs e)
        {
            txtOnder.Text = CodeerComplexer(txtBoven.Text,"mijnSleutel");
        }

        private void BtnDecodeerComplexer_Click(object sender, RoutedEventArgs e)
        {
            txtBoven.Text = DecodeerComplexer(txtOnder.Text,"mijnSleutel");

        }
        string CodeerComplexer(string bron, string sleutel)
        {
            // hier komt de code
            return "retourneer de complexere gecodeerde tekst hier";
        }

        string DecodeerComplexer(string bron, string sleutel)
        {
            // hier komt de code
            return "retourneer de complexere gedecodeerde tekst hier";

        }

    }
}

