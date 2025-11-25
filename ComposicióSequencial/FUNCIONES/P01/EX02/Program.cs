namespace EX02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTRODUCE LOS SEGUNDOS:");
            int segundos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("INTRODUCE LOS MINUTOS:");
            int minutos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("INTRODUCE LAS HORAS:");
            int horas = Convert.ToInt32(Console.ReadLine());

            int resultadoSegons = CalcularSegundosTotales(horas, minutos, segundos);

            Console.WriteLine($"Los segundos totales són: {resultadoSegons}");


        }

        static int CalcularSegundosTotales(int horas, int minutos, int segundos)
        {
            const int SEGUNDOS_A_HORAS = 3600;

            const int SEGUNDOS_A_MINUTOS = 60;

            int resultadoSegons = horas * 3600 + minutos * 60 + segundos;

            return resultadoSegons;
        }
    }
}
