namespace IntroduccionClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            Console.WriteLine(cliente.nombre);
            Console.WriteLine(cliente.email);
            Console.WriteLine(cliente.direccion);
            Console.WriteLine(cliente.telefono);
            Console.WriteLine(cliente.edad);
        }
    }
}
