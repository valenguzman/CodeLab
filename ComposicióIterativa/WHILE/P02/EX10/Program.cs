namespace EX10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador1 = 0;
            int contador6 = 0;
            int contadorLanzamientos = 0;

            while (contador1 != contador6 || contador1 == 0)
            {
                Random rnd = new Random();

                int lanzamiento = rnd.Next(1,7);
                contadorLanzamientos++;

                if (lanzamiento == 1)
                {
                    contador1++;
                }

                else if (lanzamiento == 6)
                {
                    contador6++;
                }
            }

            Console.WriteLine($"Llancaments: {contadorLanzamientos}");
            Console.WriteLine($"Vegades numero 6: {contador6}");
            Console.WriteLine($"Vegades numero 1: {contador1}");
        }
    }
}
