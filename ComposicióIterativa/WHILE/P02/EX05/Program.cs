namespace EX05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorNumero = 0;
            int contadorSuma = 0;
            
            Console.WriteLine("Introduce un valor: (0 para acabar.)");
            int numero = Convert.ToInt32(Console.ReadLine());

            while (numero != 0)
            {
                contadorNumero++;
                contadorSuma = contadorSuma + numero;

                Console.WriteLine("Introduce un valor: (0 para acabar.)");
                numero = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"La mediana és {contadorSuma / contadorNumero}.");
        }
    }
}
