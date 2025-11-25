namespace EX15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MARCA_DE_FI = null;
            const string FITXER_ALUMNES = "Girona lliga23_24.txt";
            StreamReader fitxerGirona = new StreamReader(FITXER_ALUMNES);

            int contadorGuanyats = 0;
            int contadorPerduts = 0;
            int contadorEmpatats = 0;
            int punts = 0;

            string lineaActual = fitxerGirona.ReadLine();

            while (lineaActual != MARCA_DE_FI)
            {
                int golsRivals = Convert.ToInt32(lineaActual);

                lineaActual = fitxerGirona.ReadLine();

                int golsGirona = Convert.ToInt32(lineaActual);

                if (golsGirona > golsRivals)
                {
                    contadorGuanyats ++;
                    punts += 3;
                }

                else if (golsGirona == golsRivals)
                {
                    contadorEmpatats ++;
                    punts += 1;
                }

                else if (golsGirona < golsRivals)
                {
                    contadorPerduts ++;
                    punts += 0;
                }

                lineaActual = fitxerGirona.ReadLine();
            }

            fitxerGirona.Close();

            Console.WriteLine("");
            Console.WriteLine("!!!----Girona 23/24----!!!");
            Console.WriteLine("");
            Console.WriteLine($"Partits guayants: {contadorGuanyats}");
            Console.WriteLine("");
            Console.WriteLine($"Partits empatats: {contadorEmpatats}");
            Console.WriteLine("");
            Console.WriteLine($"Partits perduts: {contadorPerduts}");
            Console.WriteLine("");
            Console.WriteLine($"Punts totals: {punts}");
            Console.WriteLine("");
        }
    }
}
