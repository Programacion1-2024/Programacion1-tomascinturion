namespace Presentacionn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CrearMenu();
        }
        private void CrearMenu()
        {
            int startX = 0; // Posición fija en X, alineada a la izquierda
            int startY = 0; // Inicia desde el borde superior
            int offsetY = 80;
            // Crear Paneles de Menú (Tarjetas)
            CrearTarjetaMenu("Mis Compras", startX, startY);
            CrearTarjetaMenu("Configuración", startX, startY + offsetY);
            CrearTarjetaMenu("Notificaciones", startX, startY + offsetY * 2);
            CrearTarjetaMenu("Información de la cuenta", startX, startY + offsetY * 3);
        }

        private void CrearTarjetaMenu(string titulo, int x, int y)
        {
            // Crear el panel de la tarjeta
            Panel tarjeta = new Panel();
            tarjeta.Size = new Size(250, 80);
            tarjeta.Location = new Point(x, y);
            tarjeta.BackColor = Color.LightGray;
            tarjeta.BorderStyle = BorderStyle.FixedSingle;


            // Crear label para el título
            Label lblTitulo = new Label();
            lblTitulo.Text = titulo;
            lblTitulo.Font = new Font("Arial", 12, FontStyle.Bold);
            lblTitulo.AutoSize = false; // Desactivar AutoSize para controlar tamaño
            lblTitulo.Size = new Size(230, 60); // Ocupa todo el ancho del panel
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter; // Centrar el texto
            lblTitulo.Location = new Point(
                (tarjeta.Width - lblTitulo.Width) / 2,
                (tarjeta.Height - lblTitulo.Height) / 2
            );
            // Agregar controles al panel
            tarjeta.Controls.Add(lblTitulo);

            // Añadir evento de click para redirigir
            tarjeta.Click += (s, e) => { MessageBox.Show($"Clic en {titulo}"); };

            tarjeta.MouseEnter += (s, e) => AgrandarTarjeta(tarjeta);
            tarjeta.MouseLeave += (s, e) => ReducirTarjeta(tarjeta);

            // Agregar el panel al formulario
            this.Controls.Add(tarjeta);
            tarjeta.BringToFront();
        }
        private void AgrandarTarjeta(Panel tarjeta)
        {
            tarjeta.Size = new Size(270, 100); // Aumenta el tamaño

            tarjeta.BackColor = Color.LightGray; // Cambia el color de fondo para resaltar
            tarjeta.BringToFront(); // Asegura que esté en la parte superior
        }

        private void ReducirTarjeta(Panel tarjeta)
        {
            tarjeta.Size = new Size(250, 80); // Vuelve al tamaño original

            tarjeta.BackColor = Color.LightGray; // Restaura el color original
        }


        private void btCerrarSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha cerrado la sesión");
        }
    }
}
