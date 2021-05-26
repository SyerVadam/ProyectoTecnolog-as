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
    /// Lógica de interacción para DetalleReporte.xaml
    /// </summary>
    public partial class VentanaDetalleReporte : Window
    {
        public VentanaDetalleReporte()
        {
            InitializeComponent();
        }

        private void Btn_regresar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow reportes = new MainWindow();
            reportes.Show();
            this.Close();
        }
    }
}
