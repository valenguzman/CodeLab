namespace EX07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 101);
            int b = rnd.Next(1, 101);

            int contadorIteracions = 0;

            Console.WriteLine($"Introduce el resultado de {a} + {b}");
            int resultatSuma = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Introduce el resultado de {a} - {b}");
            int resultatResta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Introduce el resultado de {a} * {b}");
            int resultatMultiplicacio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Introduce el resultado de {a} / {b}");
            int resultatDividir = Convert.ToInt32(Console.ReadLine());

            while (resultatSuma != a + b || resultatResta != a - b || resultatMultiplicacio != a * b || resultatDividir != a / b)
            {
                Console.WriteLine($"Resultat de la suma: {a} + {b} ");
                resultatSuma = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Resultat de la resta: {a} - {b}");
                resultatResta = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Resultat del producte: {a} * {b}");
                resultatMultiplicacio = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Resultat de la divisió: {a} / {b}");
                resultatDividir = Convert.ToInt32(Console.ReadLine());

                contadorIteracions++;
            }

            Console.WriteLine("Correcto!");
            Console.WriteLine($"Numero de intentos: {contadorIteracions}");
        }
    }
}
