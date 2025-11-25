namespace EX11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string FITXER_GIRONA = "Girona lliga23_24.txt";
            StreamReader fitxerGirona = new StreamReader(FITXER_GIRONA);

            int victories = 0;
            int empats = 0;
            int derrotes = 0;
            int puntsTotals = 0;

            string lineaActual = fitxerGirona.ReadLine(); //Leemos la primera linea.

            while (lineaActual != null)
            {
                int golsRival = Convert.ToInt32(lineaActual); //Convertimos la primera linea.

                
                lineaActual = fitxerGirona.ReadLine(); //Leemos la segunda linea.

                int golsGirona = Convert.ToInt32(lineaActual); //Convertimos la segunda linea.

                // Comparar resultados
                if (golsGirona > golsRival)
                {
                    victories++;
                    puntsTotals += 3;
                }
                else if (golsGirona == golsRival)
                {
                    empats++;
                    puntsTotals += 1;
                }
                else
                {
                    derrotes++;
                }

                // Leer la siguiente línea del rival
                lineaActual = fitxerGirona.ReadLine();
            }

            fitxerGirona.Close();

            Console.WriteLine($"Partits guanyats: {victories}");
            Console.WriteLine($"Partits empatats: {empats}");
            Console.WriteLine($"Partits perduts: {derrotes}");
            Console.WriteLine($"Total de punts obtinguts: {puntsTotals}");
        }
    }
}
