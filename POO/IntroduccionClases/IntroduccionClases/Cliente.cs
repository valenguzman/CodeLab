using System;
using System.Collections.Generic;
using System.Text;

namespace IntroduccionClases
{
    public class Cliente
    {
        #region propiedades

        public string nombre;
        public string email;
        public string direccion;
        public string telefono;
        public int edad;

        #endregion


        #region Constructor
        public Cliente()
        {
            nombre = "Por defecto";
        }

        public Cliente(string nombre, string email, string direccion, string telefono, int edad)
        {
            this.nombre = nombre;
            this.email = email;
            this.direccion = direccion;
            this.telefono = telefono;
            this.edad = edad;

        }

        #endregion

        public string MostrarInformacion()
        {
            string informacion = ConcatenarInformacion();

            informacion = ConvertirMayus(informacion);

            return informacion;
        }

        //Metodos para Concatenar y Convertir en Mayusculas

        private string ConcatenarInformacion()
        {
            return $"Nombre/Email = {nombre} - {email}";
        }

        private string ConvertirMayus(string texto)
        {
            return texto.ToUpper();
        }
    }
}
