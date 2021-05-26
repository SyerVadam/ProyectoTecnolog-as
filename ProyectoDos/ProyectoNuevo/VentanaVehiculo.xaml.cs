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

namespace ProyectoNuevo
{
    /// <summary>
    /// Lógica de interacción para VentanaVehiculo.xaml
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

        private void Btn_eliminar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_detalle_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Conductor: \nPlacas: \nModelo: \nMarca: \nAño: \nColor: \nPoliza de seguro: \nAseguradora: ", 
                "Detalles del vehículo");
        }

        private void Btn_modificar_Click(object sender, RoutedEventArgs e)
        {
            mostrarVentana();
        }

        private void Btn_agregar_Click(object sender, RoutedEventArgs e)
        {
            mostrarVentana();
        }

        private void mostrarVentana()
        {
            VentanaRegistroVehiculo registroVehiculo = new VentanaRegistroVehiculo();
            registroVehiculo.Show();
            this.Close();
        }
    }
}
