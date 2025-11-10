namespace EX06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer valor:");
            int primerValor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo valor:");
            int segundoValor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el tercer valor:");
            int tercerValor = Convert.ToInt32(Console.ReadLine());

            if (primerValor > segundoValor && segundoValor > tercerValor)
            {
                Console.WriteLine($"El valor más grande és: {primerValor}");
                Console.WriteLine($"El valor más pequeño és: {tercerValor}");
            }

            else if (tercerValor > segundoValor && segundoValor > primerValor)
            {
                Console.WriteLine($"El valor más grande és: {tercerValor}");
                Console.WriteLine($"El valor más pequeño és: {primerValor}");
            }

            else if (segundoValor > primerValor && primerValor > tercerValor)
            {
                Console.WriteLine($"El valor más grande és: {segundoValor}");
                Console.WriteLine($"El valor más pequeño és: {tercerValor}");
            }

            else if (segundoValor > tercerValor && tercerValor > primerValor)
            {
                Console.WriteLine($"El valor más grande és: {segundoValor}");
                Console.WriteLine($"El valor más pequeño és: {primerValor}");
            }

        }
    }
}
