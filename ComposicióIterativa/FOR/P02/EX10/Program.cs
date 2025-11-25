namespace EX10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            
            for (int i = 1; i <= 300; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                    contador++;

                    if (contador % 20 == 0)
                    {
                        Console.WriteLine("Prem una tecla per continuar...");
                        Console.ReadKey();
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine("Fin del programa");
        }
    }
}
