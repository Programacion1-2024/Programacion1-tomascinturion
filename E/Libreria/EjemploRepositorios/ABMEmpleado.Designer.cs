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
            label1 = new Label();
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
            tabControlPrincipal.Location = new Point(14, 16);
            tabControlPrincipal.Margin = new Padding(3, 4, 3, 4);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.SelectedIndex = 0;
            tabControlPrincipal.Size = new Size(991, 648);
            tabControlPrincipal.TabIndex = 1;
            tabControlPrincipal.SelectedIndexChanged += tabControlPrincipal_SelectedIndexChanged;
            // 
            // tabListado
            // 
            tabListado.Controls.Add(button1);
            tabListado.Controls.Add(bnRecargarAlta);
            tabListado.Controls.Add(dgvListadoEmpleados);
            tabListado.Location = new Point(4, 29);
            tabListado.Margin = new Padding(3, 4, 3, 4);
            tabListado.Name = "tabListado";
            tabListado.Padding = new Padding(3, 4, 3, 4);
            tabListado.Size = new Size(983, 615);
            tabListado.TabIndex = 0;
            tabListado.Text = "Listado";
            tabListado.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(881, 576);
            button1.Name = "button1";
            button1.Size = new Size(94, 32);
            button1.TabIndex = 2;
            button1.Text = "Recargar";
            button1.UseVisualStyleBackColor = true;
            // 
            // bnRecargarAlta
            // 
            bnRecargarAlta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bnRecargarAlta.Location = new Point(1631, 1051);
            bnRecargarAlta.Name = "bnRecargarAlta";
            bnRecargarAlta.Size = new Size(94, 32);
            bnRecargarAlta.TabIndex = 1;
            bnRecargarAlta.Text = "Recargar";
            bnRecargarAlta.UseVisualStyleBackColor = true;
            // 
            // dgvListadoEmpleados
            // 
            dgvListadoEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListadoEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListadoEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoEmpleados.Location = new Point(0, 8);
            dgvListadoEmpleados.Margin = new Padding(3, 4, 3, 4);
            dgvListadoEmpleados.Name = "dgvListadoEmpleados";
            dgvListadoEmpleados.RowHeadersWidth = 51;
            dgvListadoEmpleados.Size = new Size(975, 565);
            dgvListadoEmpleados.TabIndex = 0;
            dgvListadoEmpleados.CellContentClick += dgvListadoEmpleados_CellContentClick;
            // 
            // tabAlta
            // 
            tabAlta.Controls.Add(panelAlta);
            tabAlta.Location = new Point(4, 29);
            tabAlta.Margin = new Padding(3, 4, 3, 4);
            tabAlta.Name = "tabAlta";
            tabAlta.Padding = new Padding(3, 4, 3, 4);
            tabAlta.Size = new Size(983, 615);
            tabAlta.TabIndex = 1;
            tabAlta.Text = "Alta";
            tabAlta.UseVisualStyleBackColor = true;
            // 
            // panelAlta
            // 
            panelAlta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            panelAlta.Location = new Point(171, 71);
            panelAlta.Margin = new Padding(3, 4, 3, 4);
            panelAlta.Name = "panelAlta";
            panelAlta.Size = new Size(1386, 944);
            panelAlta.TabIndex = 12;
            // 
            // tbCargoAlta
            // 
            tbCargoAlta.Location = new Point(114, 208);
            tbCargoAlta.Margin = new Padding(3, 4, 3, 4);
            tbCargoAlta.Name = "tbCargoAlta";
            tbCargoAlta.Size = new Size(180, 27);
            tbCargoAlta.TabIndex = 20;
            // 
            // tbSueldoAlta
            // 
            tbSueldoAlta.Location = new Point(431, 141);
            tbSueldoAlta.Margin = new Padding(3, 4, 3, 4);
            tbSueldoAlta.Name = "tbSueldoAlta";
            tbSueldoAlta.Size = new Size(180, 27);
            tbSueldoAlta.TabIndex = 27;
            // 
            // tbNombreAlta
            // 
            tbNombreAlta.Location = new Point(114, 20);
            tbNombreAlta.Margin = new Padding(3, 4, 3, 4);
            tbNombreAlta.Name = "tbNombreAlta";
            tbNombreAlta.Size = new Size(180, 27);
            tbNombreAlta.TabIndex = 12;
            // 
            // tbTelefonoAlta
            // 
            tbTelefonoAlta.Location = new Point(431, 81);
            tbTelefonoAlta.Margin = new Padding(3, 4, 3, 4);
            tbTelefonoAlta.Name = "tbTelefonoAlta";
            tbTelefonoAlta.Size = new Size(180, 27);
            tbTelefonoAlta.TabIndex = 16;
            // 
            // lblNombreAlta
            // 
            lblNombreAlta.AutoSize = true;
            lblNombreAlta.Location = new Point(10, 20);
            lblNombreAlta.Name = "lblNombreAlta";
            lblNombreAlta.Size = new Size(64, 20);
            lblNombreAlta.TabIndex = 14;
            lblNombreAlta.Text = "Nombre";
            // 
            // lbApellidoAlta
            // 
            lbApellidoAlta.AutoSize = true;
            lbApellidoAlta.Location = new Point(359, 23);
            lbApellidoAlta.Name = "lbApellidoAlta";
            lbApellidoAlta.Size = new Size(66, 20);
            lbApellidoAlta.TabIndex = 17;
            lbApellidoAlta.Text = "Apellido";
            // 
            // tbEmailAlta
            // 
            tbEmailAlta.Location = new Point(114, 144);
            tbEmailAlta.Margin = new Padding(3, 4, 3, 4);
            tbEmailAlta.Name = "tbEmailAlta";
            tbEmailAlta.Size = new Size(180, 27);
            tbEmailAlta.TabIndex = 18;
            // 
            // lbTelefonoAlta
            // 
            lbTelefonoAlta.AutoSize = true;
            lbTelefonoAlta.Location = new Point(359, 85);
            lbTelefonoAlta.Name = "lbTelefonoAlta";
            lbTelefonoAlta.Size = new Size(67, 20);
            lbTelefonoAlta.TabIndex = 20;
            lbTelefonoAlta.Text = "Telefono";
            // 
            // tbNacionalidadAlta
            // 
            tbNacionalidadAlta.Location = new Point(114, 81);
            tbNacionalidadAlta.Margin = new Padding(3, 4, 3, 4);
            tbNacionalidadAlta.Name = "tbNacionalidadAlta";
            tbNacionalidadAlta.Size = new Size(180, 27);
            tbNacionalidadAlta.TabIndex = 15;
            // 
            // lbNacionalidadAlta
            // 
            lbNacionalidadAlta.AutoSize = true;
            lbNacionalidadAlta.Location = new Point(10, 85);
            lbNacionalidadAlta.Name = "lbNacionalidadAlta";
            lbNacionalidadAlta.Size = new Size(98, 20);
            lbNacionalidadAlta.TabIndex = 23;
            lbNacionalidadAlta.Text = "Nacionalidad";
            // 
            // lbEmailAlta
            // 
            lbEmailAlta.AutoSize = true;
            lbEmailAlta.Location = new Point(10, 148);
            lbEmailAlta.Name = "lbEmailAlta";
            lbEmailAlta.Size = new Size(46, 20);
            lbEmailAlta.TabIndex = 24;
            lbEmailAlta.Text = "Email";
            // 
            // tbApellidoAlta
            // 
            tbApellidoAlta.Location = new Point(431, 20);
            tbApellidoAlta.Margin = new Padding(3, 4, 3, 4);
            tbApellidoAlta.Name = "tbApellidoAlta";
            tbApellidoAlta.Size = new Size(180, 27);
            tbApellidoAlta.TabIndex = 13;
            // 
            // lbCargoAlta
            // 
            lbCargoAlta.AutoSize = true;
            lbCargoAlta.Location = new Point(10, 211);
            lbCargoAlta.Name = "lbCargoAlta";
            lbCargoAlta.Size = new Size(49, 20);
            lbCargoAlta.TabIndex = 25;
            lbCargoAlta.Text = "Cargo";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(327, 431);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // tabModificacion
            // 
            tabModificacion.Controls.Add(panelModificacion);
            tabModificacion.Location = new Point(4, 29);
            tabModificacion.Margin = new Padding(3, 4, 3, 4);
            tabModificacion.Name = "tabModificacion";
            tabModificacion.Padding = new Padding(3, 4, 3, 4);
            tabModificacion.Size = new Size(983, 615);
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
            panelModificacion.Location = new Point(155, 15);
            panelModificacion.Margin = new Padding(3, 4, 3, 4);
            panelModificacion.Name = "panelModificacion";
            panelModificacion.Size = new Size(658, 528);
            panelModificacion.TabIndex = 28;
            // 
            // tbCargoModificacion
            // 
            tbCargoModificacion.Location = new Point(127, 267);
            tbCargoModificacion.Margin = new Padding(3, 4, 3, 4);
            tbCargoModificacion.Name = "tbCargoModificacion";
            tbCargoModificacion.Size = new Size(180, 27);
            tbCargoModificacion.TabIndex = 45;
            // 
            // tbIdEmpleadoModificacion
            // 
            tbIdEmpleadoModificacion.Location = new Point(297, 21);
            tbIdEmpleadoModificacion.Margin = new Padding(3, 4, 3, 4);
            tbIdEmpleadoModificacion.Name = "tbIdEmpleadoModificacion";
            tbIdEmpleadoModificacion.ReadOnly = true;
            tbIdEmpleadoModificacion.Size = new Size(180, 27);
            tbIdEmpleadoModificacion.TabIndex = 28;
            // 
            // tbTelefonoModificacion
            // 
            tbTelefonoModificacion.Location = new Point(443, 133);
            tbTelefonoModificacion.Margin = new Padding(3, 4, 3, 4);
            tbTelefonoModificacion.Name = "tbTelefonoModificacion";
            tbTelefonoModificacion.Size = new Size(180, 27);
            tbTelefonoModificacion.TabIndex = 32;
            // 
            // bvNombreModificacion
            // 
            bvNombreModificacion.AutoSize = true;
            bvNombreModificacion.Location = new Point(23, 72);
            bvNombreModificacion.Name = "bvNombreModificacion";
            bvNombreModificacion.Size = new Size(64, 20);
            bvNombreModificacion.TabIndex = 37;
            bvNombreModificacion.Text = "Nombre";
            // 
            // lbApellidoModificacion
            // 
            lbApellidoModificacion.AutoSize = true;
            lbApellidoModificacion.Location = new Point(371, 75);
            lbApellidoModificacion.Name = "lbApellidoModificacion";
            lbApellidoModificacion.Size = new Size(66, 20);
            lbApellidoModificacion.TabIndex = 38;
            lbApellidoModificacion.Text = "Apellido";
            // 
            // tbEmailModificacion
            // 
            tbEmailModificacion.Location = new Point(127, 196);
            tbEmailModificacion.Margin = new Padding(3, 4, 3, 4);
            tbEmailModificacion.Name = "tbEmailModificacion";
            tbEmailModificacion.Size = new Size(180, 27);
            tbEmailModificacion.TabIndex = 33;
            // 
            // lbTelefonoModificacion
            // 
            lbTelefonoModificacion.AutoSize = true;
            lbTelefonoModificacion.Location = new Point(371, 137);
            lbTelefonoModificacion.Name = "lbTelefonoModificacion";
            lbTelefonoModificacion.Size = new Size(67, 20);
            lbTelefonoModificacion.TabIndex = 39;
            lbTelefonoModificacion.Text = "Telefono";
            // 
            // tbNacionalidadModificacion
            // 
            tbNacionalidadModificacion.Location = new Point(127, 133);
            tbNacionalidadModificacion.Margin = new Padding(3, 4, 3, 4);
            tbNacionalidadModificacion.Name = "tbNacionalidadModificacion";
            tbNacionalidadModificacion.Size = new Size(180, 27);
            tbNacionalidadModificacion.TabIndex = 31;
            // 
            // lbNacionalidadModificacion
            // 
            lbNacionalidadModificacion.AutoSize = true;
            lbNacionalidadModificacion.Location = new Point(23, 137);
            lbNacionalidadModificacion.Name = "lbNacionalidadModificacion";
            lbNacionalidadModificacion.Size = new Size(98, 20);
            lbNacionalidadModificacion.TabIndex = 40;
            lbNacionalidadModificacion.Text = "Nacionalidad";
            // 
            // tbSueldoModificacion
            // 
            tbSueldoModificacion.Location = new Point(443, 196);
            tbSueldoModificacion.Margin = new Padding(3, 4, 3, 4);
            tbSueldoModificacion.Name = "tbSueldoModificacion";
            tbSueldoModificacion.Size = new Size(180, 27);
            tbSueldoModificacion.TabIndex = 34;
            // 
            // lbEmailModificacion
            // 
            lbEmailModificacion.AutoSize = true;
            lbEmailModificacion.Location = new Point(23, 200);
            lbEmailModificacion.Name = "lbEmailModificacion";
            lbEmailModificacion.Size = new Size(46, 20);
            lbEmailModificacion.TabIndex = 41;
            lbEmailModificacion.Text = "Email";
            // 
            // tbApellidoModificacion
            // 
            tbApellidoModificacion.Location = new Point(443, 72);
            tbApellidoModificacion.Margin = new Padding(3, 4, 3, 4);
            tbApellidoModificacion.Name = "tbApellidoModificacion";
            tbApellidoModificacion.Size = new Size(180, 27);
            tbApellidoModificacion.TabIndex = 30;
            // 
            // lbBiografiaModificacion
            // 
            lbBiografiaModificacion.AutoSize = true;
            lbBiografiaModificacion.Location = new Point(23, 270);
            lbBiografiaModificacion.Name = "lbBiografiaModificacion";
            lbBiografiaModificacion.Size = new Size(49, 20);
            lbBiografiaModificacion.TabIndex = 42;
            lbBiografiaModificacion.Text = "Cargo";
            // 
            // tbNombreModificacion
            // 
            tbNombreModificacion.Location = new Point(127, 72);
            tbNombreModificacion.Margin = new Padding(3, 4, 3, 4);
            tbNombreModificacion.Name = "tbNombreModificacion";
            tbNombreModificacion.Size = new Size(180, 27);
            tbNombreModificacion.TabIndex = 29;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(339, 483);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(86, 31);
            btnActualizar.TabIndex = 36;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // lbIdAutorModificacion
            // 
            lbIdAutorModificacion.AutoSize = true;
            lbIdAutorModificacion.Location = new Point(195, 24);
            lbIdAutorModificacion.Name = "lbIdAutorModificacion";
            lbIdAutorModificacion.Size = new Size(96, 20);
            lbIdAutorModificacion.TabIndex = 44;
            lbIdAutorModificacion.Text = "ID Empleado";
            // 
            // lbSueldoModificacion
            // 
            lbSueldoModificacion.AutoSize = true;
            lbSueldoModificacion.Location = new Point(371, 199);
            lbSueldoModificacion.Name = "lbSueldoModificacion";
            lbSueldoModificacion.Size = new Size(55, 20);
            lbSueldoModificacion.TabIndex = 43;
            lbSueldoModificacion.Text = "Sueldo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(359, 148);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 28;
            label1.Text = "Sueldo";
            // 
            // ABMEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 680);
            Controls.Add(tabControlPrincipal);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}