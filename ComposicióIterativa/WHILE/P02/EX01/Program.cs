namespace EX01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            
            Console.WriteLine("Introdueix un numero");
            int numero = Convert.ToInt32(Console.ReadLine());

            while (numero != 0)
            {
                contador++;
                Console.WriteLine("Introdueix un numero");
                numero = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Has introducido {contador} valores.");

        }
    }
}
