namespace EX03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un valor:");
            int valor = Convert.ToInt32(Console.ReadLine());

            if (valor % 2 == 0)
            {
                Console.WriteLine("El valor introducido es par.");
            }

            else
            {
                Console.WriteLine("El valor introducido no es par.");
            }


        }
    }
}
