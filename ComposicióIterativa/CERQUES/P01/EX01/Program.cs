namespace EX01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MARCA_DE_FI = null;
            const string NOM_FITXER = "NUMEROS.TXT";
            StreamReader fitxer = new StreamReader(NOM_FITXER);

            int primerNumero = Convert.ToInt32(fitxer.ReadLine());

            string linea = fitxer.ReadLine();

            while (linea != null && Convert.ToInt32(linea) != primerNumero)
            {
                linea = fitxer.ReadLine();
            }

            if (linea == null)
            {
                Console.WriteLine($"No es repeteix el numero {primerNumero}");
            }
            else
            {
                Console.WriteLine($"Si que es repeteix el numero {primerNumero}");
            }

            fitxer.Close();
        }
    }
}
