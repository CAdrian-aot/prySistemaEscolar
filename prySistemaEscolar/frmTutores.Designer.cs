namespace prySistemaEscolar
{
    partial class frmTutores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTutores));
            pcbLogo = new PictureBox();
            lblTitulo = new Label();
            pnlAgrupaControles = new Panel();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtParentesco = new TextBox();
            txtNombreTutor = new TextBox();
            dgvTutores = new DataGridView();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            pnlAgrupaControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTutores).BeginInit();
            SuspendLayout();
            // 
            // pcbLogo
            // 
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(708, 24);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(107, 92);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 0;
            pcbLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(416, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(244, 81);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Tutores";
            // 
            // pnlAgrupaControles
            // 
            pnlAgrupaControles.Controls.Add(btnNuevo);
            pnlAgrupaControles.Controls.Add(btnEliminar);
            pnlAgrupaControles.Controls.Add(btnGuardar);
            pnlAgrupaControles.Controls.Add(txtCorreo);
            pnlAgrupaControles.Controls.Add(txtTelefono);
            pnlAgrupaControles.Controls.Add(txtDireccion);
            pnlAgrupaControles.Controls.Add(txtParentesco);
            pnlAgrupaControles.Controls.Add(txtNombreTutor);
            pnlAgrupaControles.Location = new Point(225, 122);
            pnlAgrupaControles.Name = "pnlAgrupaControles";
            pnlAgrupaControles.Size = new Size(800, 322);
            pnlAgrupaControles.TabIndex = 2;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(577, 256);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(127, 59);
            btnNuevo.TabIndex = 7;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(324, 256);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(127, 59);
            btnEliminar.TabIndex = 6;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(77, 256);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(127, 59);
            btnGuardar.TabIndex = 5;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(77, 210);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Escribir el correo";
            txtCorreo.Size = new Size(627, 43);
            txtCorreo.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            txtTelefono.Location = new Point(77, 161);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Escribir el teléfono";
            txtTelefono.Size = new Size(627, 43);
            txtTelefono.TabIndex = 3;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            txtDireccion.Location = new Point(77, 114);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Escribir la dirección";
            txtDireccion.Size = new Size(627, 43);
            txtDireccion.TabIndex = 2;
            // 
            // txtParentesco
            // 
            txtParentesco.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            txtParentesco.Location = new Point(77, 64);
            txtParentesco.Name = "txtParentesco";
            txtParentesco.PlaceholderText = "Escribir el parentesco";
            txtParentesco.Size = new Size(627, 43);
            txtParentesco.TabIndex = 1;
            // 
            // txtNombreTutor
            // 
            txtNombreTutor.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreTutor.Location = new Point(77, 15);
            txtNombreTutor.Name = "txtNombreTutor";
            txtNombreTutor.PlaceholderText = "Escribir el nombre del tutor";
            txtNombreTutor.Size = new Size(627, 43);
            txtNombreTutor.TabIndex = 0;
            txtNombreTutor.TextChanged += txtNombreTutor_TextChanged;
            // 
            // dgvTutores
            // 
            dgvTutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTutores.Location = new Point(225, 493);
            dgvTutores.Name = "dgvTutores";
            dgvTutores.RowHeadersWidth = 51;
            dgvTutores.Size = new Size(800, 126);
            dgvTutores.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(754, 450);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar tutor";
            textBox1.Size = new Size(269, 43);
            textBox1.TabIndex = 4;
            // 
            // frmTutores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1223, 654);
            Controls.Add(textBox1);
            Controls.Add(dgvTutores);
            Controls.Add(pnlAgrupaControles);
            Controls.Add(lblTitulo);
            Controls.Add(pcbLogo);
            DoubleBuffered = true;
            Name = "frmTutores";
            Text = "Registro de Tutores";
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            pnlAgrupaControles.ResumeLayout(false);
            pnlAgrupaControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTutores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbLogo;
        private Label lblTitulo;
        private Panel pnlAgrupaControles;
        private TextBox txtParentesco;
        private TextBox txtNombreTutor;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtCorreo;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnGuardar;
        private DataGridView dgvTutores;
        private TextBox textBox1;
    }
}