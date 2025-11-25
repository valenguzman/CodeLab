namespace EX11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int a = rnd.Next(1, 101);
            int b = rnd.Next(1, 101);
            int contadorOperacions = 0;

            Console.WriteLine($"Intrudueix el resultat {a} + {b}:");
            int resultatSuma = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Intrudueix el resultat  {a} - {b}:");
            int resultatResta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Intrudueix el resultat d {a} * {b}:");
            int resultatProducte = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Intrudueix el resultat de {a}  / {b}:");
            int resultatDividir = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Malament!");
            Console.WriteLine("Torna a començar!");
            Console.WriteLine("");

            while (resultatSuma != a + b && resultatResta != a-b && resultatProducte != a*b && resultatDividir != a/b)
            {
                
                contadorOperacions++;
                
                Console.WriteLine("Intrudueix el resultat de la suma:");
                resultatSuma = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Intrudueix el resultat de la resta:");
                resultatResta = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Intrudueix el resultat del producte:");
                resultatProducte = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Intrudueix el resultat de la divisió:");
                resultatDividir = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("Malament!");
                Console.WriteLine("Torna a començar!");
                Console.WriteLine("");
            }

            Console.WriteLine($"Intents: {contadorOperacions}");
        }
    }
}
