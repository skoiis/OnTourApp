﻿#pragma checksum "..\..\MenuAdmin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10DD64964FAAF9F69B9E6AD91B670DF61C51EAE1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.IconPacks;
using OnTourApp;
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


namespace OnTourApp {
    
    
    /// <summary>
    /// MenuAdmin
    /// </summary>
    public partial class MenuAdmin : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\MenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile btnGestionUsuarios;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\MenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile btnGestionContrato;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\MenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile btnGestionTours;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile btnConsultarAporte;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\MenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile btnGestionSeguro;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\MenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile btnGenerarInforme;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/OnTourApp;component/menuadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MenuAdmin.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnGestionUsuarios = ((MahApps.Metro.Controls.Tile)(target));
            
            #line 34 "..\..\MenuAdmin.xaml"
            this.btnGestionUsuarios.Click += new System.Windows.RoutedEventHandler(this.BtnGestionUsuarios_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnGestionContrato = ((MahApps.Metro.Controls.Tile)(target));
            
            #line 38 "..\..\MenuAdmin.xaml"
            this.btnGestionContrato.Click += new System.Windows.RoutedEventHandler(this.BtnGestionContrato_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnGestionTours = ((MahApps.Metro.Controls.Tile)(target));
            return;
            case 4:
            this.btnConsultarAporte = ((MahApps.Metro.Controls.Tile)(target));
            return;
            case 5:
            this.btnGestionSeguro = ((MahApps.Metro.Controls.Tile)(target));
            return;
            case 6:
            this.btnGenerarInforme = ((MahApps.Metro.Controls.Tile)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

