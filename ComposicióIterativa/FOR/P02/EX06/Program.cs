namespace EX06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumaNumeros = 0;
            
            Console.WriteLine("Introduce un numero:");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                sumaNumeros = sumaNumeros + i;
            }

            Console.WriteLine($"El resultado és: {sumaNumeros}");
        }
    }
}
