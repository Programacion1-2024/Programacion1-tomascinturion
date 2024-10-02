using CEntidades.Entidades;
using CLogica.Contracts;
using System.Windows.Forms;

namespace CPresentacion
{
    public partial class ABMAutor : Form
    {

        private IAutorLogic _autorLogic;
        private bool allowTabChange = false;

        public ABMAutor(IAutorLogic autorLogic)
        {
            _autorLogic = autorLogic;
            InitializeComponent();
        }

        private void tabControlPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlPrincipal.SelectedIndex == 0)
            {
                CargarListadoAutores();
            }
        }

        private void ABMAutor_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
        }

        private void CargarListadoAutores()
        {
            List<dynamic> autors = _autorLogic.ObtenerAutoresParaListado();
            dgvListadoAutores.DataSource = autors;

            dgvListadoAutores.Columns["btnModificarColumna"].DisplayIndex = dgvListadoAutores.Columns.Count - 1;
            dgvListadoAutores.Columns["btnEliminarColumna"].DisplayIndex = dgvListadoAutores.Columns.Count - 1;
        }

        private void ConfigureDataGridView()
        {
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "btnEliminarColumna";
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Text = "Eliminar";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dgvListadoAutores.Columns.Add(deleteButtonColumn);

            DataGridViewButtonColumn modifyButtonColumn = new DataGridViewButtonColumn();
            modifyButtonColumn.Name = "btnModificarColumna";
            modifyButtonColumn.HeaderText = "";
            modifyButtonColumn.Text = "Modificar";
            modifyButtonColumn.UseColumnTextForButtonValue = true;
            dgvListadoAutores.Columns.Add(modifyButtonColumn);

            CargarListadoAutores();

            modifyButtonColumn.DisplayIndex = dgvListadoAutores.Columns.Count - 1;
            deleteButtonColumn.DisplayIndex = dgvListadoAutores.Columns.Count - 1;
        }

        private void dgvListadoAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListadoAutores.Columns["btnEliminarColumna"].Index && e.RowIndex >= 0)
            {
                string autorId = dgvListadoAutores.Rows[e.RowIndex].Cells["IdAutor"].Value.ToString();

                _autorLogic.BajaAutor(autorId);
                CargarListadoAutores();
            }

            if (e.ColumnIndex == dgvListadoAutores.Columns["btnModificarColumna"].Index && e.RowIndex >= 0)
            {
                string autorId = dgvListadoAutores.Rows[e.RowIndex].Cells["IdAutor"].Value.ToString();

                tbIdAutorModificacion.Text = autorId;
                DatosUsuarioModificacion(autorId);
                allowTabChange = true;
                tabControlPrincipal.SelectedTab = tabModificacion;
            }
        }

        private void DatosUsuarioModificacion(string autorId)
        {
            Autor? autor = _autorLogic.ObtenerAutorPorID(tbIdAutorModificacion.Text);

            tbNombreModificacion.Text = autor.PersonaAutor.Nombre;
            tbApellidoModificacion.Text = autor.PersonaAutor.Apellido;
            tbNacionalidadModificacion.Text = autor.PersonaAutor.Nacionalidad;
            tbFechaNacimientoModificacion.Text = autor.FechaNacimiento.ToString();
            tbEmailModificacion.Text = autor.PersonaAutor.Email;
            tbTelefonoModificacion.Text = autor.PersonaAutor.Telefono;
            tbBiografiaModificacion.Text = autor.Biografia;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombreAlta.Text;
            string apellido = tbApellidoAlta.Text;
            string nacionalidad = tbNacionalidadAlta.Text;
            string email = tbEmailAlta.Text;
            string fechaNacimiento = tbFechaNacimientoAlta.Text;
            string telefono = tbTelefonoAlta.Text;
            string biografia = tbBiografiaAlta.Text;

            try
            {
                _autorLogic.AltaAutor(nombre, apellido, nacionalidad, email, fechaNacimiento, telefono, biografia);
                MessageBox.Show("El autor se ha registrado con éxito.");

                tbNombreAlta.Clear();
                tbApellidoAlta.Clear();
                tbNacionalidadAlta.Clear();
                tbEmailAlta.Clear();
                tbFechaNacimientoAlta.Clear();
                tbTelefonoAlta.Clear();
                tbBiografiaAlta.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string idAutor = tbIdAutorModificacion.Text;
            string nombre = tbNombreModificacion.Text;
            string apellido = tbApellidoModificacion.Text;
            string nacionalidad = tbNacionalidadModificacion.Text;
            string email = tbEmailModificacion.Text;
            string fechaNacimiento = tbFechaNacimientoModificacion.Text;
            string telefono = tbTelefonoModificacion.Text;
            string biografia = tbBiografiaModificacion.Text;

            try
            {
                _autorLogic.ActualizacionAutor(idAutor, nombre, apellido, nacionalidad, email, fechaNacimiento, telefono, biografia);
                MessageBox.Show("El autor se ha actualizado con éxito.");

                tbIdAutorModificacion.Clear();
                tbNombreModificacion.Clear();
                tbApellidoModificacion.Clear();
                tbNacionalidadModificacion.Clear();
                tbEmailModificacion.Clear();
                tbFechaNacimientoModificacion.Clear();
                tbTelefonoModificacion.Clear();
                tbBiografiaModificacion.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bnRecargarAlta_Click(object sender, EventArgs e)
        {
            CargarListadoAutores();
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
