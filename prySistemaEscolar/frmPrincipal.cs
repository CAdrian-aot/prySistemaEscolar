using prySistemaEscolar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pry_LOGINNN
{
    public partial class frmPrincipal : Form
    {
        ClsPrincipal principal;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void pcbGeneral_MouseDown(object miPicture, MouseEventArgs e)
        {
            PictureBox pcb = (PictureBox)miPicture;
            pcb.Location = new Point(pcb.Location.X + 3, pcb.Location.Y + 3);
        }

        private void pcbGeneral_MouseUp(object miPicture, MouseEventArgs e)
        {
            PictureBox pcb = (PictureBox)miPicture;
            pcb.Location = new Point(pcb.Location.X - 3, pcb.Location.Y - 3);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Cambiando el parent de los picture
            pcbAlumnos.Parent = pcbMenu;
            pcbCarreras.Parent = pcbMenu;
            pcbDocentes.Parent = pcbMenu;
            pcbUsuarios.Parent = pcbMenu;
            pcbTutores.Parent = pcbMenu;
            pcbAlumnos.BackColor = Color.Transparent;
            pcbCarreras.BackColor = Color.Transparent;
            pcbDocentes.BackColor = Color.Transparent;
            pcbUsuarios.BackColor = Color.Transparent;
            pcbTutores.BackColor = Color.Transparent;

            // Vrerificando permisos
            pcbCarreras.Enabled = clsLogin.EsAdmin;
            pcbDocentes.Enabled = clsLogin.EsAdmin;
            pcbUsuarios.Enabled = clsLogin.EsAdmin;
            pcbAlumnos.Enabled = clsLogin.EsAdmin || clsLogin.EsDocente;
        }

        private void pcbCarreras_Click(object sender, EventArgs e)
        {
            principal = new ClsPrincipal();
            principal.agregarAlcontenedor(new frmCarreras(), pnlContenedor);
        }

        private void pcbTutores_Click(object sender, EventArgs e)
        {
            principal= new ClsPrincipal();
            principal.agregarAlcontenedor(new frmTutores(), pnlContenedor);
        }
    
    }
}
