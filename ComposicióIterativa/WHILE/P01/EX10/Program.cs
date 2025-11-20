namespace EX10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string FITXER_BONUS = "BONUS2.txt";
            StreamReader strBonus = new StreamReader(FITXER_BONUS);

            int comptadorBonus = 0;
            int totalGuany = 0;
            
            string lineaActual = strBonus.ReadLine();

            while (lineaActual != null)
            {
                if (lineaActual == "BONUS")
                {
                    comptadorBonus++;
                    Console.WriteLine("Aquesta linea és: BONUS");
                    string lineaQuantitat = strBonus.ReadLine();

                    if (lineaActual != null)
                    {
                        int importBonus = Convert.ToInt32(lineaQuantitat);
                        totalGuany += importBonus;
                    }
                }

                else
                {
                    Console.WriteLine("Aquesta linea és: NO BONUS");
                }

                lineaActual = strBonus.ReadLine();

            }

            strBonus.Close();

            Console.WriteLine($"El total de guanys és de: {totalGuany}");
            Console.WriteLine($"El total de billets amb BONUS és de: {comptadorBonus}");

        }

     }
 }
