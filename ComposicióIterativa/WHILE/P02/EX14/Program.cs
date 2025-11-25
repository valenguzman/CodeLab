namespace EX14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MARCA_DE_FI = null;
            const string BONUS_ALUMNES = "bonus2.txt";
            StreamReader fitxerBonus = new StreamReader(BONUS_ALUMNES);

            int contadorBonus = 0;
            int contadorQuantitat = 0;

            string lineaActual = fitxerBonus.ReadLine();

            while (lineaActual != MARCA_DE_FI)
            {
                string tipus = lineaActual;                      // 1ª línea → BONUS o NO BONUS

                lineaActual = fitxerBonus.ReadLine();
                string valor = lineaActual;                      // 2ª línea → cantidad o nada

                if (tipus == "BONUS")
                {
                    contadorBonus++;
                    Console.WriteLine("¡BONUS!");

                    if (valor != MARCA_DE_FI)
                    {
                        contadorQuantitat += Convert.ToInt32(valor);
                    }
                }
                else if (tipus == "NO BONUS")
                {
                    Console.WriteLine("¡NO BONUS!");
                }

                lineaActual = fitxerBonus.ReadLine();            // Leemos la siguiente pareja
            }

            fitxerBonus.Close();

            Console.WriteLine($"El total dels guays són: {contadorQuantitat} EUROS.");
            Console.WriteLine($"El total dels billets bonus són: {contadorBonus}.");


        }
    }
}
