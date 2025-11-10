namespace EX04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la base:");

            int bse = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce la altura:");

            int altura = Convert.ToInt32(Console.ReadLine());

            int area = bse * altura / 2;

            Console.WriteLine($"El resultado de la operación es: {bse} x {altura} / 2 = {area}");

        }
    }
}
