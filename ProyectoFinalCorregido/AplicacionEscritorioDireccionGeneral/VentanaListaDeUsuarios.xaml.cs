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
    /// Lógica de interacción para VentanaListaDeUsuarios.xaml
    /// </summary>
    public partial class VentanaListaDeUsuarios : Window
    {
        public VentanaListaDeUsuarios()
        {
            InitializeComponent();
        }



        private void btn_regresar_Click(object sender, RoutedEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void btn_registrarUsuario_Click(object sender, RoutedEventArgs e)
        {
            VentanaRegistrarUsuario registrarUsuario = new VentanaRegistrarUsuario();
            registrarUsuario.Show();
            this.Close();
        }

        private void btn_actualizarUsuarioClick(object sender, RoutedEventArgs e)
        {
            VentanaActualizarUsuario actualizarUsuario = new VentanaActualizarUsuario();
            actualizarUsuario.Show();
            this.Close();
        }

        private void SelectionChanged_cbDelegacion(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
