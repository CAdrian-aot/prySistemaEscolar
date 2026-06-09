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
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void pcbAlumnos_MouseDown(object sender, MouseEventArgs e)
        {
            pcbAlumnos.Location = new Point(pcbAlumnos.Location.X + 3, pcbAlumnos.Location.Y + 3);
        }

        private void pcbAlumnos_MouseUp(object sender, MouseEventArgs e)
        {
            pcbAlumnos.Location = new Point(pcbAlumnos.Location.X - 3, pcbAlumnos.Location.Y - 3);

        }

        private void pcbDocentes_MouseDown(object sender, MouseEventArgs e)
        {
            pcbDocentes.Location = new Point(pcbDocentes.Location.X + 3, pcbDocentes.Location.Y + 3);
        }

        private void pcbDocentes_MouseUp(object sender, MouseEventArgs e)
        {
            pcbDocentes.Location = new Point(pcbDocentes.Location.X - 3, pcbDocentes.Location.Y - 3);
        }

        private void pcbCarreras_MouseDown(object sender, MouseEventArgs e)
        {
            pcbCarreras.Location = new Point(pcbCarreras.Location.X + 3, pcbCarreras.Location.Y + 3);
        }

        private void pcbCarreras_MouseUp(object sender, MouseEventArgs e)
        {
            pcbCarreras.Location = new Point(pcbCarreras.Location.X - 3, pcbCarreras.Location.Y - 3);
        }

        private void pcbUsuarios_MouseDown(object sender, MouseEventArgs e)
        {
            pcbUsuarios.Location = new Point(pcbUsuarios.Location.X + 3, pcbUsuarios.Location.Y + 3);

        }

        private void pcbUsuarios_MouseUp(object sender, MouseEventArgs e)
        {
            pcbUsuarios.Location = new Point(pcbUsuarios.Location.X - 3, pcbUsuarios.Location.Y - 3);
        }
    }
}
