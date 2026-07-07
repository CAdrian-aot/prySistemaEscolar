namespace prySistemaEscolar
{
    partial class frmDocentes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocentes));
            label3 = new Label();
            txtBuscarClave = new TextBox();
            dgvDocentes = new DataGridView();
            pictureBox1 = new PictureBox();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            label2 = new Label();
            label1 = new Label();
            pnlUsuario = new Panel();
            cmbPerfil = new ComboBox();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            pnlDocente = new Panel();
            cmbPuesto = new ComboBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            txtClave = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlUsuario.SuspendLayout();
            pnlDocente.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(366, 9);
            label3.Name = "label3";
            label3.Size = new Size(294, 81);
            label3.TabIndex = 31;
            label3.Text = "Docentes";
            // 
            // txtBuscarClave
            // 
            txtBuscarClave.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscarClave.Location = new Point(856, 447);
            txtBuscarClave.Name = "txtBuscarClave";
            txtBuscarClave.PlaceholderText = "Buscar por clave";
            txtBuscarClave.Size = new Size(291, 43);
            txtBuscarClave.TabIndex = 29;
            txtBuscarClave.TextChanged += txtBuscarClave_TextChanged;
            // 
            // dgvDocentes
            // 
            dgvDocentes.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDocentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDocentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Teal;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDocentes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDocentes.EnableHeadersVisualStyles = false;
            dgvDocentes.Location = new Point(76, 496);
            dgvDocentes.Name = "dgvDocentes";
            dgvDocentes.RowHeadersWidth = 51;
            dgvDocentes.RowTemplate.Height = 35;
            dgvDocentes.Size = new Size(1071, 133);
            dgvDocentes.TabIndex = 28;
            dgvDocentes.SelectionChanged += dgvDocentes_SelectionChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(666, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.Eliminarx;
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(511, 415);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(121, 68);
            btnEliminar.TabIndex = 26;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.Guardarx;
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(359, 415);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(121, 68);
            btnGuardar.TabIndex = 25;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.Nuevox;
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(661, 415);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(121, 68);
            btnNuevo.TabIndex = 27;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(621, 119);
            label2.Name = "label2";
            label2.Size = new Size(97, 31);
            label2.TabIndex = 24;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(177, 119);
            label1.Name = "label1";
            label1.Size = new Size(103, 31);
            label1.TabIndex = 23;
            label1.Text = "Docente";
            // 
            // pnlUsuario
            // 
            pnlUsuario.BackColor = SystemColors.ActiveCaption;
            pnlUsuario.Controls.Add(cmbPerfil);
            pnlUsuario.Controls.Add(txtPassword);
            pnlUsuario.Controls.Add(txtUsuario);
            pnlUsuario.Location = new Point(621, 153);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(416, 250);
            pnlUsuario.TabIndex = 22;
            // 
            // cmbPerfil
            // 
            cmbPerfil.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Items.AddRange(new object[] { "Administrador", "Alumno", "Docente", "Tutor" });
            cmbPerfil.Location = new Point(45, 112);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(336, 39);
            cmbPerfil.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtPassword.Location = new Point(45, 68);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(336, 38);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtUsuario.Location = new Point(45, 24);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(336, 38);
            txtUsuario.TabIndex = 10;
            // 
            // pnlDocente
            // 
            pnlDocente.BackColor = SystemColors.ActiveCaption;
            pnlDocente.Controls.Add(cmbPuesto);
            pnlDocente.Controls.Add(txtCorreo);
            pnlDocente.Controls.Add(txtTelefono);
            pnlDocente.Controls.Add(txtNombre);
            pnlDocente.Controls.Add(txtClave);
            pnlDocente.Location = new Point(177, 153);
            pnlDocente.Name = "pnlDocente";
            pnlDocente.Size = new Size(391, 250);
            pnlDocente.TabIndex = 21;
            // 
            // cmbPuesto
            // 
            cmbPuesto.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            cmbPuesto.FormattingEnabled = true;
            cmbPuesto.Items.AddRange(new object[] { "-Selecciona el puesto-", "Profesor", "Coordinador" });
            cmbPuesto.Location = new Point(49, 106);
            cmbPuesto.Name = "cmbPuesto";
            cmbPuesto.Size = new Size(297, 39);
            cmbPuesto.TabIndex = 10;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtCorreo.Location = new Point(49, 195);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(297, 38);
            txtCorreo.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtTelefono.Location = new Point(49, 151);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(297, 38);
            txtTelefono.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtNombre.Location = new Point(49, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(297, 38);
            txtNombre.TabIndex = 1;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtClave.Location = new Point(49, 19);
            txtClave.Name = "txtClave";
            txtClave.PlaceholderText = "Clave";
            txtClave.Size = new Size(297, 38);
            txtClave.TabIndex = 0;
            // 
            // frmDocentes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 654);
            Controls.Add(label3);
            Controls.Add(txtBuscarClave);
            Controls.Add(dgvDocentes);
            Controls.Add(pictureBox1);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlUsuario);
            Controls.Add(pnlDocente);
            Name = "frmDocentes";
            Text = "frmDocentes";
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlUsuario.ResumeLayout(false);
            pnlUsuario.PerformLayout();
            pnlDocente.ResumeLayout(false);
            pnlDocente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtBuscarClave;
        private DataGridView dgvDocentes;
        private PictureBox pictureBox1;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
        private Label label2;
        private Label label1;
        private Panel pnlUsuario;
        private ComboBox cmbPerfil;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private Panel pnlDocente;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtAPaterno;
        private TextBox txtNombre;
        private TextBox txtClave;
        private ComboBox cmbPuesto;
    }
}