namespace EX12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader alumnes = new StreamReader("alumnesDAMDAW.txt");

            const string MARCA_DE_FI = null;

            int contadorAlex = 0;
            int contadorIker = 0;


            string linea = alumnes.ReadLine();

            while (linea != MARCA_DE_FI)
            {
                if (linea == "Alex")
                {
                    contadorAlex++;
                    Console.WriteLine("¡Se ha encontrado Alex!");
                }
                

                else if (linea == "Iker")
                    {
                        contadorIker++;
                        Console.WriteLine("¡Se ha encontrado Iker!");
                    }

                else
                    Console.WriteLine("¡No se ha encontrado nada!");

                linea = alumnes.ReadLine();
            }

                         alumnes.Close();

            Console.WriteLine($"Contador Alex: {contadorAlex}");
            Console.WriteLine($"Contador Iker: {contadorIker}");   

            }


        }
    }
