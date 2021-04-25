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
    /// Lógica de interacción para VentanaConductores.xaml
    /// </summary>
    public partial class VentanaConductores : Window
    {
        public VentanaConductores()
        {
            InitializeComponent();
        }

        private void btn_regresar_Click(object sender, RoutedEventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Close();
        }

        private void btn_agregar_Click(object sender, RoutedEventArgs e)
        {
            VentanaRegistroConductor ventanaRegistroConductor = new VentanaRegistroConductor();
            ventanaRegistroConductor.Show();
            this.Close();
        }

        private void btn_modificar_Click(object sender, RoutedEventArgs e)
        {
            VentanaRegistroConductor ventanaRegistroConductor = new VentanaRegistroConductor();
            ventanaRegistroConductor.Show();
            this.Close();
        }

        private void btn_eliminar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_detalles_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Nombre: \nFecha Nacimiento: \nNo. Licencia: \nTel. Celular: ","Detalles del conductor");
        }
    }
}
