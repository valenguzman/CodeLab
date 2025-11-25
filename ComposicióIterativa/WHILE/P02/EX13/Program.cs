namespace EX13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MARCA_DE_FI = null;
            const string BONUS_ALUMNES = "bonus.txt";
            StreamReader fitxerBonus = new StreamReader(BONUS_ALUMNES);
            Random rnd = new Random();

            int contadorBillets = 0;
            int contadorBilletsBonus = 0;
            int contadorGuanys = 0;
            int import;


            string lineaActual = fitxerBonus.ReadLine();

            while (lineaActual != MARCA_DE_FI)
            {
                if (lineaActual == "BONUS")
                {
                    contadorBillets++;
                    contadorBilletsBonus++;
                    import = rnd.Next(1, 11);
                    contadorGuanys = contadorGuanys + import;
                }

                else if (lineaActual == "NO BONUS")
                {
                    contadorBillets++;
                }

                lineaActual = fitxerBonus.ReadLine();
            }

            fitxerBonus.Close();

            

            Console.WriteLine($"El total de billets són: {contadorBillets}.");
            Console.WriteLine($"El total de billets BONUS són: {contadorBilletsBonus}.");
            Console.WriteLine($"El total de guays són: {contadorGuanys} euros.");
            Console.WriteLine($"El total de billets BONUS, en percentatge són: {contadorBilletsBonus * 100 / contadorBillets}%");
        }
    }
}
