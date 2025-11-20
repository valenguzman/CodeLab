namespace EX06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numerosP = 0;
            int numerosN = 0;
            int numero0 = 0;
            const int MARCA_DE_FI = 10;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Introduce el numero {i}");
                int numeroActual = Convert.ToInt32(Console.ReadLine());

                if (numeroActual < 0)
                {
                    numerosN++;
                }

                else if (numeroActual > 0)
                {
                    numerosP++;
                }

                else
                {
                    numero0++;
                }
            }

            Console.WriteLine($"Has introducido {numerosP} valores positivos, y {numerosN} valores negativos, también has introducido {numero0} veces '0'");
            
        }
    }
}
