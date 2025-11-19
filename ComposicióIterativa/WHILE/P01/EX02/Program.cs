namespace EX02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorSuma = 0;
            int contadorNumero = 0;

            Console.WriteLine("INTRODUCE UN VALOR: (TERMINAR CON 0.)");
            int numeroActual = Convert.ToInt32(Console.ReadLine());

            while (numeroActual != 0)
            {
                contadorSuma += numeroActual;
                contadorNumero++;

                Console.WriteLine("INTRODUCE UN VALOR: (TERMINAR CON 0.)");
                numeroActual = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine($"Has introducido 0. La mediana és: {contadorSuma / contadorNumero}");
        }
    }
}
