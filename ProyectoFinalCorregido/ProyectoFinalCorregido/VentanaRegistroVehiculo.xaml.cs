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
    /// Lógica de interacción para VentanaRegistroVehiculo.xaml
    /// </summary>
    public partial class VentanaRegistroVehiculo : Window
    {
        public VentanaRegistroVehiculo()
        {
            InitializeComponent();
        }
        private void Btn_cancelar_Click(object sender, RoutedEventArgs e)
        {
            mostrarVentana();
        }

        private void Btn_guardar_Click(object sender, RoutedEventArgs e)
        {
            mostrarVentana();
        }

        private void mostrarVentana()
        {
            VentanaVehiculos vehiculo = new VentanaVehiculos();
            vehiculo.Show();
            this.Close();
        }
    }
}
