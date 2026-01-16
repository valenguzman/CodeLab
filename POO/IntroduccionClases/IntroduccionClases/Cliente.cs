using System;
using System.Collections.Generic;
using System.Text;

namespace IntroduccionClases
{
    public class Cliente
    {
        public string nombre;
        public string email;
        public string direccion;
        public string telefono;
        public int edad;

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

    }
}
