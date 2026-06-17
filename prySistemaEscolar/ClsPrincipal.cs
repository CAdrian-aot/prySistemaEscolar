using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySistemaEscolar
{
    internal class ClsPrincipal
    {
        //Este es un obleto de tipo Form
        private Form misformsabiertos;

        public void agregarAlcontenedor(Form formulario, Panel panel)
        {    
            if (misformsabiertos!= null)
            {
                misformsabiertos.Close();//cierra la instancia
                misformsabiertos.Dispose();//libera la memoria
            }

            //Esto es para abrir el formulario en caso contario de no estar abierto
            misformsabiertos = formulario;
            panel.Controls.Clear();

            formulario.TopLevel = false;//esto indica que el formulario no es independiente
            formulario.FormBorderStyle = FormBorderStyle.Sizable;
            formulario.Dock= DockStyle.Fill; //esto indica que el formulario va a ocupar todo el espacio

            panel.Controls.Add(formulario);
            panel.Tag = formulario;
            formulario.Show();



        }



    }
}
