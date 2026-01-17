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

            Cliente clienteAleix = new Cliente("Aleix", "Aleix@gmail.com", "Carrer Fortia", "629 20 41 51", 20);

            Console.WriteLine("Cliente: Aleix / " + clienteAleix.MostrarInformacion());

            Console.WriteLine("Cliente: Aleix / " + clienteAleix.MostrarInformacionPersonal());

            Console.WriteLine("------------------------------------------------------------------");

            //Mostrando inforamcion sin metodos (No Recomendado)

            Console.WriteLine(clienteValen.nombre);

            Console.WriteLine(clienteValen.email);

            Console.WriteLine(clienteValen.direccion);

            Console.WriteLine(clienteValen.telefono);

            Console.WriteLine(clienteValen.edad);

            //-----ejemplo 2 

            Console.WriteLine("------------------------------------------------------------------");

            Producto producto = new Producto("Leche", "Lacteos", 1.20, 84, true);

            Console.WriteLine(producto.MostrarInformacionProducto());

            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine($"nombre = {producto.nombre}");
            Console.WriteLine($"categoria = {producto.categoria}");
            Console.WriteLine($"precio = {producto.precio}");
            Console.WriteLine($"stock = {producto.stock}");
            Console.WriteLine($"disponible = {producto.disponible}");


            //------ejemplo 1 para aleix


            //string[] nombres = { "Ana", "Luis", "María", "Carlos" };

            //foreach (string nombre in nombres)
            //{
            //    Console.WriteLine(nombre);
            //}


            //------ejemplo 2 para aleix


            //List<int> numeros = new List<int> { 10, 20, 30, 40 };

            //foreach (int numero in numeros)
            //{
            //    Console.WriteLine(numero * 2);

            //}
        }
    }
}
