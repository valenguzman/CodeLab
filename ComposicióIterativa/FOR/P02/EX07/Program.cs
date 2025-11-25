namespace EX07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cP = 0;
            int cN = 0;
            int numero;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Introduce el numero {i}:");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero < 0)
                {
                    cN++;
                }

                else
                {
                    cP++;
                }    
            }

            Console.WriteLine($"Contador positivo:{cP}");
            Console.WriteLine($"Contador negativo:{cN}");
        }
    }
}
