namespace EX06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorXifres = 0;

            Console.WriteLine("Introduce un numero:");
            int numero = Convert.ToInt32(Console.ReadLine());

            while (numero != 0)
            {
                numero = numero / 10;
                contadorXifres++;
            }

            Console.WriteLine($"El numero que has introducido tiene {contadorXifres} xifres.");
            
        }
    }
}
