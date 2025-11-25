namespace EX08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplicacioNumeros = 1;

            Console.WriteLine("Introduce un numero:");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                multiplicacioNumeros = multiplicacioNumeros * i;
            }

            Console.WriteLine($"El resultado és: {multiplicacioNumeros}");
        }
    }
}
