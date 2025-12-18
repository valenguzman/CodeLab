namespace EX01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorNumero = 0;
            
            Console.WriteLine("Introduce un numero");
            int numero = Convert.ToInt32 (Console.ReadLine());

            while (numero != 0)
            {
                contadorNumero++;

                Console.WriteLine("Introduce un numero");
                numero = Convert.ToInt32(Console.ReadLine());
                
            }

            Console.WriteLine($"El usuario a introducido {contadorNumero} numeros.");
        }
    }
}
