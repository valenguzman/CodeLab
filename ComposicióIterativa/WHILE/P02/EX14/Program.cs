using System.Threading.Channels;

namespace EX14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader bonus2 = new StreamReader("BONUS2.TXT");

            Random rnd = new Random();

            const string MARCA_DE_FI = null;

            int contadorBonus = 0;
            int sumaImport = 0;
            int billets = 0;

            string linea = bonus2.ReadLine();

            while (linea != MARCA_DE_FI)
            {

                billets++;

                if (linea == "BONUS")
                {   

                    contadorBonus++;
                    int quantitat = Convert.ToInt32(bonus2.ReadLine());
                    sumaImport = sumaImport + quantitat;

                }

                linea = bonus2.ReadLine();
            }

            bonus2.Close();

            Console.WriteLine($"Total BILLETS: {billets}");
            Console.WriteLine($"Total BONUS: {contadorBonus}");
            Console.WriteLine($"Total IMPORT: {sumaImport}");

        }

    }
}
