namespace EX06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MARCA_DE_FI = null;
            const string FITXER_NUMEROS = "NUMEROS2.TXT";
            StreamReader fitxerNumeros = new StreamReader(FITXER_NUMEROS);

            int sumaContador = 0;
            int numeroContador = 0;

            string lineaActual = fitxerNumeros.ReadLine();

            while (lineaActual != MARCA_DE_FI)
            {
                numeroContador++;
                sumaContador = sumaContador + Convert.ToInt32(lineaActual);

                lineaActual = fitxerNumeros.ReadLine();
            }

            Console.WriteLine($"La mediana és {sumaContador / numeroContador}");

        }
    }
}
