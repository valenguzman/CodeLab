namespace EX07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumaNumeros = 0;
            
            Console.Write("Introduce un valor:");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                sumaNumeros = sumaNumeros + i;
            }

            Console.WriteLine($"La suma total és: {sumaNumeros}");
        }
    }
}
