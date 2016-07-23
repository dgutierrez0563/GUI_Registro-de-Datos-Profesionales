using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_AdminstradorDeTareas
{
    public partial class Form2_InsercionDatos : Form
    {
        public Form2_InsercionDatos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo validacion de campos en el registro de informacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RegistroGuardar_Click(object sender, EventArgs e)
        {
            if (!txt_Nombre.Text.Equals("") & !txt_Apellidos.Text.Equals("") & !txt_Cedula.Text.Equals("") & !txt_Telefono.Text.Equals("") & !txt_EstadoCivil.Text.Equals("") & !txt_Direccion.Text.Equals("") & !txt_Profesion.Text.Equals("") & !txt_InstitucionLaboral.Text.Equals("") & !txt_PuestoLaboral.Text.Equals("") & !dateTime_FechaIngreso.Text.Equals("") & !cb_TipoLicencia.Text.Equals("") & !cb_Genero.Text.Equals(""))
            {                                  
                    MessageBox.Show("¡Usuario Actualizado con Exito!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);             
            }
            else
            {
                MessageBox.Show("¡Error de Editado, revise los campos requeridos!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
