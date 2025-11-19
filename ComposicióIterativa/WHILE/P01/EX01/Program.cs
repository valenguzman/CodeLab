namespace EX01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Comptar valors fins trobar 0*/

            int contador = 0;

            Console.WriteLine("Introduce valores: (0 para terminar.)");
            int numeroActual = Convert.ToInt32(Console.ReadLine());

            while (numeroActual != 0)
            {
                
                contador++;

                Console.WriteLine("Introduce valores: (0 para terminar.)");
                numeroActual = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine($"Has introducido {contador} valores.");
        }
    }
}
