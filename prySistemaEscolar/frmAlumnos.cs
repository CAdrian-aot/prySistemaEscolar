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
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
            CargarGrid();
            cargarCombos();
        }

        public void cargarCombos()
        {
            clsAlumnos alumnos = new clsAlumnos();

            try
            {
                DataTable dtCarreras = alumnos.ObtenerCarreras();
                // creamos la fila del planceholder para la carrera
                DataRow filaPCarrera = dtCarreras.NewRow();
                filaPCarrera["idcarrera"] = 0;
                filaPCarrera["nombreCarrera"] = "-- Selecciona una Carrera --";
                filaPCarrera.Rows.InsertAt(filaPCarrera, 0);

                //Enlazados los datos al comboBox visual
                cmbCarrera.DataSource = dtCarreras;
                cmbCarrera.DisplayMenber = "nombreCarrera";// El texto visible
                cmbCarrera.ValueMenber = "idcarrera";      //La llave primaria real
                cmbCarrera.SelectedIndex = 0;          // Forzar a que muestre el placeholder

                DataTable dtTutores = alumnos.ObtenerTutores();
                // creamos la fila del planceholder para la carrera
                DataRow filaPTutores = dtTutores.NewRow();
                filaPTutores["idTutores"] = 0;
                filaPTutores["nombreTutores"] = "-- Selecciona un Tutoro --";
                filaPTutores.Rows.InsertAt(filaPTutores, 0);

                //Enlazados los datos al comboBox visual
                 cmbTutor.DataSource = dtTutores;
                 cmbTutor.DisplayMenber = "nombreTutores";// El texto visible
                 cmbTutor.ValueMenber = "idTutores";      //La llave primaria real
                 cmbTutor.SelectedIndex = 0;          // Forzar a que muestre el placeholder
            }
            catch (Exception ex)
            {
                throw new Exception("Error al rellenar los catálogos en los menús desplegables:" + ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreCarreras_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
