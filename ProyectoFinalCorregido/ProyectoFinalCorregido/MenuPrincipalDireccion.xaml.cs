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
    /// Lógica de interacción para MenuPrincipalDireccion.xaml
    /// </summary>
    public partial class MenuPrincipalDireccion : Window
    {
        public MenuPrincipalDireccion()
        {
            InitializeComponent();
        }

        private void btn_chat_Click(object sender, RoutedEventArgs e)
        {
            VentanaChat ventanaChat = new VentanaChat();
            ventanaChat.Show();
            this.Close();
        }

        private void btn_cerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
