namespace EX01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INGRESA X1");
            double x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("INGRESA X2");
            double x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("INGRESA Y1");
            double y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("INGRESA Y2");
            double y2 = Convert.ToInt32(Console.ReadLine());

            double distancia = CalcularDistancia(x1, x2, y1, y2);

            Console.WriteLine($"La distancia final és: {distancia}");



        }

        static double CalcularDistancia(double x1, double x2, double y1, double y2)
        {
            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            return distancia;
        }
    }
}
