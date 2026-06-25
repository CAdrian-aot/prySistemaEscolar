using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySistemaEscolar
{
    public partial class frmTutores : Form
    {
        clsTutores tutores;
        int idTutor;
        public frmTutores()
        {
            InitializeComponent();
            CargarGrid();
        }

        public void CargarGrid()
        {
            tutores = new clsTutores();
            dgvTutores.DataSource = null;
            dgvTutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvTutores.DataSource = tutores.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtNombreTutor_TextChanged(object sender, EventArgs e)
        {
            tutores = new clsTutores();
            dgvTutores.DataSource = null;
            dgvTutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                tutores.NombreTutor = txtNombreTutor.Text;
                dgvTutores.DataSource = tutores.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
