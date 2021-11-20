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
    /// Interaction logic for Empleado.xaml
    /// </summary>
    public partial class Empleado : Window
    {
        nEmpleado gempleado = new nEmpleado();
        eEmpleado empleadoseleccionado = null;
        int idemp;
        string nombem;
        public Empleado()
        {
            InitializeComponent();
            MostrarEmpleados();
        }
        private void MostrarEmpleados()
        {
            dgeEmpleado.ItemsSource = gempleado.ListarEmpleado();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            string nomb;
            string apelli;
            string sexe;
            DateTime d,te;
            string cargoe;
            List<eEmpleado> lista;
            lista = gempleado.ListarEmpleado();
            nomb = txtNombre.Text;
            apelli = txtApellido.Text;
            sexe = cboSexo.Text;
            d = (DateTime)dtpFechaNaci.SelectedDate;
            te = (DateTime)dtpFechaIngreso.SelectedDate;
            cargoe = txtCargo.Text;
            
            if (!lista.Exists(delegate (eEmpleado value)
            {
                return value.NombreEmpleado == nombem;
            }))
            {
                MessageBox.Show(gempleado.RegistrarEmpleado(nomb, apelli, sexe, d, cargoe,te));
                MostrarEmpleados();
            }
            else
                MessageBox.Show("El empleado ya fue registrado");

            txtNombre.Clear();
            txtApellido.Clear();
            cboSexo.SelectedIndex=-1;
            dtpFechaNaci.SelectedDate = null;
            txtCargo.Clear();
            dtpFechaIngreso.SelectedDate = null;
            txtNombre.Focus();
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            
            if (empleadoseleccionado!=null)
            {
                MessageBox.Show(gempleado.ModificarEmpleado(idemp,txtNombre.Text,txtApellido.Text,cboSexo.Text, Convert.ToDateTime(dtpFechaNaci.Text),txtCargo.Text, Convert.ToDateTime(dtpFechaIngreso.Text)));
                MostrarEmpleados();
            }
            else
                MessageBox.Show("Debe seleccionar un empleado");

            txtNombre.Clear();
            txtApellido.Clear();
            cboSexo.SelectedIndex = -1;
            dtpFechaNaci.SelectedDate = null;
            txtCargo.Clear();
            dtpFechaIngreso.SelectedDate = null;
            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (empleadoseleccionado != null)
            {
                MessageBox.Show(gempleado.EliminarEmpleado(idemp));
                MostrarEmpleados();
            }
            else
                MessageBox.Show("Debe seleccionar un empleado");

            txtNombre.Clear();
            txtApellido.Clear();
            cboSexo.SelectedIndex = -1;
            dtpFechaNaci.SelectedDate = null;
            txtCargo.Clear();
            dtpFechaIngreso.SelectedDate = null;
            txtNombre.Focus();
        }

        private void dgeEmpleado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            empleadoseleccionado = dgeEmpleado.SelectedItem as eEmpleado;
            if(empleadoseleccionado!=null)
            {
                idemp = empleadoseleccionado.idempleado;
                txtNombre.Text = empleadoseleccionado.NombreEmpleado;
                txtApellido.Text = empleadoseleccionado.ApellidoEmpleado;
                cboSexo.Text = empleadoseleccionado.SexoEmpleado;
                dtpFechaNaci.Text = empleadoseleccionado.FechaNacEmpleado;
                txtCargo.Text = empleadoseleccionado.CargoEmpleado;
                dtpFechaIngreso.Text = empleadoseleccionado.FechaIngreso;
            }
        }
    }
}
