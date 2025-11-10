namespace EX04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entra el primer valor");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entra el segundo valor");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            if (valor1 == valor2)
            {
                Console.WriteLine($"Los numeros son iguales");
            }

            else if (valor1 > valor2)
            {
                Console.WriteLine($"El valor más grande és: {valor1}");
                Console.WriteLine($"El valor más pequeño és: {valor2}");
            }
            else
            {
                Console.WriteLine($"El valor más grande és: {valor2}");
                Console.WriteLine($"El valor más pequeño és: {valor1}");
            }

        }
    }
}
