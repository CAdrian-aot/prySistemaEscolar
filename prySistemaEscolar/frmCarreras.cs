using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prySistemaEscolar
{
    public partial class frmCarreras : Form
    {
        clsCarreras carreras;
        int idCarrera;

        public frmCarreras()
        {
            InitializeComponent();
            CargarGrid();
        }
        public void CargarGrid()
        {
            carreras = new clsCarreras();
            dgvCarreras.DataSource = null;
            dgvCarreras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvCarreras.DataSource = carreras.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtNombreCarreras_TextChanged(object sender, EventArgs e)
        {
            carreras = new clsCarreras();
            dgvCarreras.DataSource = null;
            dgvCarreras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                carreras.NombreCarrera = txtNombreCarreras.Text;
                dgvCarreras.DataSource = carreras.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCarreras_SelectionChanged(object sender, EventArgs e)
        {
            //Campo oculto que sirve de referencia y actualizar
            idCarrera = int.Parse(dgvCarreras.CurrentRow.Cells[0].Value.ToString());
            //Visuales
            txtNombreCarrera.Text = dgvCarreras.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dgvCarreras.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                int tipoOperacion = idCarrera == 0 ? 0 : 1;
                carreras.IdCarrera = idCarrera;
                carreras.NombreCarrera = txtNombreCarrera.Text;
                carreras.Descripcion = txtDescripcion.Text;
                string msg = "";
                if (tipoOperacion != 0)
                {
                    var resp = MessageBox.Show("Confirmar que desea eliminar el dato seleccionado", "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        msg = carreras.GuardarActualizar(tipoOperacion);
                        MessageBox.Show(msg);
                    }
                }
                else
                {
                    msg = carreras.GuardarActualizar(tipoOperacion);
                    MessageBox.Show(msg);
                }
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            {
                idCarrera = 0;
                txtNombreCarrera.Clear();
                txtDescripcion.Clear();
                txtNombreCarrera.Focus();
            }

        }
    }
}
