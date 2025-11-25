namespace EX12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MARCA_DE_FI = null;
            const string FITXER_ALUMNES = "alumnesDAMDAW.txt";
            StreamReader fitxerAlumnes = new StreamReader(FITXER_ALUMNES);

            int contadorAlex = 0;
            int contadorIker = 0;

            string lineaActual = fitxerAlumnes.ReadLine();

            while (lineaActual != MARCA_DE_FI)
            {
                if (lineaActual == "Alex")
                {
                    contadorAlex++;
                }

                else if (lineaActual == "Iker")
                {
                    contadorIker++;
                }

                lineaActual = fitxerAlumnes.ReadLine();
            }

            fitxerAlumnes.Close();

            Console.WriteLine($"Contador Alex: {contadorAlex}");
            Console.WriteLine($"Contador Iker: {contadorIker}");

            if (contadorAlex > contadorIker)
            {
                Console.WriteLine("Hay más Alex");
            }

            else if (contadorIker > contadorAlex)
            {
                Console.WriteLine("Hay más Iker");
            }
        }
    }
}
