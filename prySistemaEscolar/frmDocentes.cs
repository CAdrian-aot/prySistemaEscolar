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
    public partial class frmDocentes : Form
    {
        
        clsDocentes docentes;

        int idClave;
        int idUsuario;
        public frmDocentes()
        {
            InitializeComponent();
            cargarDataGrid();
            placeholderComboBox();
        }

        //Cargar tabla
        public void cargarDataGrid()
        {
            clsDocentes docentes = new clsDocentes();

            dgvDocentes.DataSource = null;
            dgvDocentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                dgvDocentes.DataSource = docentes.CargarDatagrid();
                dgvDocentes.Columns["NombreUsuario"].Visible = false;
                dgvDocentes.Columns["Perfil"].Visible = false;
                dgvDocentes.Columns["Password"].Visible = false;
                dgvDocentes.Columns["idUsuario"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Mostrar placeholder en los combobox
        public void placeholderComboBox()
        {
            cmbPuesto.SelectedIndex = 0;
            cmbPerfil.SelectedIndex = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            docentes = new clsDocentes();

            idClave = 0;
            idUsuario = 0;
            cmbPuesto.SelectedIndex = 0;
            cmbPerfil.SelectedIndex = 0;
            docentes.LimpiarPanel(pnlDocente);
            docentes.LimpiarPanel(pnlUsuario);
            txtClave.Focus();
        }

        private void txtBuscarClave_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarClave.Text))
            {
                cargarDataGrid();
                return;
            }

            docentes = new clsDocentes();
            dgvDocentes.DataSource = null;
            dgvDocentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                docentes.Clave = int.Parse(txtBuscarClave.Text);
                dgvDocentes.DataSource = docentes.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LimpiarPanel(Panel panelDestino)
        {
            foreach (Control control in panelDestino.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se determina el tipo de operación: 0 = Insertar, 1 = Actualizar
                int tipoOperacion = idClave == 0 ? 0 : 1;

                docentes = new clsDocentes();

                //1. Se llenan las propiedades del panel Docente
                docentes.Clave = int.Parse(txtClave.Text);
                docentes.Nombre = string.IsNullOrEmpty(txtNombre.Text) ? null : txtNombre.Text;
                docentes.Puesto = string.IsNullOrEmpty(cmbPuesto.Text) ? null : cmbPuesto.Text;
                docentes.Telefono = string.IsNullOrEmpty(txtTelefono.Text) ? null : txtTelefono.Text;
                docentes.Correo = string.IsNullOrEmpty(txtCorreo.Text) ? null : txtCorreo.Text;

                //2. Se llenan las propiedades del panel Usuario
                docentes.IdUsuario = idUsuario;
                docentes.NombreUsuario = string.IsNullOrEmpty(txtUsuario.Text) ? null : txtUsuario.Text;
                docentes.Password = string.IsNullOrEmpty(txtPassword.Text) ? null : txtPassword.Text;
                docentes.Perfil = string.IsNullOrEmpty(cmbPerfil.Text) ? null : cmbPerfil.Text;

                string msg = "";

                //Si es modificación, se pide confirmación
                if (tipoOperacion == 1)
                {
                    var resp = MessageBox.Show("¿Seguro que desea actualizar los datos del docente?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        msg = docentes.GuardarActualizar(tipoOperacion);
                        MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    msg = docentes.GuardarActualizar(tipoOperacion);
                    MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                cargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
        }

         
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show($"¿Esás seguro de eliminar permanenetemente al docente con clave {idClave}?\nEsta acción también borra su cuenta de usuario.", "¡ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    docentes = new clsDocentes();

                    docentes.Clave = idClave;
                    docentes.IdUsuario = idUsuario;

                    string resultado = docentes.Eliminar();

                    MessageBox.Show(resultado, "Registro eliminado correctamnete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cargarDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar el registro : " + ex.Message, "Error operacional", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
