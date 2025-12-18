using System.Reflection.Metadata;

namespace EX05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorNumeros = 0;
            int contadorSuma = 0;

            Console.WriteLine("Introduce un numero:");
            int numero = Convert.ToInt32(Console.ReadLine());

            while (numero != 0)
            {
                contadorSuma = contadorSuma + numero;
                contadorNumeros++;

                Console.WriteLine("Introduce un numero: (0 para acabar)");
                numero = Convert.ToInt32(Console.ReadLine());
            }

            int mediana = CalcularMediana(contadorSuma, contadorNumeros);

            Console.WriteLine($"La mediana és: {mediana}");
        }
        /// <summary>
        /// Esta función calcula la mediana.
        /// </summary>
        /// <param name="contadorSuma">Contador de la suma de todos los numeros</param>
        /// <param name="contadorNumeros">Contador de los numeros introducidos por el usuario</param>
        /// <returns>El calculo de la mediana</returns>
        private static int CalcularMediana(int contadorSuma, int contadorNumeros)
        {
            int mediana = contadorSuma / contadorNumeros;

            return mediana;
        }
    }
}
