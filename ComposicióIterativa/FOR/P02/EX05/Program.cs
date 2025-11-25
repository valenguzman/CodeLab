namespace EX05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int suma = 0;


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Introduce el numero {i}:");
                int numero = Convert.ToInt32(Console.ReadLine());

                suma += numero;
            }

            Console.WriteLine($"La suma total és: {suma}");
        }
    }
}
