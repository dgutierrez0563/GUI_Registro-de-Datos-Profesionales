using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_AdminstradorDeTareas
{
    class Informacion_to_DataBase
    {
        /// <summary>
        /// Atrbutos de la clases
        /// </summary>
        private string nombre;
        private string apellidos;
        private string cedula;
        private int telefono;
        private string estadoCivil;
        private string direccion;
        private string profesion;
        private string institucionLaboral;
        private string puestoLaboral;
        private string fechaIngreso;
        private string tipoLicencia;
        private string genero;
        private string observaciones;
        /// <summary>
        /// Metodod get y set de la clase para los atributos
        /// </summary>
        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Cedula { get; set; }

        public int Telefono { get; set; }

        public string EstadoCivil { get; set; }

        public string Direccion { get; set; }

        public string Profecion { get; set; }

        public string InstitucionLaboral { get; set; }

        public string PuestoLaboral { get; set; }

        public string TipoLicencia { get; set; }

        public string Genero { get; set; }

        public string Observaciones { get; set; }

        public Informacion_to_DataBase() { }
        /// <summary>
        /// Constructor de los atributos de la clase de los campos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellidos"></param>
        /// <param name="cedula"></param>
        /// <param name="telefono"></param>
        /// <param name="estadoCivil"></param>
        /// <param name="direccino"></param>
        /// <param name="direccion"></param>
        /// <param name="profesion"></param>
        /// <param name="institucionLaboral"></param>
        /// <param name="puestoLaboral"></param>
        /// <param name="fechaIngreso"></param>
        /// <param name="tipoLicencia"></param>
        /// <param name="genero"></param>
        /// <param name="observaciones"></param>
        public Informacion_to_DataBase(string nombre,string apellidos,string cedula, int telefono,string estadoCivil,string direccino, string direccion, string profesion, string institucionLaboral,
            string puestoLaboral,string fechaIngreso,string tipoLicencia,string genero,string observaciones) {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.cedula = cedula;
            this.telefono = telefono;
            this.estadoCivil = estadoCivil;
            this.direccion = direccion;
            this.profesion = profesion;
            this.institucionLaboral = institucionLaboral;
            this.puestoLaboral = puestoLaboral;
            this.fechaIngreso = fechaIngreso;
            this.tipoLicencia = tipoLicencia;
            this.genero = genero;
            this.observaciones = observaciones;
        }
        public void putInformation(Informacion_to_DataBase nodo) {
            if (!txt_EdicionNombre.Text.Equals("") & !txt_EdicionApellidos.Text.Equals("") & !txt_EdicionEmail.Text.Equals("") & !txt_EdicionContrasenia.Text.Equals("") & !txt_EdicionRepetirContrasenia.Text.Equals(""))
            {
                if (txt_EdicionContrasenia.Text.Equals(txt_EdicionRepetirContrasenia.Text))
                {
                    objeto.SetGetNombre = txt_NombreReal.Text;
                    objeto.SetGetAppellido = txt_Apellidos.Text;
                    objeto.SetGetEmail = txt_Email.Text;
                    objeto.SetGetUsuario = txt_nombreUsuario.Text;
                    objeto.SetGetContrasenia = txt_contrasenia.Text;
                    objeto2.actualizarUsuario();
                    MessageBox.Show("¡Usuario Actualizado con Exito!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    txt_EdicionContrasenia.Clear();
                    txt_EdicionRepetirContrasenia.Clear();
                    MessageBox.Show("¡Error de Contraseña!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("¡Error de Editado, revise los campos requeridos!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
