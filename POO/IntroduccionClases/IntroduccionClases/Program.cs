namespace IntroduccionClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----ejemplo 1 para aleix

            Cliente cliente = new Cliente("Valentin", "vgguzzman@gmail.com", "Carrer Llises", "629 20 41 41", 23);

            Console.WriteLine(cliente.MostrarInformacion());

            //Console.WriteLine(cliente.nombre);
            
            //Console.WriteLine(cliente.email);
            
            //Console.WriteLine(cliente.direccion);
            
            //Console.WriteLine(cliente.telefono);
            
            //Console.WriteLine(cliente.edad);

            //-----ejemplo 2 para aleix

            //Producto producto = new Producto("Leche", "Lacteos", 1.20, 84, true);

            //Console.WriteLine($"nombre = {producto.nombre}");
            //Console.WriteLine($"categoria = {producto.categoria}");
            //Console.WriteLine($"precio = {producto.precio}");
            //Console.WriteLine($"stock = {producto.stock}");
            //Console.WriteLine($"disponible = {producto.disponible}");


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
