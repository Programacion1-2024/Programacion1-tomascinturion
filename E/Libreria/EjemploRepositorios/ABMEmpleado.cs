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
            tbSueldoModificacion.Text = empleado.PersonaEmpleado.Telefono;
            tbCargoModificacion.Text = empleado.Cargo;
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
        }
    }
}
