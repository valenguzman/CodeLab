namespace EX09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int contador = 0;
            
            Console.WriteLine("Introduce un valor positivo:");
            int valor = Convert.ToInt32(Console.ReadLine());

            while (valor != 0)
            {
                valor = valor / 10;
                contador++;
            }

            Console.WriteLine($"El numero tiene: {contador} cifras.");
            
        }
    }
}
