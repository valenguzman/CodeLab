using System;
using System.Collections.Generic;
using System.Text;

namespace IntroduccionClases
{
    public class Cliente
    {
        #region propiedades

        //public string nombre;
        //public string email;
        //public string direccion;
        //public string telefono;
        //public int edad;

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private int edad;

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }



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


        #region Metodos

        //Metodo para mostrar la informacion con los otros metodos.
        public string MostrarInformacion()
        {
            string informacion = ConcatenarInformacion();

            informacion = ConvertirMinus(informacion);

            return informacion;
        }

        public string MostrarInformacionPersonal()
        {
            string informacionPersonal = ConcatenarInformacionPersonal();

            return informacionPersonal;
        }

        public string ConcatenarInformacionPersonal()
        {
            string informacionPersonal = $"Direccion/Telefono = {direccion} - {telefono}";

            return informacionPersonal;
        }

        //Metodos para Concatenar y Convertir en Mayusculas

        private string ConcatenarInformacion()
        {
           
            string informacion = $"Nombre/Email = {nombre} - {email}";

            return informacion;
        }

        private string ConvertirMinus(string texto)
        {
            return texto.ToLower();
        }

        #endregion
    }
}
