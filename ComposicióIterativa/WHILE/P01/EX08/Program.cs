namespace EX08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string FITXER_ALUMNES = "alumnesDAMDAW.txt";
            StreamReader strAlumnes = new StreamReader(FITXER_ALUMNES);

            int contadorAlex = 0;
            int contadorIker = 0;

            string lineaActual = strAlumnes.ReadLine();


            while (lineaActual != null)
            {
                
                if (lineaActual == "Alex")
                {
                    contadorAlex++;
                    Console.WriteLine("Se ha trobat Alex.");
                }

                else if (lineaActual == "Iker")
                {
                    contadorIker++;
                    Console.WriteLine("Se ha trobat Iker.");  
                }

                else
                {
                    Console.WriteLine("No se ha trobat cap Aleix, ni cap Iker.");
                }

                lineaActual = strAlumnes.ReadLine();
            }

            strAlumnes.Close();

            Console.WriteLine($"Se ha trobat Alex {contadorAlex} vegades. ");
            Console.WriteLine($"Se ha trobat Iker {contadorIker} vegades.");

            if (contadorIker > contadorAlex)
            {
                Console.WriteLine("Per tant, se ha trobat més vegades Iker.");
            }

            else if (contadorAlex > contadorIker)
            {
                Console.WriteLine("Per tant, se ha trobat més vegades Alex.");
            }

            else
            {
                Console.WriteLine("Per tant, se han trobat les mateixes vegades.");
            }

        }
    }
}
