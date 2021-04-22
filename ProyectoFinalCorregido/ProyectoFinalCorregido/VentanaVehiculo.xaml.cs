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

namespace SistemaGestionReportes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class VentanaVehiculo : Window
    {
        public VentanaVehiculo()
        {
            InitializeComponent();
        }

        private void Btn_regresar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_registrar_Click(object sender, RoutedEventArgs e)
        {
            VentanaRegistroVehiculo ventanaRegistroVehiculo = new VentanaRegistroVehiculo();
            ventanaRegistroVehiculo.Show();
            this.Close();
        }

        private void Btn_modificar_Click(object sender, RoutedEventArgs e)
        {
            VentanaRegistroVehiculo ventanaRegistroVehiculo = new VentanaRegistroVehiculo();
            ventanaRegistroVehiculo.Show();
            this.Close();
        }

        private void Btn_eliminar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
