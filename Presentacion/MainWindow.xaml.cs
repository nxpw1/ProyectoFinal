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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Entidades;
using Negocios;

namespace Presentacion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, RoutedEventArgs e)
        {
            Clientes a = new Clientes();
            a.Show();
        }

        private void btnProducto_Click(object sender, RoutedEventArgs e)
        {
            Productos a = new Productos();
            a.Show();
        }

        private void btnVenta_Click(object sender, RoutedEventArgs e)
        {
            Ventas a = new Ventas();
            a.Show();
        }

        private void btnEmpleado_Click(object sender, RoutedEventArgs e)
        {
            Empleados a = new Empleados();
            a.Show();
        }
    }
}
