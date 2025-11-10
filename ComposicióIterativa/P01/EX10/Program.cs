namespace EX10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTRODUCE UN VALOR DE 4 DIGITOS");
            int valorDe4Digitos = Convert.ToInt32(Console.ReadLine());

            int primerDigito = valorDe4Digitos / 1000 % 10;

            int segundoDigito = valorDe4Digitos / 100 % 10;

            int tercerDigito = valorDe4Digitos / 10 % 10;

            int cuartoDigito = valorDe4Digitos % 10;

            Console.WriteLine($"{primerDigito}");
            Console.WriteLine($"{segundoDigito}");
            Console.WriteLine($"{tercerDigito}");
            Console.WriteLine($"{cuartoDigito}");
        }
    }
}
