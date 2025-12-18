namespace EX13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader bonus = new StreamReader("bonus.txt");

            Random rnd = new Random();

            const string MARCA_DE_FI = null;

            int contadorBonus = 0;
            int sumaImport = 0;
            int billets = 0;

            string linea = bonus.ReadLine();

            while (linea != null)

            {

                billets++;

                if (linea == "BONUS")
                {
                    contadorBonus++;
                    int import = rnd.Next(1,11);
                    sumaImport = sumaImport + import;
                    Console.WriteLine("Se ha encontrado 'BONUS' ");
                    Console.WriteLine($"Import asociat: {import}");
                    Console.WriteLine("");
                }

                else if (linea == "NO BONUS")
                {
                    Console.WriteLine("Se ha encontrado 'NO BONUS' ");
                }

                linea = bonus.ReadLine();
            }

            bonus.Close();

            Console.WriteLine("");
            Console.WriteLine($"Total billets {billets}");
            Console.WriteLine("");
            Console.WriteLine($"BONUS: {contadorBonus}");
            Console.WriteLine("");
            Console.WriteLine($"Import total: {sumaImport}");
            Console.WriteLine("");
        }
    }
}
