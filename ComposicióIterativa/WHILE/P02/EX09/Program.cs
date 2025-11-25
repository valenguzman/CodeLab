namespace EX09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorXifres = 0;
            
            Console.WriteLine("Introdueix un numero positiu:");
            int numeroP = Convert.ToInt32(Console.ReadLine());

            while (numeroP != 0)
            {
                
                contadorXifres++;

                numeroP = numeroP / 10;

            }

            Console.WriteLine($"El teu numero té {contadorXifres} xifres.");

        }
    }
}
