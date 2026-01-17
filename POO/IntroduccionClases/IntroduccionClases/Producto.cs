using System;
using System.Collections.Generic;
using System.Text;

namespace IntroduccionClases
{
    public class Producto
    {
        public string nombre;
        public string categoria;
        public double precio;
        public int stock;
        public bool disponible;

        public Producto()
        {
            nombre = "Producto por defecto";
            disponible = true;
        }

        public Producto(string nombre, string categoria, double precio, int stock, bool disponible)
        {
            this.nombre = nombre;
            this.categoria = categoria;
            this.precio = precio;
            this.stock = stock;
            this.disponible = disponible;
        }
    }
}
