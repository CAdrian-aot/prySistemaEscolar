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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pnlDatos = new Panel();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            txtDescripcion = new TextBox();
            txtNombreCarrera = new TextBox();
            dgvCarreras = new DataGridView();
            textBox3 = new TextBox();
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
            // dgvCarreras
            // 
            dgvCarreras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarreras.Location = new Point(150, 477);
            dgvCarreras.Name = "dgvCarreras";
            dgvCarreras.RowHeadersWidth = 51;
            dgvCarreras.Size = new Size(941, 145);
            dgvCarreras.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(852, 428);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Buscar carrera";
            textBox3.Size = new Size(239, 43);
            textBox3.TabIndex = 4;
            // 
            // frmCarreras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondox;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1223, 654);
            Controls.Add(textBox3);
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
        private DataGridView dgvCarreras;
        private TextBox textBox3;
    }
}