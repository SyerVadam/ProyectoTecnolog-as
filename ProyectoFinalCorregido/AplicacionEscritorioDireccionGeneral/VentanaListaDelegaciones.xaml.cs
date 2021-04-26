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
    /// Lógica de interacción para VentanaListaDelegaciones.xaml
    /// </summary>
    public partial class VentanaListaDelegaciones : Window
    {
        public VentanaListaDelegaciones()
        {
            InitializeComponent();
        }

        private void btn_regresar_Click(object sender, RoutedEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void btn_registrar_Click(object sender, RoutedEventArgs e)
        {
            VentanaRegistrarDelegacion registrarDelegacion = new VentanaRegistrarDelegacion();
            registrarDelegacion.Show();
            this.Close();
        }

        private void btn_actualizar_Click(object sender, RoutedEventArgs e)
        {
            VentanaActualizarDelegacion actualizarDelegacion = new VentanaActualizarDelegacion();
            actualizarDelegacion.Show();
            this.Close();
        }
    }
}
