namespace IntroduccionClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----ejemplo 1 

            Cliente clienteValen = new Cliente("Valentin", "vgguzzman@gmail.com", "Carrer Llises", "629 20 41 41", 20);

            //Mostrando Informacion con Metodos (Recomendado)

            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("Cliente: Valen / " + clienteValen.MostrarInformacion());

            Console.WriteLine("Cliente: Valen / " + clienteValen.MostrarInformacionPersonal());

            Console.WriteLine("------------------------------------------------------------------");


            //Mostrando inforamcion sin metodos (No Recomendado) (No funciona por la declaracion de las propiedades).

            Console.WriteLine(clienteValen.nombre);

            Console.WriteLine(clienteValen.email);

            Console.WriteLine(clienteValen.direccion);

            Console.WriteLine(clienteValen.telefono);

            Console.WriteLine(clienteValen.edad);

            //-----ejemplo 2 

            //Mostrando Informacion con Metodos (Recomendado)

            Console.WriteLine("------------------------------------------------------------------");

            Producto producto = new Producto("Leche", "Lacteos", 1.20, 84, true);

            Console.WriteLine(producto.MostrarInformacionProducto());

            Console.WriteLine("------------------------------------------------------------------");

            //Mostrando inforamcion sin metodos (No Recomendado)

            Console.WriteLine(producto.nombre);
            Console.WriteLine(producto.categoria);
            Console.WriteLine(producto.precio);
            Console.WriteLine(producto.stock);
            Console.WriteLine(producto.disponible);

            Console.WriteLine("------------------------------------------------------------------");


            //// Empresa

            //Primera forma de crear un objeto.

            Empresa empresa = new Empresa()
            {
                Nombre = "ValuuwCorp",
                Email = "valuuw@gmail.com",
                Telefono = "231312312",
                Direccion = "Carrer Llises",
            };

            //Segunda forma de crear un objeto.

            Empresa empresa2 = new Empresa("12334434432232","ValuuwCorp", "valuuw@gmail.com","629 20 41 41","Carrer Llises");

            //Mostrar por pantalla.

            Console.WriteLine(empresa.MostrarInformacion());
        }
    }
}
