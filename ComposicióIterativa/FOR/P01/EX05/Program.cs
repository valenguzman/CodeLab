namespace EX05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sumaNumeros = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Introduce el numero {i}");
                int numeroActual = Convert.ToInt32( Console.ReadLine());

                sumaNumeros = sumaNumeros + numeroActual;
            }

            Console.WriteLine($"La suma total de los numeros introducidos és: {sumaNumeros}");
        }
    }
}
