namespace EX04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const string FITXER_NUMEROS = "NUMEROS.TXT";
            StreamReader fitxerNumeros = new StreamReader(FITXER_NUMEROS);

            int contadorP = 0;
            int contadorN = 0;

            string lineaActual = fitxerNumeros.ReadLine();

            while (lineaActual != null)
            {
                if (Convert.ToInt32(lineaActual) < 0)
                {
                    contadorN++;
                }

                else
                {
                    contadorP++;
                }

                lineaActual = fitxerNumeros.ReadLine();
            }

            Console.WriteLine($"Has introducido {contadorP} valores positivos, y {contadorN} valores negativos.");
        }
    }
}
