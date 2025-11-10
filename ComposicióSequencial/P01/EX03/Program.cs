namespace EX03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el radio de un circulo:");

            Console.WriteLine("");

            int radio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            double area = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine("");

            Console.WriteLine($"El resultado de tu operación es: area = {Math.PI} x {radio}^2 = {area}");
        }
    }
}
