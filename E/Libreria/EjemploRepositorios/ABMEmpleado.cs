using CEntidades.Entidades;
using CLogica.Contracts;
using CLogica.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion
{
    public partial class ABMEmpleado : Form
    {
        private IEmpleadoLogic _empleadoLogic;
        private bool allowTabChange = false;
        public ABMEmpleado(IEmpleadoLogic empleadoLogic)
        {
            _empleadoLogic = empleadoLogic;
            InitializeComponent();
        }
        private void tabControlPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlPrincipal.SelectedIndex == 0)
            {
                CargarListadoEmpleados();
            }
        }
        private void ABMEmpleado_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
        }
        private void CargarListadoEmpleados()
        {
            List<dynamic> autors = _empleadoLogic.ObtenerEmpleadoParaListado();
            dgvListadoEmpleados.DataSource = autors;

            dgvListadoEmpleados.Columns["btnModificarColumna"].DisplayIndex = dgvListadoEmpleados.Columns.Count - 1;
            dgvListadoEmpleados.Columns["btnEliminarColumna"].DisplayIndex = dgvListadoEmpleados.Columns.Count - 1;
        }
        private void ConfigureDataGridView()
        {
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "btnEliminarColumna";
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Text = "Eliminar";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dgvListadoEmpleados.Columns.Add(deleteButtonColumn);

            DataGridViewButtonColumn modifyButtonColumn = new DataGridViewButtonColumn();
            modifyButtonColumn.Name = "btnModificarColumna";
            modifyButtonColumn.HeaderText = "";
            modifyButtonColumn.Text = "Modificar";
            modifyButtonColumn.UseColumnTextForButtonValue = true;
            dgvListadoEmpleados.Columns.Add(modifyButtonColumn);

            CargarListadoEmpleados();

            modifyButtonColumn.DisplayIndex = dgvListadoEmpleados.Columns.Count - 1;
            deleteButtonColumn.DisplayIndex = dgvListadoEmpleados.Columns.Count - 1;
        }

        private void dgvListadoEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListadoEmpleados.Columns["btnEliminarColumna"].Index && e.RowIndex >= 0)
            {
                string empleadoId = dgvListadoEmpleados.Rows[e.RowIndex].Cells["IdEmpleado"].Value.ToString();

                _empleadoLogic.BajaEmpleado(empleadoId);
                CargarListadoEmpleados();
            }

            if (e.ColumnIndex == dgvListadoEmpleados.Columns["btnModificarColumna"].Index && e.RowIndex >= 0)
            {
                string empleadoId = dgvListadoEmpleados.Rows[e.RowIndex].Cells["IdEmpleado"].Value.ToString();

                tbIdEmpleadoModificacion.Text = empleadoId;
                DatosUsuarioModificacion(empleadoId);
                allowTabChange = true;
                tabControlPrincipal.SelectedTab = tabModificacion;
            }
        }
        private void DatosUsuarioModificacion(string empleadoId)
        {
            Empleado? empleado = _empleadoLogic.ObtenerEmpleadoPorID(tbIdEmpleadoModificacion.Text);

            tbNombreModificacion.Text = empleado.PersonaEmpleado.Nombre;
            tbApellidoModificacion.Text = empleado.PersonaEmpleado.Apellido;
            tbNacionalidadModificacion.Text = empleado.PersonaEmpleado.Nacionalidad;
            tbEmailModificacion.Text = empleado.PersonaEmpleado.Email;
            tbTelefonoModificacion.Text = empleado.PersonaEmpleado.Telefono;
            tbCargoModificacion.Text = empleado.Cargo;
            tbSueldoModificacion.Text = empleado.Sueldo.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombreAlta.Text;
            string apellido = tbApellidoAlta.Text;
            string nacionalidad = tbNacionalidadAlta.Text;
            string email = tbEmailAlta.Text;
            double sueldo = double.Parse(tbSueldoAlta.Text);
            string telefono = tbTelefonoAlta.Text;
            string cargo = tbCargoAlta.Text;
            DateTime fechaIngreso = dtpFechaIngreso.Value;

            try
            {
                _empleadoLogic.AltaEmpleado(nombre, apellido, nacionalidad, cargo, sueldo, telefono, email, fechaIngreso);
                MessageBox.Show("El autor se ha registrado con éxito.");

                tbNombreAlta.Clear();
                tbApellidoAlta.Clear();
                tbNacionalidadAlta.Clear();
                tbEmailAlta.Clear();
                tbTelefonoAlta.Clear();
                tbCargoAlta.Clear();
                tbSueldoAlta.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            string idEmpleado = tbIdEmpleadoModificacion.Text;
            string nombre = tbNombreModificacion.Text;
            string apellido = tbApellidoModificacion.Text;
            string nacionalidad = tbNacionalidadModificacion.Text;
            string email = tbEmailModificacion.Text;
            string telefono = tbTelefonoModificacion.Text;
            string cargo = tbCargoModificacion.Text;
            double sueldo = double.Parse(tbSueldoModificacion.Text);

            try
            {
                _empleadoLogic.ActualizacionEmpleado(idEmpleado, nombre, apellido, nacionalidad, cargo, sueldo, telefono, email);
                MessageBox.Show("El autor se ha actualizado con éxito.");

                tbIdEmpleadoModificacion.Clear();
                tbNombreModificacion.Clear();
                tbApellidoModificacion.Clear();
                tbNacionalidadModificacion.Clear();
                tbEmailModificacion.Clear();
                tbSueldoModificacion.Clear();
                tbTelefonoModificacion.Clear();
                tbCargoModificacion.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            CargarListadoEmpleados();
        }

        private void tabControlPrincipal_Selecting_1(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabModificacion && !allowTabChange)
            {
                e.Cancel = true;
            }
            else
            {
                allowTabChange = false;
            }
        }
    }
}
