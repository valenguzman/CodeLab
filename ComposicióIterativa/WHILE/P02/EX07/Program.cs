namespace EX07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Introdueix números (0 per acabar):");
            int numero = Convert.ToInt32(Console.ReadLine());

            int maxim = numero;
            int minim = maxim;

            while (numero != 0)
            {
                if (numero > maxim)
                    maxim = numero;

                else if (numero < minim)
                    minim = numero;

                Console.WriteLine("Introdueix números (0 per acabar):");
                numero = Convert.ToInt32(Console.ReadLine());
            }

            if (maxim != 0 && minim != 0)
            {
                Console.WriteLine($"Valor més gran: {maxim}");
                Console.WriteLine($"Valor més petit: {minim}");
            }
        }
    }
}
