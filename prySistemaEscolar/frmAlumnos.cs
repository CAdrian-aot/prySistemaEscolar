using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySistemaEscolar
{
    public partial class frmAlumnos : Form
    {
        clsAlumnos alumnos;

        int idMatricula;
        int idUsuario;
        public frmAlumnos()
        {
            InitializeComponent();
            cargarGrid();
            cargarCombos();
        }

        public void cargarGrid()
        {
            clsAlumnos alumnos = new clsAlumnos();
            dgvAlumnos.DataSource = null;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvAlumnos.DataSource = alumnos.CargarDataGrid();
                dgvAlumnos.Columns["Usuario"].Visible = false;
                dgvAlumnos.Columns["direccion"].Visible = false;
                dgvAlumnos.Columns["telefono"].Visible = false;
                dgvAlumnos.Columns["correo"].Visible = false;
                dgvAlumnos.Columns["promedioBachillerato"].Visible = false;
                dgvAlumnos.Columns["vchpassword"].Visible = false;
                dgvAlumnos.Columns["vchperfil"].Visible = false;
                dgvAlumnos.Columns["idTutor"].Visible = false;
                dgvAlumnos.Columns["idCarrera"].Visible = false;
                dgvAlumnos.Columns["idUsuario"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                dtCarreras.Rows.InsertAt(filaPCarrera, 0);

                //Enlazados los datos al comboBox visual
                cmbCarrera.DataSource = dtCarreras;
                cmbCarrera.DisplayMember = "nombreCarrera";// El texto visible
                cmbCarrera.ValueMember = "idcarrera";      //La llave primaria real
                cmbCarrera.SelectedIndex = 0;          // Forzar a que muestre el placeholder

                DataTable dtTutores = alumnos.ObtenerTutores();
                // creamos la fila del planceholder para la carrera
                DataRow filaPTutores = dtTutores.NewRow();
                filaPTutores["idTutor"] = 0;
                filaPTutores["nombreTutor"] = "-- Selecciona un Tutoro --";
                dtTutores.Rows.InsertAt(filaPTutores, 0);

                //Enlazados los datos al comboBox visual
                cmbTutor.DataSource = dtTutores;
                cmbTutor.DisplayMember = "nombreTutor";// El texto visible
                cmbTutor.ValueMember = "idTutor";      //La llave primaria real
                cmbTutor.SelectedIndex = 0;          // Forzar a que muestre el placeholder
            }
            catch (Exception ex)
            {
                throw new Exception("Error al rellenar los catálogos en los menús desplegables:" + ex.Message);
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            alumnos = new clsAlumnos();

            idMatricula = 0;
            idUsuario = 0;
            alumnos.LimpiarPanel(pnlAlumnos);
            alumnos.LimpiarPanel(pnlUsuarios);
            txtMatricula.Focus();
        }
        private void txtNombreAlumno_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarMatricula.Text))
            {
                cargarGrid();
                return;
            }
            alumnos = new clsAlumnos();
            dgvAlumnos.DataSource = null;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                alumnos.Matricula = int.Parse(txtBuscarMatricula.Text);
                dgvAlumnos.DataSource = alumnos.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //Para saber si es nuevo o se va a actualizar
                idMatricula = int.Parse(dgvAlumnos.CurrentRow.Cells["Matricula"].Value.ToString());
                idUsuario = int.Parse(dgvAlumnos.CurrentRow.Cells["Matricula"].Value.ToString());

                //Para la tabla de alumnos
                txtMatricula.Text = idMatricula.ToString();
                txtNombre.Text = dgvAlumnos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtAPaterno.Text = dgvAlumnos.CurrentRow.Cells["A. Paterno"].Value.ToString();
                txtAMaterno.Text = dgvAlumnos.CurrentRow.Cells["A. Materno"].Value.ToString();
                txtDireccion.Text = dgvAlumnos.CurrentRow.Cells["direccion"].Value.ToString();
                txtPromedioBachiller.Text = dgvAlumnos.CurrentRow.Cells["promedioBachillerato"].Value.ToString();
                txtTelefono.Text = dgvAlumnos.CurrentRow.Cells["telefono"].Value.ToString();
                txtCorreo.Text = dgvAlumnos.CurrentRow.Cells["correo"].Value.ToString();

                //Para la tabla de usuarios
                txtUsuario.Text = dgvAlumnos.CurrentRow.Cells["Usuario"].Value.ToString();
                txtPassword.Text = dgvAlumnos.CurrentRow.Cells["vchpassword"].Value.ToString();
                cmbPerfil.Text = dgvAlumnos.CurrentRow.Cells["vchperfil"].Value.ToString();

                //Usar selected value para apuntar al dato preciso de cada registro
                cmbCarrera.SelectedValue = int.Parse(dgvAlumnos.CurrentRow.Cells["idCarrera"].Value.ToString());
                cmbTutor.SelectedValue = int.Parse(dgvAlumnos.CurrentRow.Cells["idTutor"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mapear los datos seleccionados: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Determinamos el tipo de operacion 
                int tipoOperacion = idMatricula == 0 ? 0 : 1;

                alumnos = new clsAlumnos();
                // 1. Llenamos las propiedades del bloque Alumno
                alumnos.Matricula = int.Parse(txtMatricula.Text);
                alumnos.NombreAlumno = txtNombre.Text;
                alumnos.ApellidoP = txtAPaterno.Text;
                alumnos.ApellidoM = txtAMaterno.Text;
                alumnos.Direccion = txtDireccion.Text;
                alumnos.Telefono = txtTelefono.Text;
                alumnos.Correo = txtCorreo.Text;
                alumnos.PromedioBachillerato = decimal.Parse(txtPromedioBachiller.Text);
                alumnos.IdCarrera = Convert.ToInt32(cmbCarrera.SelectedValue);
                alumnos.IdTutor = Convert.ToInt32(cmbTutor.SelectedValue);

                // 2. Llenamos las propiedades del bloque Usuario
                alumnos.IdUsuario = idUsuario; //Sera 0 si es nuevo, o el ID real si es update
                alumnos.NombreUsuario = txtUsuario.Text;
                alumnos.Password = txtPassword.Text;
                alumnos.Perfil = cmbPerfil.Text;

                string msg = "";

                //Si es una modificacion (tipoOperacion = 1 ), pedimos confirmacion como en carreras
                if (tipoOperacion == 1)
                {
                    var resp = MessageBox.Show("¿Confirmar que deseas actualizar los datos de este alumno?", "ALERTA ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        msg = alumnos.GuardarActualizar(tipoOperacion);
                        MessageBox.Show(msg, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    msg = alumnos.GuardarActualizar(tipoOperacion);
                    MessageBox.Show(msg, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                CargarGrid(); //Refrescamos la tabla del formulario para ver los cambios
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron guardar los datos: " + ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}