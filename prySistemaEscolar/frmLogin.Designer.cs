namespace prySistemaEscolar
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pcbLogin = new PictureBox();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnAcceder = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbLogin).BeginInit();
            SuspendLayout();
            // 
            // pcbLogin
            // 
            pcbLogin.Image = (Image)resources.GetObject("pcbLogin.Image");
            pcbLogin.Location = new Point(12, 11);
            pcbLogin.Name = "pcbLogin";
            pcbLogin.Size = new Size(280, 280);
            pcbLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogin.TabIndex = 0;
            pcbLogin.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtUsuario.Location = new Point(392, 55);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Nombre de usuario";
            txtUsuario.Size = new Size(301, 34);
            txtUsuario.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtPassword.Location = new Point(392, 130);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña de usuario";
            txtPassword.Size = new Size(301, 34);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnAcceder
            // 
            btnAcceder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAcceder.Location = new Point(392, 206);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(130, 39);
            btnAcceder.TabIndex = 5;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalir.Location = new Point(563, 206);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(130, 39);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 303);
            Controls.Add(btnSalir);
            Controls.Add(btnAcceder);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(pcbLogin);
            Name = "frmLogin";
            Text = "Control de acceso";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pcbLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbLogin;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnAcceder;
        private Button btnSalir;
    }
}
