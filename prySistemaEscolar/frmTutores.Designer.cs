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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pcbLogo = new PictureBox();
            lblTitulo = new Label();
            pnlAgrupaControles = new Panel();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            txtNombreTutor = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtParentesco = new TextBox();
            txtBuscarTutor = new TextBox();
            dgvTutores = new DataGridView();
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
            pnlAgrupaControles.Controls.Add(txtNombreTutor);
            pnlAgrupaControles.Controls.Add(txtCorreo);
            pnlAgrupaControles.Controls.Add(txtTelefono);
            pnlAgrupaControles.Controls.Add(txtDireccion);
            pnlAgrupaControles.Controls.Add(txtParentesco);
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
            btnNuevo.Click += btnNuevo_Click;
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
            btnEliminar.Click += btnEliminar_Click;
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
            // txtNombreTutor
            // 
            txtNombreTutor.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreTutor.Location = new Point(77, 15);
            txtNombreTutor.Name = "txtNombreTutor";
            txtNombreTutor.PlaceholderText = "Escribir nombre del tutor";
            txtNombreTutor.Size = new Size(627, 43);
            txtNombreTutor.TabIndex = 0;
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
            // txtBuscarTutor
            // 
            txtBuscarTutor.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscarTutor.Location = new Point(841, 444);
            txtBuscarTutor.Name = "txtBuscarTutor";
            txtBuscarTutor.PlaceholderText = "Buscar tutor";
            txtBuscarTutor.Size = new Size(184, 43);
            txtBuscarTutor.TabIndex = 4;
            txtBuscarTutor.TextChanged += txtBuscarTutor_TextChanged;
            // 
            // dgvTutores
            // 
            dgvTutores.AllowUserToAddRows = false;
            dgvTutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvTutores.DefaultCellStyle = dataGridViewCellStyle1;
            dgvTutores.Location = new Point(225, 493);
            dgvTutores.Name = "dgvTutores";
            dgvTutores.RowHeadersWidth = 51;
            dgvTutores.Size = new Size(800, 126);
            dgvTutores.TabIndex = 3;
            dgvTutores.SelectionChanged += dgvTutores_SelectionChanged;
            // 
            // frmTutores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1223, 654);
            Controls.Add(txtBuscarTutor);
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
        private TextBox txtBuscarTutor;
    }
}