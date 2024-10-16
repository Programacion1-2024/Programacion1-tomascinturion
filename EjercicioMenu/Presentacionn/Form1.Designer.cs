namespace Presentacionn
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btCerrarSesion = new Button();
            pbConfiguracion = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbConfiguracion).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(btCerrarSesion);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 451);
            panel1.TabIndex = 0;
            // 
            // btCerrarSesion
            // 
            btCerrarSesion.BackColor = Color.LightGray;
            btCerrarSesion.Location = new Point(12, 415);
            btCerrarSesion.Name = "btCerrarSesion";
            btCerrarSesion.Size = new Size(114, 23);
            btCerrarSesion.TabIndex = 0;
            btCerrarSesion.Text = "Cerrar Sesión";
            btCerrarSesion.UseVisualStyleBackColor = false;
            btCerrarSesion.Click += btCerrarSesion_Click;
            // 
            // pbConfiguracion
            // 
            pbConfiguracion.BackColor = SystemColors.WindowText;
            pbConfiguracion.ErrorImage = (Image)resources.GetObject("pbConfiguracion.ErrorImage");
            pbConfiguracion.Image = (Image)resources.GetObject("pbConfiguracion.Image");
            pbConfiguracion.InitialImage = (Image)resources.GetObject("pbConfiguracion.InitialImage");
            pbConfiguracion.Location = new Point(733, 12);
            pbConfiguracion.Name = "pbConfiguracion";
            pbConfiguracion.Size = new Size(55, 55);
            pbConfiguracion.TabIndex = 0;
            pbConfiguracion.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbConfiguracion);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbConfiguracion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbConfiguracion;
        private Button btCerrarSesion;
    }
}
