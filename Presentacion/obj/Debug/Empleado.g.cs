﻿#pragma checksum "..\..\Empleado.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8887D96E30E9F56C34810B4298EB1A95E832A993B21DCB1E61E448C48F82E78D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Presentacion;
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


namespace Presentacion {
    
    
    /// <summary>
    /// Empleado
    /// </summary>
    public partial class Empleado : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\Empleado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombre;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Empleado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtApellido;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Empleado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboSexo;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Empleado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtpFechaNaci;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Empleado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCargo;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Empleado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgeEmpleado;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Empleado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRegistrar;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Empleado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnModificar;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Empleado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminar;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Empleado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtpFechaIngreso;
        
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
            System.Uri resourceLocater = new System.Uri("/Presentacion;component/empleado.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Empleado.xaml"
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
            this.txtNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtApellido = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.cboSexo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.dtpFechaNaci = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.txtCargo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.dgeEmpleado = ((System.Windows.Controls.DataGrid)(target));
            
            #line 23 "..\..\Empleado.xaml"
            this.dgeEmpleado.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgeEmpleado_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnRegistrar = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\Empleado.xaml"
            this.btnRegistrar.Click += new System.Windows.RoutedEventHandler(this.btnRegistrar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnModificar = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\Empleado.xaml"
            this.btnModificar.Click += new System.Windows.RoutedEventHandler(this.btnModificar_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnEliminar = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\Empleado.xaml"
            this.btnEliminar.Click += new System.Windows.RoutedEventHandler(this.btnEliminar_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.dtpFechaIngreso = ((System.Windows.Controls.DatePicker)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
