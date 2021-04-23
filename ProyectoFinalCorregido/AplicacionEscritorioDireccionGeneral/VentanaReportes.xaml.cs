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

namespace AplicacionEscritorioDireccionGeneral
{
    /// <summary>
    /// Lógica de interacción para VentanaReportes.xaml
    /// </summary>
    public partial class VentanaReportes : Window
    {
        public VentanaReportes()
        {
            InitializeComponent();
        }

        private void Btn_regresar_Click(object sender, RoutedEventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Close();
        }

        private void Btn_detalle_Click(object sender, RoutedEventArgs e)
        {
            VentanaDetalleReporte detalle = new VentanaDetalleReporte();
            detalle.Show();
            this.Close();
        }

        private void Btn_modificar_Click(object sender, RoutedEventArgs e)
        {
            mostrarVentana();
        }

        private void Btn_dictaminar_Click(object sender, RoutedEventArgs e)
        {
            mostrarVentana();
        }

        private void mostrarVentana()
        {
            VentanaDictamen dictamen = new VentanaDictamen();
            dictamen.Show();
            this.Close();
        }
    }
}
