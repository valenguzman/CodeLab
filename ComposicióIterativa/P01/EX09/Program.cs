namespace EX09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTRODUCE EL VALOR A:");
            int valorA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("INTRODUCE EL VALOR B:");
            int valorB = Convert.ToInt32(Console.ReadLine());

            double hipotenusa = CalcularLaHipotenusa(valorA, valorB);

            Console.WriteLine($"El resultado de la operación es: {hipotenusa}");
        }

        private static double CalcularLaHipotenusa(int valorA, int valorB)
        {
            double hipotenusa = Math.Sqrt(Math.Pow(valorA, 2) + Math.Pow(valorB, 2));

            return hipotenusa;
        }
    }
}
