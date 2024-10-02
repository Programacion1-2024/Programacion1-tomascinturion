namespace CPresentacion
{
    partial class ABMCliente
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
            openFileDialog1 = new OpenFileDialog();
            tabModificacion = new TabPage();
            panelModificacion = new Panel();
            cbEsSocioModificacion = new ComboBox();
            cbPagaIVAModificacion = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            tbTipoDocumentoModificacion = new TextBox();
            label4 = new Label();
            tbNroDocumentoModificacion = new TextBox();
            bvNombreModificacion = new Label();
            lbApellidoModificacion = new Label();
            tbEmailModificacion = new TextBox();
            lbTelefonoModificacion = new Label();
            tbNacionalidadModificacion = new TextBox();
            lbNacionalidadModificacion = new Label();
            tbTelefonoModificacion = new TextBox();
            lbEmailModificacion = new Label();
            tbApellidoModificacion = new TextBox();
            tbNombreModificacion = new TextBox();
            btnActualizar = new Button();
            lbDocClienteModificacion = new Label();
            tabAlta = new TabPage();
            panelAlta = new Panel();
            cbEsSocioAlta = new ComboBox();
            cbPagaIVAAlta = new ComboBox();
            label3 = new Label();
            tbTipoDocumentoAlta = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbNroDocumentoAlta = new TextBox();
            lbPagaIVAAlta = new Label();
            tbNombreAlta = new TextBox();
            lblNombreAlta = new Label();
            lbApellidoAlta = new Label();
            tbEmailAlta = new TextBox();
            lbTelefonoAlta = new Label();
            tbNacionalidadAlta = new TextBox();
            lbNacionalidadAlta = new Label();
            tbTelefonoAlta = new TextBox();
            lbEmailAlta = new Label();
            tbApellidoAlta = new TextBox();
            btnGuardar = new Button();
            tabListado = new TabPage();
            bnRecargarAlta = new Button();
            dgvListadoClientes = new DataGridView();
            tabControlPrincipal = new TabControl();
            tabModificacion.SuspendLayout();
            panelModificacion.SuspendLayout();
            tabAlta.SuspendLayout();
            panelAlta.SuspendLayout();
            tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadoClientes).BeginInit();
            tabControlPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
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
            panelModificacion.Controls.Add(cbEsSocioModificacion);
            panelModificacion.Controls.Add(cbPagaIVAModificacion);
            panelModificacion.Controls.Add(label5);
            panelModificacion.Controls.Add(label6);
            panelModificacion.Controls.Add(tbTipoDocumentoModificacion);
            panelModificacion.Controls.Add(label4);
            panelModificacion.Controls.Add(tbNroDocumentoModificacion);
            panelModificacion.Controls.Add(bvNombreModificacion);
            panelModificacion.Controls.Add(lbApellidoModificacion);
            panelModificacion.Controls.Add(tbEmailModificacion);
            panelModificacion.Controls.Add(lbTelefonoModificacion);
            panelModificacion.Controls.Add(tbNacionalidadModificacion);
            panelModificacion.Controls.Add(lbNacionalidadModificacion);
            panelModificacion.Controls.Add(tbTelefonoModificacion);
            panelModificacion.Controls.Add(lbEmailModificacion);
            panelModificacion.Controls.Add(tbApellidoModificacion);
            panelModificacion.Controls.Add(tbNombreModificacion);
            panelModificacion.Controls.Add(btnActualizar);
            panelModificacion.Controls.Add(lbDocClienteModificacion);
            panelModificacion.Location = new Point(120, 81);
            panelModificacion.Name = "panelModificacion";
            panelModificacion.Size = new Size(592, 287);
            panelModificacion.TabIndex = 28;
            // 
            // cbEsSocioModificacion
            // 
            cbEsSocioModificacion.FormattingEnabled = true;
            cbEsSocioModificacion.Items.AddRange(new object[] { "Si", "No" });
            cbEsSocioModificacion.Location = new Point(418, 102);
            cbEsSocioModificacion.Name = "cbEsSocioModificacion";
            cbEsSocioModificacion.Size = new Size(158, 23);
            cbEsSocioModificacion.TabIndex = 5;
            // 
            // cbPagaIVAModificacion
            // 
            cbPagaIVAModificacion.FormattingEnabled = true;
            cbPagaIVAModificacion.Items.AddRange(new object[] { "Si", "No" });
            cbPagaIVAModificacion.Location = new Point(297, 195);
            cbPagaIVAModificacion.Name = "cbPagaIVAModificacion";
            cbPagaIVAModificacion.Size = new Size(158, 23);
            cbPagaIVAModificacion.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(325, 105);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 50;
            label5.Text = "Es Socio?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(200, 198);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 49;
            label6.Text = "Paga IVA?";
            // 
            // tbTipoDocumentoModificacion
            // 
            tbTipoDocumentoModificacion.Location = new Point(122, 17);
            tbTipoDocumentoModificacion.Name = "tbTipoDocumentoModificacion";
            tbTipoDocumentoModificacion.ReadOnly = true;
            tbTipoDocumentoModificacion.Size = new Size(158, 23);
            tbTipoDocumentoModificacion.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 20);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 46;
            label4.Text = "Tipo Documento";
            // 
            // tbNroDocumentoModificacion
            // 
            tbNroDocumentoModificacion.Location = new Point(418, 17);
            tbNroDocumentoModificacion.Name = "tbNroDocumentoModificacion";
            tbNroDocumentoModificacion.ReadOnly = true;
            tbNroDocumentoModificacion.Size = new Size(158, 23);
            tbNroDocumentoModificacion.TabIndex = 1;
            // 
            // bvNombreModificacion
            // 
            bvNombreModificacion.AutoSize = true;
            bvNombreModificacion.Location = new Point(20, 56);
            bvNombreModificacion.Name = "bvNombreModificacion";
            bvNombreModificacion.Size = new Size(51, 15);
            bvNombreModificacion.TabIndex = 37;
            bvNombreModificacion.Text = "Nombre";
            // 
            // lbApellidoModificacion
            // 
            lbApellidoModificacion.AutoSize = true;
            lbApellidoModificacion.Location = new Point(325, 58);
            lbApellidoModificacion.Name = "lbApellidoModificacion";
            lbApellidoModificacion.Size = new Size(51, 15);
            lbApellidoModificacion.TabIndex = 38;
            lbApellidoModificacion.Text = "Apellido";
            // 
            // tbEmailModificacion
            // 
            tbEmailModificacion.Location = new Point(122, 149);
            tbEmailModificacion.Name = "tbEmailModificacion";
            tbEmailModificacion.Size = new Size(158, 23);
            tbEmailModificacion.TabIndex = 6;
            // 
            // lbTelefonoModificacion
            // 
            lbTelefonoModificacion.AutoSize = true;
            lbTelefonoModificacion.Location = new Point(324, 152);
            lbTelefonoModificacion.Name = "lbTelefonoModificacion";
            lbTelefonoModificacion.Size = new Size(52, 15);
            lbTelefonoModificacion.TabIndex = 39;
            lbTelefonoModificacion.Text = "Telefono";
            // 
            // tbNacionalidadModificacion
            // 
            tbNacionalidadModificacion.Location = new Point(122, 102);
            tbNacionalidadModificacion.Name = "tbNacionalidadModificacion";
            tbNacionalidadModificacion.Size = new Size(158, 23);
            tbNacionalidadModificacion.TabIndex = 4;
            // 
            // lbNacionalidadModificacion
            // 
            lbNacionalidadModificacion.AutoSize = true;
            lbNacionalidadModificacion.Location = new Point(20, 105);
            lbNacionalidadModificacion.Name = "lbNacionalidadModificacion";
            lbNacionalidadModificacion.Size = new Size(77, 15);
            lbNacionalidadModificacion.TabIndex = 40;
            lbNacionalidadModificacion.Text = "Nacionalidad";
            // 
            // tbTelefonoModificacion
            // 
            tbTelefonoModificacion.Location = new Point(418, 149);
            tbTelefonoModificacion.Name = "tbTelefonoModificacion";
            tbTelefonoModificacion.Size = new Size(158, 23);
            tbTelefonoModificacion.TabIndex = 7;
            // 
            // lbEmailModificacion
            // 
            lbEmailModificacion.AutoSize = true;
            lbEmailModificacion.Location = new Point(20, 152);
            lbEmailModificacion.Name = "lbEmailModificacion";
            lbEmailModificacion.Size = new Size(36, 15);
            lbEmailModificacion.TabIndex = 41;
            lbEmailModificacion.Text = "Email";
            // 
            // tbApellidoModificacion
            // 
            tbApellidoModificacion.Location = new Point(418, 58);
            tbApellidoModificacion.Name = "tbApellidoModificacion";
            tbApellidoModificacion.Size = new Size(158, 23);
            tbApellidoModificacion.TabIndex = 3;
            // 
            // tbNombreModificacion
            // 
            tbNombreModificacion.Location = new Point(122, 56);
            tbNombreModificacion.Name = "tbNombreModificacion";
            tbNombreModificacion.Size = new Size(158, 23);
            tbNombreModificacion.TabIndex = 2;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(271, 252);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // lbDocClienteModificacion
            // 
            lbDocClienteModificacion.AutoSize = true;
            lbDocClienteModificacion.Location = new Point(325, 19);
            lbDocClienteModificacion.Name = "lbDocClienteModificacion";
            lbDocClienteModificacion.Size = new Size(87, 15);
            lbDocClienteModificacion.TabIndex = 44;
            lbDocClienteModificacion.Text = "Nº Documento";
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
            panelAlta.Controls.Add(cbEsSocioAlta);
            panelAlta.Controls.Add(cbPagaIVAAlta);
            panelAlta.Controls.Add(label3);
            panelAlta.Controls.Add(tbTipoDocumentoAlta);
            panelAlta.Controls.Add(label1);
            panelAlta.Controls.Add(label2);
            panelAlta.Controls.Add(tbNroDocumentoAlta);
            panelAlta.Controls.Add(lbPagaIVAAlta);
            panelAlta.Controls.Add(tbNombreAlta);
            panelAlta.Controls.Add(lblNombreAlta);
            panelAlta.Controls.Add(lbApellidoAlta);
            panelAlta.Controls.Add(tbEmailAlta);
            panelAlta.Controls.Add(lbTelefonoAlta);
            panelAlta.Controls.Add(tbNacionalidadAlta);
            panelAlta.Controls.Add(lbNacionalidadAlta);
            panelAlta.Controls.Add(tbTelefonoAlta);
            panelAlta.Controls.Add(lbEmailAlta);
            panelAlta.Controls.Add(tbApellidoAlta);
            panelAlta.Controls.Add(btnGuardar);
            panelAlta.Location = new Point(131, 73);
            panelAlta.Name = "panelAlta";
            panelAlta.Size = new Size(586, 286);
            panelAlta.TabIndex = 12;
            // 
            // cbEsSocioAlta
            // 
            cbEsSocioAlta.FormattingEnabled = true;
            cbEsSocioAlta.Items.AddRange(new object[] { "Si", "No" });
            cbEsSocioAlta.Location = new Point(407, 110);
            cbEsSocioAlta.Name = "cbEsSocioAlta";
            cbEsSocioAlta.Size = new Size(158, 23);
            cbEsSocioAlta.TabIndex = 5;
            // 
            // cbPagaIVAAlta
            // 
            cbPagaIVAAlta.FormattingEnabled = true;
            cbPagaIVAAlta.Items.AddRange(new object[] { "Si", "No" });
            cbPagaIVAAlta.Location = new Point(286, 203);
            cbPagaIVAAlta.Name = "cbPagaIVAAlta";
            cbPagaIVAAlta.Size = new Size(158, 23);
            cbPagaIVAAlta.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(314, 113);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 32;
            label3.Text = "Es Socio?";
            // 
            // tbTipoDocumentoAlta
            // 
            tbTipoDocumentoAlta.Location = new Point(111, 25);
            tbTipoDocumentoAlta.Name = "tbTipoDocumentoAlta";
            tbTipoDocumentoAlta.Size = new Size(158, 23);
            tbTipoDocumentoAlta.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 28);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 29;
            label1.Text = "Tipo Documento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 27);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 30;
            label2.Text = "Nº Documento";
            // 
            // tbNroDocumentoAlta
            // 
            tbNroDocumentoAlta.Location = new Point(407, 25);
            tbNroDocumentoAlta.Name = "tbNroDocumentoAlta";
            tbNroDocumentoAlta.Size = new Size(158, 23);
            tbNroDocumentoAlta.TabIndex = 1;
            // 
            // lbPagaIVAAlta
            // 
            lbPagaIVAAlta.AutoSize = true;
            lbPagaIVAAlta.Location = new Point(189, 206);
            lbPagaIVAAlta.Name = "lbPagaIVAAlta";
            lbPagaIVAAlta.Size = new Size(58, 15);
            lbPagaIVAAlta.TabIndex = 26;
            lbPagaIVAAlta.Text = "Paga IVA?";
            // 
            // tbNombreAlta
            // 
            tbNombreAlta.Location = new Point(111, 64);
            tbNombreAlta.Name = "tbNombreAlta";
            tbNombreAlta.Size = new Size(158, 23);
            tbNombreAlta.TabIndex = 2;
            // 
            // lblNombreAlta
            // 
            lblNombreAlta.AutoSize = true;
            lblNombreAlta.Location = new Point(9, 64);
            lblNombreAlta.Name = "lblNombreAlta";
            lblNombreAlta.Size = new Size(51, 15);
            lblNombreAlta.TabIndex = 14;
            lblNombreAlta.Text = "Nombre";
            // 
            // lbApellidoAlta
            // 
            lbApellidoAlta.AutoSize = true;
            lbApellidoAlta.Location = new Point(314, 66);
            lbApellidoAlta.Name = "lbApellidoAlta";
            lbApellidoAlta.Size = new Size(51, 15);
            lbApellidoAlta.TabIndex = 17;
            lbApellidoAlta.Text = "Apellido";
            // 
            // tbEmailAlta
            // 
            tbEmailAlta.Location = new Point(111, 157);
            tbEmailAlta.Name = "tbEmailAlta";
            tbEmailAlta.Size = new Size(158, 23);
            tbEmailAlta.TabIndex = 6;
            // 
            // lbTelefonoAlta
            // 
            lbTelefonoAlta.AutoSize = true;
            lbTelefonoAlta.Location = new Point(313, 160);
            lbTelefonoAlta.Name = "lbTelefonoAlta";
            lbTelefonoAlta.Size = new Size(52, 15);
            lbTelefonoAlta.TabIndex = 20;
            lbTelefonoAlta.Text = "Telefono";
            // 
            // tbNacionalidadAlta
            // 
            tbNacionalidadAlta.Location = new Point(111, 110);
            tbNacionalidadAlta.Name = "tbNacionalidadAlta";
            tbNacionalidadAlta.Size = new Size(158, 23);
            tbNacionalidadAlta.TabIndex = 4;
            // 
            // lbNacionalidadAlta
            // 
            lbNacionalidadAlta.AutoSize = true;
            lbNacionalidadAlta.Location = new Point(9, 113);
            lbNacionalidadAlta.Name = "lbNacionalidadAlta";
            lbNacionalidadAlta.Size = new Size(77, 15);
            lbNacionalidadAlta.TabIndex = 23;
            lbNacionalidadAlta.Text = "Nacionalidad";
            // 
            // tbTelefonoAlta
            // 
            tbTelefonoAlta.Location = new Point(407, 157);
            tbTelefonoAlta.Name = "tbTelefonoAlta";
            tbTelefonoAlta.Size = new Size(158, 23);
            tbTelefonoAlta.TabIndex = 7;
            // 
            // lbEmailAlta
            // 
            lbEmailAlta.AutoSize = true;
            lbEmailAlta.Location = new Point(9, 160);
            lbEmailAlta.Name = "lbEmailAlta";
            lbEmailAlta.Size = new Size(36, 15);
            lbEmailAlta.TabIndex = 24;
            lbEmailAlta.Text = "Email";
            // 
            // tbApellidoAlta
            // 
            tbApellidoAlta.Location = new Point(407, 66);
            tbApellidoAlta.Name = "tbApellidoAlta";
            tbApellidoAlta.Size = new Size(158, 23);
            tbApellidoAlta.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(262, 260);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // tabListado
            // 
            tabListado.Controls.Add(bnRecargarAlta);
            tabListado.Controls.Add(dgvListadoClientes);
            tabListado.Location = new Point(4, 24);
            tabListado.Name = "tabListado";
            tabListado.Padding = new Padding(3);
            tabListado.Size = new Size(859, 458);
            tabListado.TabIndex = 0;
            tabListado.Text = "Listado";
            tabListado.UseVisualStyleBackColor = true;
            // 
            // bnRecargarAlta
            // 
            bnRecargarAlta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bnRecargarAlta.Location = new Point(771, 433);
            bnRecargarAlta.Margin = new Padding(3, 2, 3, 2);
            bnRecargarAlta.Name = "bnRecargarAlta";
            bnRecargarAlta.Size = new Size(82, 24);
            bnRecargarAlta.TabIndex = 1;
            bnRecargarAlta.Text = "Recargar";
            bnRecargarAlta.UseVisualStyleBackColor = true;
            bnRecargarAlta.Click += bnRecargarAlta_Click;
            // 
            // dgvListadoClientes
            // 
            dgvListadoClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListadoClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListadoClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoClientes.Location = new Point(3, 3);
            dgvListadoClientes.Name = "dgvListadoClientes";
            dgvListadoClientes.RowHeadersWidth = 51;
            dgvListadoClientes.Size = new Size(850, 425);
            dgvListadoClientes.TabIndex = 0;
            dgvListadoClientes.CellContentClick += dgvListadoAutores_CellClick;
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
            tabControlPrincipal.TabIndex = 0;
            tabControlPrincipal.SelectedIndexChanged += tabControlPrincipal_SelectedIndexChanged;
            tabControlPrincipal.Selecting += tabControlPrincipal_Selecting;
            // 
            // ABMCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 510);
            Controls.Add(tabControlPrincipal);
            Name = "ABMCliente";
            Text = "Sistema de Gestion de Libreria";
            Load += ABMCliente_Load;
            tabModificacion.ResumeLayout(false);
            panelModificacion.ResumeLayout(false);
            panelModificacion.PerformLayout();
            tabAlta.ResumeLayout(false);
            panelAlta.ResumeLayout(false);
            panelAlta.PerformLayout();
            tabListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListadoClientes).EndInit();
            tabControlPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private TabPage tabModificacion;
        private TabPage tabAlta;
        private TabPage tabListado;
        private DataGridView dgvListadoClientes;
        private TabControl tabControlPrincipal;
        private Button bnRecargarAlta;
        private Panel panelModificacion;
        private TextBox tbNroDocumentoModificacion;
        private Label bvNombreModificacion;
        private Label lbApellidoModificacion;
        private TextBox tbEmailModificacion;
        private Label lbTelefonoModificacion;
        private TextBox tbNacionalidadModificacion;
        private Label lbNacionalidadModificacion;
        private TextBox tbTelefonoModificacion;
        private Label lbEmailModificacion;
        private TextBox tbApellidoModificacion;
        private TextBox tbNombreModificacion;
        private Button btnActualizar;
        private Label lbDocClienteModificacion;
        private Panel panelAlta;
        private Label lbPagaIVAAlta;
        private TextBox tbNombreAlta;
        private Label lblNombreAlta;
        private Label lbApellidoAlta;
        private TextBox tbEmailAlta;
        private Label lbTelefonoAlta;
        private TextBox tbNacionalidadAlta;
        private Label lbNacionalidadAlta;
        private TextBox tbTelefonoAlta;
        private Label lbEmailAlta;
        private TextBox tbApellidoAlta;
        private Button btnGuardar;
        private TextBox tbTipoDocumentoAlta;
        private Label label1;
        private Label label2;
        private TextBox tbNroDocumentoAlta;
        private Label label3;
        private ComboBox cbEsSocioAlta;
        private ComboBox cbPagaIVAAlta;
        private TextBox tbTipoDocumentoModificacion;
        private Label label4;
        private ComboBox cbEsSocioModificacion;
        private ComboBox cbPagaIVAModificacion;
        private Label label5;
        private Label label6;
    }
}