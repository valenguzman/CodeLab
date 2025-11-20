namespace EX04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer numero:");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo numero:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            for (n1 = n1 + 1; n1 < n2; n1++)
            {
                
                if (n1 % 7 != 0)
                {
                    Console.WriteLine(n1);
                }
                
            }
        }
    }
}
