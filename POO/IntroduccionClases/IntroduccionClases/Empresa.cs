using System;
using System.Collections.Generic;
using System.Text;

namespace IntroduccionClases
{
    internal class Empresa
    {

        #region ---Propiedades 

        //Primera forma de definir propiedades.(prop)

        public string NIF { get; } = "PIXXX123";

        public string Nombre { get; set; } = string.Empty; //getters para obtener, setter para modificar.

        public string Email { get; set; } = string.Empty; //getters para obtener, setter para modificar.

        public string Direccion { get; set; } = string.Empty; //getters para obtener, setter para modificar.

        public string Telefono { get; set; } = string.Empty; //getters para obtener, setter para modificar.

        //Segunda forma de definir propiedades.(propfull)

        private string nombre2;

        public string Nombre2
        {
            get { return nombre2; }
            set { nombre2 = value; }
        }

        #endregion

        #region ---Contructores

        public Empresa()
        {
            string porDefecto = "Por defecto";
        }

        public Empresa(string nif, string nombre, string email, string direccion, string Telefono)
        {
            this.NIF = nif;
            this.Nombre = nombre;
            this.Email = email;
            this.Direccion = direccion;
            this.Telefono = Telefono;
        }

        #endregion

        #region ---Metodos

        public string MostrarInformacion()
        {
            string informacion = $" \n NIF: {NIF} Nombre: {Nombre} \n \n Email: {Email}, Direccion: {Direccion}, Telefono: {Telefono}.";

            return informacion;
        }

        #endregion
    }
}
