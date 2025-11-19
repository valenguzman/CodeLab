namespace EX04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorP = 0;
            int contadorN = 0;
            
            Console.WriteLine("Introduce valores: (0 para terminar.)");
            int numeroActual = Convert.ToInt32(Console.ReadLine());

            while (numeroActual != 0)
            {
                if (numeroActual < 0)
                {
                    contadorN++;
                }

                else
                {
                    contadorP++;
                }

                Console.WriteLine("Introduce valores: (0 para terminar.)");
                numeroActual = Convert.ToInt32(Console.ReadLine());
 
            }

            Console.WriteLine($"Has introducido {contadorP} valores positivos, y {contadorN} valores negativos.");
        }
    }
}
