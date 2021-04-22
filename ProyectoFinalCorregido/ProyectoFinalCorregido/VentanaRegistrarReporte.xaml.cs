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
using System.Windows.Shapes;

namespace ProyectoFinalCorregido
{
    /// <summary>
    /// Lógica de interacción para VentanaRegistrarReporte.xaml
    /// </summary>
    public partial class VentanaRegistrarReporte : Window
    {
        public VentanaRegistrarReporte()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, RoutedEventArgs e)
        {
            VentanaReporte ventanaReporte = new VentanaReporte();
            ventanaReporte.Show();
            this.Close();
        }

        private void btn_cancelar_Click(object sender, RoutedEventArgs e)
        {
            VentanaReporte ventanaReporte = new VentanaReporte();
            ventanaReporte.Show();
            this.Close();
        }
    }
}
