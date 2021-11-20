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
using Entidades;
using Negocios;

namespace Presentacion
{
    /// <summary>
    /// Interaction logic for Clientes.xaml
    /// </summary>
    public partial class Clientes : Window
    {
        nCliente gcliente = new nCliente();
        eCliente clienteseleccionado = null;
        int idclien;
        int dniclien;
        public Clientes()
        {
            InitializeComponent();
            MostrarClientes();
        }
        private void MostrarClientes()
        {
            dgeCliente.ItemsSource = gcliente.ListarCliente();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {

            int dnic;
            string nomb;
            string apelli;
            string sexc;
            int telef;
            DateTime d;
            List<eCliente> lista;
            lista = gcliente.ListarCliente();
            dnic = Convert.ToInt32(txtdni.Text);
            nomb = txtnombre.Text;
            apelli = txtApellidos.Text;
            sexc = cbosexo.Text;
            telef = Convert.ToInt32(txttelefono.Text);
            d = (DateTime)dtpfecha.SelectedDate;
            if (!lista.Exists(delegate (eCliente value)
             {
                 return value.DNICliente == dniclien;
             }))
            {
                MessageBox.Show(gcliente.RegistrarCliente(dnic, nomb, apelli, sexc, telef, d));
                MostrarClientes();
            }
            else
                MessageBox.Show("El dni ya existe");
            txtdni.Clear();
            txtnombre.Clear();
            txtApellidos.Clear();
            cbosexo.SelectedIndex = -1;
            txttelefono.Clear();
            dtpfecha.SelectedDate = null;
            txtdni.Focus();
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            if (clienteseleccionado != null)
            {
                MessageBox.Show(gcliente.ModificarCliente(idclien, Convert.ToInt32(txtdni.Text), txtnombre.Text, txtApellidos.Text, cbosexo.Text, Convert.ToInt32(txttelefono.Text), Convert.ToDateTime(dtpfecha.Text)));
                MostrarClientes();
            }
            else
                MessageBox.Show("Debe seleccionar un cliente");
            txtdni.Clear();
            txtnombre.Clear();
            txtApellidos.Clear();
            cbosexo.SelectedIndex = -1;
            txttelefono.Clear();
            dtpfecha.SelectedDate = null;
            txtdni.Focus();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (clienteseleccionado != null)
            {
                MessageBox.Show(gcliente.EliminarCliente(idclien));
                MostrarClientes();
            }
            else
                MessageBox.Show("Por favor seleccione un cliente");
            txtdni.Clear();
            txtnombre.Clear();
            txtApellidos.Clear();
            cbosexo.SelectedIndex = -1;
            txttelefono.Clear();
            dtpfecha.SelectedDate = null;
            txtdni.Focus();
        }

        private void dgeCliente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            clienteseleccionado = dgeCliente.SelectedItem as eCliente;
            if(clienteseleccionado!=null)
            {
                idclien = clienteseleccionado.IdCliente;
                txtdni.Text = Convert.ToString(clienteseleccionado.DNICliente);
                txtnombre.Text = clienteseleccionado.NombreCliente;
                txtApellidos.Text = clienteseleccionado.ApellidoCliente;
                cbosexo.Text = clienteseleccionado.SexoCliente;
                txttelefono.Text=Convert.ToString(clienteseleccionado.TelefonoCliente);
                dtpfecha.Text = clienteseleccionado.EdadCliente;
            }
        }
    }
}
