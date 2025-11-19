using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EX05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int max;
            int min;

            Console.WriteLine("Introduce un número (0 para terminar):");
            numero = Convert.ToInt32(Console.ReadLine());

            max = numero;
            min = numero;

            while (numero != 0)
            {
                if (numero > max)
                {
                    max = numero;
                }

                if (numero < min)
                {
                    min = numero;
                }

                Console.WriteLine("Introduce un número (0 para terminar):");
                numero = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"El valor máximo es: {max}");
            Console.WriteLine($"El valor mínimo es: {min}");

        }
    }
}
