namespace EX03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorP = 0;
            int contadorN = 0;
            
            Console.WriteLine("Introduce numeros: (0 para acabar)");
            int numeros = Convert.ToInt32(Console.ReadLine());

            while (numeros != 0)
            {


                if (numeros < 0)
                {
                    contadorN++;
                }

                else if (numeros > 0)
                {
                    contadorP++;
                }

                Console.WriteLine("Introduce numeros: (0 para acabar)");
                numeros = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Numeros Positivos: {contadorP}");
            Console.WriteLine($"Numeros Negativos: {contadorN}");
        }
    }
}
