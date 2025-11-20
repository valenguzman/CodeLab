namespace EX09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Introduce un valor:");
            Console.Write(" ");
            int primerNumero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{primerNumero} x {i} = {primerNumero * i}");
            }
        }
    }
}
