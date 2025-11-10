namespace EX05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu nota: (1-10)");
            int nota = Convert.ToInt32(Console.ReadLine());

            if (nota < 5)
            {
                Console.WriteLine("Suspendido.");
            }

            else if (nota > 5)
            {
                Console.WriteLine("Aprovado.");
            }
        }
    }
}
