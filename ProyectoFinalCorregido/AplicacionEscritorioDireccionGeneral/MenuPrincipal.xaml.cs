﻿using System;
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
    /// Lógica de interacción para MenuPrincipal.xaml
    /// </summary>
    public partial class MenuPrincipal : Window
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btn_cerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btn_chat_Click(object sender, RoutedEventArgs e)
        {
            VentanaChat ventanaChat = new VentanaChat();
            ventanaChat.Show();
            this.Close();
        }


        private void btn_reportes_Click(object sender, RoutedEventArgs e)
        {
            VentanaReportes reportes = new VentanaReportes();
            reportes.Show();
            this.Close();
        }

        private void btn_delegaciones_Click(object sender, RoutedEventArgs e)
        {
            VentanaListaDelegaciones listaDelegaciones = new VentanaListaDelegaciones();
            listaDelegaciones.Show();
            this.Close();
        }

        private void btn_usuarios_Click(object sender, RoutedEventArgs e)
        {
            VentanaListaDeUsuarios listaDeUsuarios = new VentanaListaDeUsuarios();
            listaDeUsuarios.Show();
            this.Close();
        }
    }
}
