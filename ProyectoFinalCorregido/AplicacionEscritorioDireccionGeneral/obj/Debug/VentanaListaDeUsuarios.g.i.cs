<<<<<<< HEAD
﻿#pragma checksum "..\..\VentanaListaDeUsuarios.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FE816BAC7E782350960961DB11B9B08A351F846D8FE3C90C8B67034B15B96C84"
=======
// Updated by XamlIntelliSenseFileGenerator 25/04/2021 09:12:30 p. m.
#pragma checksum "..\..\VentanaListaDeUsuarios.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1F1F5B639F26B9C10DBC8F6670DB2379FBC8E3CC6EC612AE45E493423F3428F6"
>>>>>>> parent of 130d3fa (Final)
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using AplicacionEscritorioDireccionGeneral;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace AplicacionEscritorioDireccionGeneral
{


    /// <summary>
    /// VentanaListaDeUsuarios
    /// </summary>
<<<<<<< HEAD
    public partial class VentanaListaDeUsuarios : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\VentanaListaDeUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_actualizarUsuario;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\VentanaListaDeUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_registrarUsuario;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\VentanaListaDeUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_eliminarUsuario;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\VentanaListaDeUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_regresar;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\VentanaListaDeUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbDelegacion;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\VentanaListaDeUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgUsuario;
        
        #line default
        #line hidden
        
=======
    public partial class VentanaListaDeUsuarios : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

>>>>>>> parent of 130d3fa (Final)
        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AplicacionEscritorioDireccionGeneral;component/ventanalistadeusuarios.xaml", System.UriKind.Relative);

#line 1 "..\..\VentanaListaDeUsuarios.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
<<<<<<< HEAD
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btn_actualizarUsuario = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\VentanaListaDeUsuarios.xaml"
            this.btn_actualizarUsuario.Click += new System.Windows.RoutedEventHandler(this.btn_actualizarUsuarioClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_registrarUsuario = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\VentanaListaDeUsuarios.xaml"
            this.btn_registrarUsuario.Click += new System.Windows.RoutedEventHandler(this.btn_registrarUsuario_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_eliminarUsuario = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.btn_regresar = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\VentanaListaDeUsuarios.xaml"
            this.btn_regresar.Click += new System.Windows.RoutedEventHandler(this.btn_regresar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cbDelegacion = ((System.Windows.Controls.ComboBox)(target));
            
            #line 14 "..\..\VentanaListaDeUsuarios.xaml"
            this.cbDelegacion.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectionChanged_cbDelegacion);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dgUsuario = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
=======
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
>>>>>>> parent of 130d3fa (Final)
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button btn_actualizarUsuario;
        internal System.Windows.Controls.Button btn_registrarUsuario;
        internal System.Windows.Controls.Button btn_eliminarUsuario;
        internal System.Windows.Controls.Button btn_regresar;
    }
}

