namespace EX05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un valor entero:");

            int numeroEntero = Convert.ToInt32(Console.ReadLine());

            double AlCuadrado = Math.Pow(numeroEntero,2);
            double AlCubo = Math.Pow(numeroEntero,3);

            Console.WriteLine($"2^2 = {AlCuadrado}");
            Console.WriteLine($"2^3 = {AlCubo}");
        }
    }
}
