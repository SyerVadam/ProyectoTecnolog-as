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
    /// Lógica de interacción para VentanaActualizarDelegacion.xaml
    /// </summary>
    public partial class VentanaActualizarDelegacion : Window
    {
        public VentanaActualizarDelegacion()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, RoutedEventArgs e)
        {
            VentanaListaDelegaciones listaDelegaciones = new VentanaListaDelegaciones();
            listaDelegaciones.Show();
            this.Close();
        }
    }
}
