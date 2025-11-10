namespace EX01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un valor:");
            int valor = Convert.ToInt32(Console.ReadLine());

            if (valor == 0)
            {
                Console.WriteLine("El valor que has introducido es 0.");
            }

            else if (valor > 0)
            {
                Console.WriteLine("El valor que has introducido es positivo.");
            }

            else
            {
                Console.WriteLine("El valor que has introducido es negativo.");
            }

        }
    }
}
