namespace EX03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MARCA_DE_FI = 0;
            int contadorP = 0;
            int contadorN = 0;

            Console.WriteLine("Introduce un valor: (0 para terminar)");
            int numeroActual = Convert.ToInt32(Console.ReadLine());

            while (numeroActual != MARCA_DE_FI)
            {
                if (numeroActual < 0)
                {
                    contadorN++;
                }

                else
                {
                    contadorP++;
                }

                Console.WriteLine("Introduce un valor:");
                numeroActual = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Has introducido {contadorP} valores positivos, y {contadorN} valores negativos.");

        }
    }
}
