namespace prySistemaEscolar
{
    partial class frmAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumnos));
            txtMatricula = new TextBox();
            tctNombre = new TextBox();
            txtAPaterno = new TextBox();
            txtAMaterno = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtPromedioBachiller = new TextBox();
            cmbTutor = new ComboBox();
            cmbCarrera = new ComboBox();
            pnlAlumnos = new Panel();
            pnlUsuarios = new Panel();
            cmbPerfil = new ComboBox();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            txtNombreAlumno = new TextBox();
            dgvAlumnos = new DataGridView();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pnlAlumnos.SuspendLayout();
            pnlUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtMatricula
            // 
            txtMatricula.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtMatricula.Location = new Point(22, 19);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PlaceholderText = "Matricula";
            txtMatricula.Size = new Size(217, 38);
            txtMatricula.TabIndex = 0;
            // 
            // tctNombre
            // 
            tctNombre.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            tctNombre.Location = new Point(22, 63);
            tctNombre.Name = "tctNombre";
            tctNombre.PlaceholderText = "Nombre";
            tctNombre.Size = new Size(217, 38);
            tctNombre.TabIndex = 1;
            // 
            // txtAPaterno
            // 
            txtAPaterno.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtAPaterno.Location = new Point(22, 107);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.PlaceholderText = "Apellido Paterno";
            txtAPaterno.Size = new Size(217, 38);
            txtAPaterno.TabIndex = 2;
            // 
            // txtAMaterno
            // 
            txtAMaterno.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtAMaterno.Location = new Point(22, 151);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.PlaceholderText = "Apellido Materno";
            txtAMaterno.Size = new Size(217, 38);
            txtAMaterno.TabIndex = 3;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtDireccion.Location = new Point(22, 195);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Direccion";
            txtDireccion.Size = new Size(217, 38);
            txtDireccion.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtTelefono.Location = new Point(325, 19);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(217, 38);
            txtTelefono.TabIndex = 5;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtCorreo.Location = new Point(325, 64);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(217, 38);
            txtCorreo.TabIndex = 6;
            // 
            // txtPromedioBachiller
            // 
            txtPromedioBachiller.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtPromedioBachiller.Location = new Point(325, 108);
            txtPromedioBachiller.Name = "txtPromedioBachiller";
            txtPromedioBachiller.PlaceholderText = "Promedio Bachiller";
            txtPromedioBachiller.Size = new Size(217, 38);
            txtPromedioBachiller.TabIndex = 7;
            // 
            // cmbTutor
            // 
            cmbTutor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            cmbTutor.FormattingEnabled = true;
            cmbTutor.Location = new Point(325, 151);
            cmbTutor.Name = "cmbTutor";
            cmbTutor.Size = new Size(217, 39);
            cmbTutor.TabIndex = 8;
            cmbTutor.SelectedIndexChanged += cmbTutor_SelectedIndexChanged;
            // 
            // cmbCarrera
            // 
            cmbCarrera.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(325, 196);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(217, 39);
            cmbCarrera.TabIndex = 9;
            // 
            // pnlAlumnos
            // 
            pnlAlumnos.BackColor = SystemColors.ActiveCaption;
            pnlAlumnos.Controls.Add(cmbCarrera);
            pnlAlumnos.Controls.Add(cmbTutor);
            pnlAlumnos.Controls.Add(txtPromedioBachiller);
            pnlAlumnos.Controls.Add(txtCorreo);
            pnlAlumnos.Controls.Add(txtTelefono);
            pnlAlumnos.Controls.Add(txtDireccion);
            pnlAlumnos.Controls.Add(txtAMaterno);
            pnlAlumnos.Controls.Add(txtAPaterno);
            pnlAlumnos.Controls.Add(tctNombre);
            pnlAlumnos.Controls.Add(txtMatricula);
            pnlAlumnos.Location = new Point(105, 131);
            pnlAlumnos.Name = "pnlAlumnos";
            pnlAlumnos.Size = new Size(583, 250);
            pnlAlumnos.TabIndex = 10;
            // 
            // pnlUsuarios
            // 
            pnlUsuarios.BackColor = SystemColors.ActiveCaption;
            pnlUsuarios.Controls.Add(cmbPerfil);
            pnlUsuarios.Controls.Add(txtPassword);
            pnlUsuarios.Controls.Add(txtUsuario);
            pnlUsuarios.Location = new Point(760, 131);
            pnlUsuarios.Name = "pnlUsuarios";
            pnlUsuarios.Size = new Size(416, 250);
            pnlUsuarios.TabIndex = 11;
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
            cmbPerfil.SelectedIndexChanged += cmbPerfil_SelectedIndexChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtPassword.Location = new Point(45, 68);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(336, 38);
            txtPassword.TabIndex = 11;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 97);
            label1.Name = "label1";
            label1.Size = new Size(100, 31);
            label1.TabIndex = 12;
            label1.Text = "Alumno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(760, 97);
            label2.Name = "label2";
            label2.Size = new Size(97, 31);
            label2.TabIndex = 13;
            label2.Text = "Usuario";
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.Nuevox;
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(717, 393);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(121, 68);
            btnNuevo.TabIndex = 16;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.Eliminarx;
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(567, 393);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(121, 68);
            btnEliminar.TabIndex = 15;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.Guardarx;
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(415, 393);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(121, 68);
            btnGuardar.TabIndex = 14;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtNombreAlumno
            // 
            txtNombreAlumno.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreAlumno.Location = new Point(909, 447);
            txtNombreAlumno.Name = "txtNombreAlumno";
            txtNombreAlumno.PlaceholderText = "Buscar Alumno";
            txtNombreAlumno.Size = new Size(239, 43);
            txtNombreAlumno.TabIndex = 18;
            txtNombreAlumno.TextChanged += txtNombreCarreras_TextChanged;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Teal;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAlumnos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAlumnos.EnableHeadersVisualStyles = false;
            dgvAlumnos.Location = new Point(105, 496);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.RowTemplate.Height = 35;
            dgvAlumnos.Size = new Size(1071, 133);
            dgvAlumnos.TabIndex = 17;
            dgvAlumnos.CellContentClick += dgvAlumnos_CellContentClick;
            dgvAlumnos.SelectionChanged += dgvAlumnos_SelectionChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(303, 47);
            label3.Name = "label3";
            label3.Size = new Size(284, 81);
            label3.TabIndex = 20;
            label3.Text = "Alumnos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(593, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // frmAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 654);
            Controls.Add(label3);
            Controls.Add(txtNombreAlumno);
            Controls.Add(dgvAlumnos);
            Controls.Add(pictureBox1);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlUsuarios);
            Controls.Add(pnlAlumnos);
            Name = "frmAlumnos";
            Text = "Registro de alumnos";
            pnlAlumnos.ResumeLayout(false);
            pnlAlumnos.PerformLayout();
            pnlUsuarios.ResumeLayout(false);
            pnlUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMatricula;
        private TextBox tctNombre;
        private TextBox txtAPaterno;
        private TextBox txtAMaterno;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtPromedioBachiller;
        private ComboBox cmbTutor;
        private ComboBox cmbCarrera;
        private Panel pnlAlumnos;
        private ComboBox cmbPerfil;
        private Panel pnlUsuarios;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private Label label1;
        private Label label2;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnGuardar;
        private TextBox txtNombreAlumno;
        private DataGridView dgvAlumnos;
        private Label label3;
        private PictureBox pictureBox1;
    }
}