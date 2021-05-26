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
    /// Lógica de interacción para VentanaDictamen.xaml
    /// </summary>
    public partial class VentanaDictamen : Window
    {
        public VentanaDictamen()
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
            MainWindow reportes = new MainWindow();
            reportes.Show();
            this.Close();
        }
    }
}
