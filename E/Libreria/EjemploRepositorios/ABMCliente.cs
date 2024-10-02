using CEntidades.Entidades;
using CLogica.Contracts;
using System.Windows.Forms;

namespace CPresentacion
{
    public partial class ABMCliente : Form
    {

        private IClienteLogic _clienteLogic;
        private bool allowTabChange = false;

        public ABMCliente(IClienteLogic clienteLogic)
        {
            _clienteLogic = clienteLogic;
            InitializeComponent();
        }

        private void tabControlPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlPrincipal.SelectedIndex == 0)
            {
                CargarListadoClientes();
            }
        }

        private void ABMCliente_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
        }

        private void CargarListadoClientes()
        {
            List<dynamic> autors = _clienteLogic.ObtenerClientesParaListado();
            dgvListadoClientes.DataSource = autors;

            dgvListadoClientes.Columns["btnModificarColumna"].DisplayIndex = dgvListadoClientes.Columns.Count - 1;
            dgvListadoClientes.Columns["btnEliminarColumna"].DisplayIndex = dgvListadoClientes.Columns.Count - 1;
        }

        private void ConfigureDataGridView()
        {
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "btnEliminarColumna";
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Text = "Eliminar";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dgvListadoClientes.Columns.Add(deleteButtonColumn);

            DataGridViewButtonColumn modifyButtonColumn = new DataGridViewButtonColumn();
            modifyButtonColumn.Name = "btnModificarColumna";
            modifyButtonColumn.HeaderText = "";
            modifyButtonColumn.Text = "Modificar";
            modifyButtonColumn.UseColumnTextForButtonValue = true;
            dgvListadoClientes.Columns.Add(modifyButtonColumn);

            CargarListadoClientes();

            modifyButtonColumn.DisplayIndex = dgvListadoClientes.Columns.Count - 1;
            deleteButtonColumn.DisplayIndex = dgvListadoClientes.Columns.Count - 1;
        }

        private void dgvListadoAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListadoClientes.Columns["btnEliminarColumna"].Index && e.RowIndex >= 0)
            {
                string autorId = dgvListadoClientes.Rows[e.RowIndex].Cells["IdCliente"].Value.ToString();

                _clienteLogic.BajaCliente(autorId);
                CargarListadoClientes();
            }

            if (e.ColumnIndex == dgvListadoClientes.Columns["btnModificarColumna"].Index && e.RowIndex >= 0)
            {
                string numeroDocumento = dgvListadoClientes.Rows[e.RowIndex].Cells["NumeroDocumento"].Value.ToString();

                tbNroDocumentoModificacion.Text = numeroDocumento;
                DatosUsuarioModificacion(numeroDocumento);
                allowTabChange = true;
                tabControlPrincipal.SelectedTab = tabModificacion;
            }
        }

        private void DatosUsuarioModificacion(string autorId)
        {
            Cliente? cliente = _clienteLogic.ObtenerClientePorDocumento(tbNroDocumentoModificacion.Text);

            tbTipoDocumentoModificacion.Text = cliente.PersonaCliente.TipoDocumento;
            tbNombreModificacion.Text = cliente.PersonaCliente.Nombre;
            tbApellidoModificacion.Text = cliente.PersonaCliente.Apellido;
            tbNacionalidadModificacion.Text = cliente.PersonaCliente.Nacionalidad;
            tbEmailModificacion.Text = cliente.PersonaCliente.Email;
            tbTelefonoModificacion.Text = cliente.PersonaCliente.Telefono;
            cbEsSocioModificacion.Text = cliente.EsSocio ? "Si" : "No";
            cbPagaIVAModificacion.Text = cliente.PagaIVA ? "Si" : "No";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string tipoDocumento = tbTipoDocumentoAlta.Text;
            string nroDocumento = tbNroDocumentoAlta.Text;
            string nombre = tbNombreAlta.Text;
            string apellido = tbApellidoAlta.Text;
            string nacionalidad = tbNacionalidadAlta.Text;
            string email = tbEmailAlta.Text;
            string telefono = tbTelefonoAlta.Text;
            string esSocio = cbEsSocioAlta.Text;
            string pagaIVA = cbPagaIVAAlta.Text;

            try
            {
                _clienteLogic.AltaCliente(tipoDocumento, nroDocumento, nombre, apellido, nacionalidad, email, telefono, esSocio, pagaIVA);
                MessageBox.Show("El cliente se ha registrado con éxito.");

                tbTipoDocumentoAlta.Clear();
                tbNroDocumentoAlta.Clear();
                tbNombreAlta.Clear();
                tbApellidoAlta.Clear();
                tbNacionalidadAlta.Clear();
                tbEmailAlta.Clear();
                tbTelefonoAlta.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string tipoDocumento = tbTipoDocumentoModificacion.Text;
            string nroDocumento = tbNroDocumentoModificacion.Text;
            string nombre = tbNombreModificacion.Text;
            string apellido = tbApellidoModificacion.Text;
            string nacionalidad = tbNacionalidadModificacion.Text;
            string email = tbEmailModificacion.Text;
            string telefono = tbTelefonoModificacion.Text;
            string esSocio = cbEsSocioModificacion.Text;
            string pagaIVA = cbPagaIVAModificacion.Text;

            try
            {
                _clienteLogic.ActualizacionCliente(tipoDocumento, nroDocumento, nombre, apellido, nacionalidad, email, telefono, esSocio, pagaIVA);
                MessageBox.Show("El cliente se ha actualizado con éxito.");

                tbTipoDocumentoModificacion.Clear();
                tbNroDocumentoModificacion.Clear();
                tbNombreModificacion.Clear();
                tbApellidoModificacion.Clear();
                tbNacionalidadModificacion.Clear();
                tbEmailModificacion.Clear();
                tbTelefonoModificacion.Clear();

                tabControlPrincipal.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bnRecargarAlta_Click(object sender, EventArgs e)
        {
            CargarListadoClientes();
        }

        private void tabControlPrincipal_Selecting(object sender, TabControlCancelEventArgs e)
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
