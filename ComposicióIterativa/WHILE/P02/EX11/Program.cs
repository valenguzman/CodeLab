namespace EX11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int a = rnd.Next(1, 101);
            int b = rnd.Next(1, 101);

            int contadorIntentos = 0;

            Console.WriteLine($"Entra el resultat de la suma: {a} + {b}. ");
            int resultatSuma = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Entra el resultat de la resta: {a} - {b}. ");
            int resultatResta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Entra el resultat del producte: {a} * {b}. ");
            int resultatProducte = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Entra el resultat de la divisio: {a} / {b}. ");
            int resultatDivisio = Convert.ToInt32(Console.ReadLine());


            while (resultatSuma != a + b && resultatResta != a - b && resultatProducte != a * b && resultatDivisio != a / b)
            {
                contadorIntentos++;

                if (resultatSuma != a + b && resultatResta != a - b && resultatProducte != a * b && resultatDivisio != a / b)
                {
                    Console.WriteLine("¡Incorrecto!");
                    Console.WriteLine("");
                }

                if (resultatSuma == a + b && resultatResta == a - b && resultatProducte == a * b && resultatDivisio == a / b)
                {
                    Console.WriteLine("¡Correcto!");
                    Console.WriteLine("");
                }

                Console.WriteLine($"Entra el resultat de la suma: {a} + {b}. ");
                resultatSuma = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Entra el resultat de la resta: {a} - {b}. ");
                resultatResta = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Entra el resultat del producte: {a} * {b}. ");
                resultatProducte = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Entra el resultat de la divisio: {a} / {b}. ");
                resultatDivisio = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Numeros de intentos: {contadorIntentos}");
        }
    }
}
