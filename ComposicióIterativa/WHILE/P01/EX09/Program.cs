namespace EX09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string FITXER_BONUS = "bonus.txt";
            StreamReader strBonus = new StreamReader(FITXER_BONUS);


            Random rnd = new Random();

            int comptadorBonus = 0;
            int totalBillets = 0;
            int totalGuanys = 0;


            string lineaActual = strBonus.ReadLine();

            while (lineaActual != null)
            {
                if (lineaActual == "BONUS")
                {
                    comptadorBonus++;
                    totalBillets++;
                    int importBonus = rnd.Next(1, 11);
                    totalGuanys += importBonus;
                    Console.WriteLine("Aquesta linea és: BONUS");
                }

                else
                {
                    totalBillets++;
                    Console.WriteLine("Aquesta linea és: NO BONUS");
                }

                lineaActual = strBonus.ReadLine();
            }

            strBonus.Close();

            int percentatgeBilletsGuanyadors = comptadorBonus * 100 / totalBillets;

            Console.WriteLine("");
            Console.WriteLine($"El total de billets són: {totalBillets}.");
            Console.WriteLine($"El total de billets guanyadors són: {comptadorBonus}.");
            Console.WriteLine($"El percentatge total de billets guanyadors són: {percentatgeBilletsGuanyadors}%.");
            Console.WriteLine($"El total de guany és: {totalGuanys} euros.");

        }
    }
}
