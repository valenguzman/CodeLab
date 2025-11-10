namespace EX02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu edad:");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad.");
            }

            else
            {
                Console.WriteLine("Eres menor de edad.");
            }
        }
    }
}
