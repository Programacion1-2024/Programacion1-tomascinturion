namespace CPresentacion
{
    partial class ABMEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlPrincipal = new TabControl();
            tabListado = new TabPage();
            button1 = new Button();
            bnRecargarAlta = new Button();
            dgvListadoEmpleados = new DataGridView();
            tabAlta = new TabPage();
            panelAlta = new Panel();
            dtpFechaIngreso = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            tbCargoAlta = new TextBox();
            tbSueldoAlta = new TextBox();
            tbNombreAlta = new TextBox();
            tbTelefonoAlta = new TextBox();
            lblNombreAlta = new Label();
            lbApellidoAlta = new Label();
            tbEmailAlta = new TextBox();
            lbTelefonoAlta = new Label();
            tbNacionalidadAlta = new TextBox();
            lbNacionalidadAlta = new Label();
            lbEmailAlta = new Label();
            tbApellidoAlta = new TextBox();
            lbCargoAlta = new Label();
            btnGuardar = new Button();
            tabModificacion = new TabPage();
            panelModificacion = new Panel();
            tbCargoModificacion = new TextBox();
            tbIdEmpleadoModificacion = new TextBox();
            tbTelefonoModificacion = new TextBox();
            bvNombreModificacion = new Label();
            lbApellidoModificacion = new Label();
            tbEmailModificacion = new TextBox();
            lbTelefonoModificacion = new Label();
            tbNacionalidadModificacion = new TextBox();
            lbNacionalidadModificacion = new Label();
            tbSueldoModificacion = new TextBox();
            lbEmailModificacion = new Label();
            tbApellidoModificacion = new TextBox();
            lbBiografiaModificacion = new Label();
            tbNombreModificacion = new TextBox();
            btnActualizar = new Button();
            lbIdAutorModificacion = new Label();
            lbSueldoModificacion = new Label();
            tabControlPrincipal.SuspendLayout();
            tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadoEmpleados).BeginInit();
            tabAlta.SuspendLayout();
            panelAlta.SuspendLayout();
            tabModificacion.SuspendLayout();
            panelModificacion.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlPrincipal.Controls.Add(tabListado);
            tabControlPrincipal.Controls.Add(tabAlta);
            tabControlPrincipal.Controls.Add(tabModificacion);
            tabControlPrincipal.Location = new Point(12, 12);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.SelectedIndex = 0;
            tabControlPrincipal.Size = new Size(867, 486);
            tabControlPrincipal.TabIndex = 1;
            tabControlPrincipal.SelectedIndexChanged += tabControlPrincipal_SelectedIndexChanged;
            tabControlPrincipal.Selecting += tabControlPrincipal_Selecting_1;
            // 
            // tabListado
            // 
            tabListado.Controls.Add(button1);
            tabListado.Controls.Add(bnRecargarAlta);
            tabListado.Controls.Add(dgvListadoEmpleados);
            tabListado.Location = new Point(4, 24);
            tabListado.Name = "tabListado";
            tabListado.Padding = new Padding(3);
            tabListado.Size = new Size(859, 458);
            tabListado.TabIndex = 0;
            tabListado.Text = "Listado";
            tabListado.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(771, 432);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 24);
            button1.TabIndex = 2;
            button1.Text = "Recargar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // bnRecargarAlta
            // 
            bnRecargarAlta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bnRecargarAlta.Location = new Point(1427, 788);
            bnRecargarAlta.Margin = new Padding(3, 2, 3, 2);
            bnRecargarAlta.Name = "bnRecargarAlta";
            bnRecargarAlta.Size = new Size(82, 24);
            bnRecargarAlta.TabIndex = 1;
            bnRecargarAlta.Text = "Recargar";
            bnRecargarAlta.UseVisualStyleBackColor = true;
            // 
            // dgvListadoEmpleados
            // 
            dgvListadoEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListadoEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListadoEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoEmpleados.Location = new Point(0, 6);
            dgvListadoEmpleados.Name = "dgvListadoEmpleados";
            dgvListadoEmpleados.RowHeadersWidth = 51;
            dgvListadoEmpleados.Size = new Size(853, 424);
            dgvListadoEmpleados.TabIndex = 0;
            dgvListadoEmpleados.CellContentClick += dgvListadoEmpleados_CellContentClick;
            // 
            // tabAlta
            // 
            tabAlta.Controls.Add(panelAlta);
            tabAlta.Location = new Point(4, 24);
            tabAlta.Name = "tabAlta";
            tabAlta.Padding = new Padding(3);
            tabAlta.Size = new Size(859, 458);
            tabAlta.TabIndex = 1;
            tabAlta.Text = "Alta";
            tabAlta.UseVisualStyleBackColor = true;
            // 
            // panelAlta
            // 
            panelAlta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelAlta.Controls.Add(dtpFechaIngreso);
            panelAlta.Controls.Add(label2);
            panelAlta.Controls.Add(label1);
            panelAlta.Controls.Add(tbCargoAlta);
            panelAlta.Controls.Add(tbSueldoAlta);
            panelAlta.Controls.Add(tbNombreAlta);
            panelAlta.Controls.Add(tbTelefonoAlta);
            panelAlta.Controls.Add(lblNombreAlta);
            panelAlta.Controls.Add(lbApellidoAlta);
            panelAlta.Controls.Add(tbEmailAlta);
            panelAlta.Controls.Add(lbTelefonoAlta);
            panelAlta.Controls.Add(tbNacionalidadAlta);
            panelAlta.Controls.Add(lbNacionalidadAlta);
            panelAlta.Controls.Add(lbEmailAlta);
            panelAlta.Controls.Add(tbApellidoAlta);
            panelAlta.Controls.Add(lbCargoAlta);
            panelAlta.Controls.Add(btnGuardar);
            panelAlta.Location = new Point(150, 53);
            panelAlta.Name = "panelAlta";
            panelAlta.Size = new Size(1213, 708);
            panelAlta.TabIndex = 12;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Location = new Point(377, 160);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(200, 23);
            dtpFechaIngreso.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 166);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 30;
            label2.Text = "Fecha de Ingreso";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 111);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 28;
            label1.Text = "Sueldo";
            // 
            // tbCargoAlta
            // 
            tbCargoAlta.Location = new Point(100, 156);
            tbCargoAlta.Name = "tbCargoAlta";
            tbCargoAlta.Size = new Size(158, 23);
            tbCargoAlta.TabIndex = 20;
            // 
            // tbSueldoAlta
            // 
            tbSueldoAlta.Location = new Point(377, 106);
            tbSueldoAlta.Name = "tbSueldoAlta";
            tbSueldoAlta.Size = new Size(158, 23);
            tbSueldoAlta.TabIndex = 21;
            // 
            // tbNombreAlta
            // 
            tbNombreAlta.Location = new Point(100, 15);
            tbNombreAlta.Name = "tbNombreAlta";
            tbNombreAlta.Size = new Size(158, 23);
            tbNombreAlta.TabIndex = 12;
            // 
            // tbTelefonoAlta
            // 
            tbTelefonoAlta.Location = new Point(377, 61);
            tbTelefonoAlta.Name = "tbTelefonoAlta";
            tbTelefonoAlta.Size = new Size(158, 23);
            tbTelefonoAlta.TabIndex = 16;
            // 
            // lblNombreAlta
            // 
            lblNombreAlta.AutoSize = true;
            lblNombreAlta.Location = new Point(9, 15);
            lblNombreAlta.Name = "lblNombreAlta";
            lblNombreAlta.Size = new Size(51, 15);
            lblNombreAlta.TabIndex = 14;
            lblNombreAlta.Text = "Nombre";
            // 
            // lbApellidoAlta
            // 
            lbApellidoAlta.AutoSize = true;
            lbApellidoAlta.Location = new Point(314, 17);
            lbApellidoAlta.Name = "lbApellidoAlta";
            lbApellidoAlta.Size = new Size(51, 15);
            lbApellidoAlta.TabIndex = 17;
            lbApellidoAlta.Text = "Apellido";
            // 
            // tbEmailAlta
            // 
            tbEmailAlta.Location = new Point(100, 108);
            tbEmailAlta.Name = "tbEmailAlta";
            tbEmailAlta.Size = new Size(158, 23);
            tbEmailAlta.TabIndex = 18;
            // 
            // lbTelefonoAlta
            // 
            lbTelefonoAlta.AutoSize = true;
            lbTelefonoAlta.Location = new Point(314, 64);
            lbTelefonoAlta.Name = "lbTelefonoAlta";
            lbTelefonoAlta.Size = new Size(52, 15);
            lbTelefonoAlta.TabIndex = 20;
            lbTelefonoAlta.Text = "Telefono";
            // 
            // tbNacionalidadAlta
            // 
            tbNacionalidadAlta.Location = new Point(100, 61);
            tbNacionalidadAlta.Name = "tbNacionalidadAlta";
            tbNacionalidadAlta.Size = new Size(158, 23);
            tbNacionalidadAlta.TabIndex = 15;
            // 
            // lbNacionalidadAlta
            // 
            lbNacionalidadAlta.AutoSize = true;
            lbNacionalidadAlta.Location = new Point(9, 64);
            lbNacionalidadAlta.Name = "lbNacionalidadAlta";
            lbNacionalidadAlta.Size = new Size(77, 15);
            lbNacionalidadAlta.TabIndex = 23;
            lbNacionalidadAlta.Text = "Nacionalidad";
            // 
            // lbEmailAlta
            // 
            lbEmailAlta.AutoSize = true;
            lbEmailAlta.Location = new Point(9, 111);
            lbEmailAlta.Name = "lbEmailAlta";
            lbEmailAlta.Size = new Size(36, 15);
            lbEmailAlta.TabIndex = 24;
            lbEmailAlta.Text = "Email";
            // 
            // tbApellidoAlta
            // 
            tbApellidoAlta.Location = new Point(377, 15);
            tbApellidoAlta.Name = "tbApellidoAlta";
            tbApellidoAlta.Size = new Size(158, 23);
            tbApellidoAlta.TabIndex = 13;
            // 
            // lbCargoAlta
            // 
            lbCargoAlta.AutoSize = true;
            lbCargoAlta.Location = new Point(9, 158);
            lbCargoAlta.Name = "lbCargoAlta";
            lbCargoAlta.Size = new Size(39, 15);
            lbCargoAlta.TabIndex = 25;
            lbCargoAlta.Text = "Cargo";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(286, 323);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // tabModificacion
            // 
            tabModificacion.Controls.Add(panelModificacion);
            tabModificacion.Location = new Point(4, 24);
            tabModificacion.Name = "tabModificacion";
            tabModificacion.Padding = new Padding(3);
            tabModificacion.Size = new Size(859, 458);
            tabModificacion.TabIndex = 2;
            tabModificacion.Text = "Modificacion";
            tabModificacion.UseVisualStyleBackColor = true;
            // 
            // panelModificacion
            // 
            panelModificacion.Controls.Add(tbCargoModificacion);
            panelModificacion.Controls.Add(tbIdEmpleadoModificacion);
            panelModificacion.Controls.Add(tbTelefonoModificacion);
            panelModificacion.Controls.Add(bvNombreModificacion);
            panelModificacion.Controls.Add(lbApellidoModificacion);
            panelModificacion.Controls.Add(tbEmailModificacion);
            panelModificacion.Controls.Add(lbTelefonoModificacion);
            panelModificacion.Controls.Add(tbNacionalidadModificacion);
            panelModificacion.Controls.Add(lbNacionalidadModificacion);
            panelModificacion.Controls.Add(tbSueldoModificacion);
            panelModificacion.Controls.Add(lbEmailModificacion);
            panelModificacion.Controls.Add(tbApellidoModificacion);
            panelModificacion.Controls.Add(lbBiografiaModificacion);
            panelModificacion.Controls.Add(tbNombreModificacion);
            panelModificacion.Controls.Add(btnActualizar);
            panelModificacion.Controls.Add(lbIdAutorModificacion);
            panelModificacion.Controls.Add(lbSueldoModificacion);
            panelModificacion.Location = new Point(136, 11);
            panelModificacion.Name = "panelModificacion";
            panelModificacion.Size = new Size(576, 396);
            panelModificacion.TabIndex = 28;
            // 
            // tbCargoModificacion
            // 
            tbCargoModificacion.Location = new Point(111, 200);
            tbCargoModificacion.Name = "tbCargoModificacion";
            tbCargoModificacion.Size = new Size(158, 23);
            tbCargoModificacion.TabIndex = 45;
            // 
            // tbIdEmpleadoModificacion
            // 
            tbIdEmpleadoModificacion.Location = new Point(260, 16);
            tbIdEmpleadoModificacion.Name = "tbIdEmpleadoModificacion";
            tbIdEmpleadoModificacion.ReadOnly = true;
            tbIdEmpleadoModificacion.Size = new Size(158, 23);
            tbIdEmpleadoModificacion.TabIndex = 28;
            // 
            // tbTelefonoModificacion
            // 
            tbTelefonoModificacion.Location = new Point(388, 100);
            tbTelefonoModificacion.Name = "tbTelefonoModificacion";
            tbTelefonoModificacion.Size = new Size(158, 23);
            tbTelefonoModificacion.TabIndex = 32;
            // 
            // bvNombreModificacion
            // 
            bvNombreModificacion.AutoSize = true;
            bvNombreModificacion.Location = new Point(20, 54);
            bvNombreModificacion.Name = "bvNombreModificacion";
            bvNombreModificacion.Size = new Size(51, 15);
            bvNombreModificacion.TabIndex = 37;
            bvNombreModificacion.Text = "Nombre";
            // 
            // lbApellidoModificacion
            // 
            lbApellidoModificacion.AutoSize = true;
            lbApellidoModificacion.Location = new Point(325, 56);
            lbApellidoModificacion.Name = "lbApellidoModificacion";
            lbApellidoModificacion.Size = new Size(51, 15);
            lbApellidoModificacion.TabIndex = 38;
            lbApellidoModificacion.Text = "Apellido";
            // 
            // tbEmailModificacion
            // 
            tbEmailModificacion.Location = new Point(111, 147);
            tbEmailModificacion.Name = "tbEmailModificacion";
            tbEmailModificacion.Size = new Size(158, 23);
            tbEmailModificacion.TabIndex = 33;
            // 
            // lbTelefonoModificacion
            // 
            lbTelefonoModificacion.AutoSize = true;
            lbTelefonoModificacion.Location = new Point(325, 103);
            lbTelefonoModificacion.Name = "lbTelefonoModificacion";
            lbTelefonoModificacion.Size = new Size(52, 15);
            lbTelefonoModificacion.TabIndex = 39;
            lbTelefonoModificacion.Text = "Telefono";
            // 
            // tbNacionalidadModificacion
            // 
            tbNacionalidadModificacion.Enabled = false;
            tbNacionalidadModificacion.Location = new Point(111, 100);
            tbNacionalidadModificacion.Name = "tbNacionalidadModificacion";
            tbNacionalidadModificacion.Size = new Size(158, 23);
            tbNacionalidadModificacion.TabIndex = 31;
            // 
            // lbNacionalidadModificacion
            // 
            lbNacionalidadModificacion.AutoSize = true;
            lbNacionalidadModificacion.Location = new Point(20, 103);
            lbNacionalidadModificacion.Name = "lbNacionalidadModificacion";
            lbNacionalidadModificacion.Size = new Size(77, 15);
            lbNacionalidadModificacion.TabIndex = 40;
            lbNacionalidadModificacion.Text = "Nacionalidad";
            // 
            // tbSueldoModificacion
            // 
            tbSueldoModificacion.Location = new Point(388, 147);
            tbSueldoModificacion.Name = "tbSueldoModificacion";
            tbSueldoModificacion.Size = new Size(158, 23);
            tbSueldoModificacion.TabIndex = 34;
            // 
            // lbEmailModificacion
            // 
            lbEmailModificacion.AutoSize = true;
            lbEmailModificacion.Location = new Point(20, 150);
            lbEmailModificacion.Name = "lbEmailModificacion";
            lbEmailModificacion.Size = new Size(36, 15);
            lbEmailModificacion.TabIndex = 41;
            lbEmailModificacion.Text = "Email";
            // 
            // tbApellidoModificacion
            // 
            tbApellidoModificacion.Enabled = false;
            tbApellidoModificacion.Location = new Point(388, 54);
            tbApellidoModificacion.Name = "tbApellidoModificacion";
            tbApellidoModificacion.Size = new Size(158, 23);
            tbApellidoModificacion.TabIndex = 30;
            // 
            // lbBiografiaModificacion
            // 
            lbBiografiaModificacion.AutoSize = true;
            lbBiografiaModificacion.Location = new Point(20, 202);
            lbBiografiaModificacion.Name = "lbBiografiaModificacion";
            lbBiografiaModificacion.Size = new Size(39, 15);
            lbBiografiaModificacion.TabIndex = 42;
            lbBiografiaModificacion.Text = "Cargo";
            // 
            // tbNombreModificacion
            // 
            tbNombreModificacion.Enabled = false;
            tbNombreModificacion.Location = new Point(111, 54);
            tbNombreModificacion.Name = "tbNombreModificacion";
            tbNombreModificacion.Size = new Size(158, 23);
            tbNombreModificacion.TabIndex = 29;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(297, 362);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 36;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // lbIdAutorModificacion
            // 
            lbIdAutorModificacion.AutoSize = true;
            lbIdAutorModificacion.Location = new Point(171, 18);
            lbIdAutorModificacion.Name = "lbIdAutorModificacion";
            lbIdAutorModificacion.Size = new Size(74, 15);
            lbIdAutorModificacion.TabIndex = 44;
            lbIdAutorModificacion.Text = "ID Empleado";
            // 
            // lbSueldoModificacion
            // 
            lbSueldoModificacion.AutoSize = true;
            lbSueldoModificacion.Location = new Point(325, 149);
            lbSueldoModificacion.Name = "lbSueldoModificacion";
            lbSueldoModificacion.Size = new Size(43, 15);
            lbSueldoModificacion.TabIndex = 43;
            lbSueldoModificacion.Text = "Sueldo";
            // 
            // ABMEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 510);
            Controls.Add(tabControlPrincipal);
            Name = "ABMEmpleado";
            Text = "ABMEmpleado";
            Load += ABMEmpleado_Load;
            tabControlPrincipal.ResumeLayout(false);
            tabListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListadoEmpleados).EndInit();
            tabAlta.ResumeLayout(false);
            panelAlta.ResumeLayout(false);
            panelAlta.PerformLayout();
            tabModificacion.ResumeLayout(false);
            panelModificacion.ResumeLayout(false);
            panelModificacion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlPrincipal;
        private TabPage tabListado;
        private Button bnRecargarAlta;
        private DataGridView dgvListadoEmpleados;
        private TabPage tabAlta;
        private Panel panelAlta;
        private Label lbFechaNacimientoAlta;
        private TextBox tbNombreAlta;
        private TextBox tbFechaNacimientoAlta;
        private Label lblNombreAlta;
        private TextBox tbBiografiaAlta;
        private Label lbApellidoAlta;
        private TextBox tbEmailAlta;
        private Label lbTelefonoAlta;
        private TextBox tbNacionalidadAlta;
        private Label lbNacionalidadAlta;
        private TextBox tbTelefonoAlta;
        private Label lbEmailAlta;
        private TextBox tbApellidoAlta;
        private Label lbCargoAlta;
        private Button btnGuardar;
        private TabPage tabModificacion;
        private Panel panelModificacion;
        private TextBox tbIdEmpleadoModificacion;
        private TextBox tbTelefonoModificacion;
        private Label bvNombreModificacion;
        private Label lbApellidoModificacion;
        private TextBox tbEmailModificacion;
        private Label lbTelefonoModificacion;
        private TextBox tbNacionalidadModificacion;
        private Label lbNacionalidadModificacion;
        private TextBox tbSueldoModificacion;
        private Label lbEmailModificacion;
        private TextBox tbApellidoModificacion;
        private Label lbBiografiaModificacion;
        private TextBox tbNombreModificacion;
        private Button btnActualizar;
        private Label lbIdAutorModificacion;
        private Label lbSueldoModificacion;
        private Button button1;
        private TextBox tbCargoModificacion;
        private TextBox tbCargoAlta;
        private TextBox tbSueldoAlta;
        private Label label1;
        private DateTimePicker dtpFechaIngreso;
        private Label label2;
    }
}