namespace EX09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quiero la tabla del...");
            Console.Write("  ");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
            


        }
    }
}
