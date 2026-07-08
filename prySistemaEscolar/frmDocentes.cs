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
        //Aporte 2_2 (-- Primera parte --)
        public frmDocentes()
        {
            InitializeComponent();
            //Aporte 2_2 (-- Segunda parte --)
        }

        //Aporte 2_2 (-- Tercera parte --)


        //Aporte 1 (-- Segunda parte --)

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
