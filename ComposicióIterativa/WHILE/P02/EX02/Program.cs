namespace EX02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            
            const string FITXER_NUMEROS = "NUMEROS.TXT";
            StreamReader fitxerNumeros = new StreamReader(FITXER_NUMEROS);

             string lineaActual = fitxerNumeros.ReadLine();

            while (lineaActual != null)
            {
                contador++;
                lineaActual = fitxerNumeros.ReadLine();
            }

            Console.WriteLine($"Hay {contador} valores.");
        }
    }
}
