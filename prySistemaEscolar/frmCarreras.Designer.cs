namespace prySistemaEscolar
{
    partial class frmCarreras
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pnlDatos = new Panel();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            txtDescripcion = new TextBox();
            txtNombreCarrera = new TextBox();
            txtNombreCarreras = new TextBox();
            dgvCarreras = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.carreras;
            pictureBox1.Location = new Point(790, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(458, 31);
            label1.Name = "label1";
            label1.Size = new Size(266, 81);
            label1.TabIndex = 1;
            label1.Text = "Carreras";
            // 
            // pnlDatos
            // 
            pnlDatos.Controls.Add(btnNuevo);
            pnlDatos.Controls.Add(btnEliminar);
            pnlDatos.Controls.Add(btnGuardar);
            pnlDatos.Controls.Add(txtDescripcion);
            pnlDatos.Controls.Add(txtNombreCarrera);
            pnlDatos.Location = new Point(150, 175);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(941, 247);
            pnlDatos.TabIndex = 2;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.Nuevox;
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(588, 170);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(121, 68);
            btnNuevo.TabIndex = 4;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.Eliminarx;
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(406, 170);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(121, 68);
            btnEliminar.TabIndex = 3;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.Guardarx;
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(218, 170);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(121, 68);
            btnGuardar.TabIndex = 2;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(218, 103);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Escribir una descripción de la carrera";
            txtDescripcion.Size = new Size(491, 43);
            txtDescripcion.TabIndex = 1;
            // 
            // txtNombreCarrera
            // 
            txtNombreCarrera.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreCarrera.Location = new Point(218, 13);
            txtNombreCarrera.Name = "txtNombreCarrera";
            txtNombreCarrera.PlaceholderText = "Escribir el nombre de la carrera";
            txtNombreCarrera.Size = new Size(491, 43);
            txtNombreCarrera.TabIndex = 0;
            // 
            // txtNombreCarreras
            // 
            txtNombreCarreras.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreCarreras.Location = new Point(852, 428);
            txtNombreCarreras.Name = "txtNombreCarreras";
            txtNombreCarreras.PlaceholderText = "Buscar carrera";
            txtNombreCarreras.Size = new Size(239, 43);
            txtNombreCarreras.TabIndex = 4;
            txtNombreCarreras.TextChanged += txtNombreCarreras_TextChanged;
            // 
            // dgvCarreras
            // 
            dgvCarreras.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCarreras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCarreras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Teal;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCarreras.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCarreras.EnableHeadersVisualStyles = false;
            dgvCarreras.Location = new Point(150, 477);
            dgvCarreras.Name = "dgvCarreras";
            dgvCarreras.RowHeadersWidth = 51;
            dgvCarreras.RowTemplate.Height = 35;
            dgvCarreras.Size = new Size(941, 133);
            dgvCarreras.TabIndex = 3;
            // 
            // frmCarreras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondox;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1223, 654);
            Controls.Add(txtNombreCarreras);
            Controls.Add(dgvCarreras);
            Controls.Add(pnlDatos);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "frmCarreras";
            Text = "frmCarreras";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel pnlDatos;
        private TextBox txtDescripcion;
        private TextBox txtNombreCarrera;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnGuardar;
        private TextBox txtNombreCarreras;
        private DataGridView dgvCarreras;
    }
}