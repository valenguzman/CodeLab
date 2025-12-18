namespace EX04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MARCA_DE_FI = null;

            int contadorPositius = 0;
            int contadorNegaitius = 0;

            StreamReader numeros = new StreamReader("NUMEROS.TXT");

            string linea = numeros.ReadLine();

            int lineaInt = Convert.ToInt32(linea);

            while (linea != MARCA_DE_FI)
            {
                if (lineaInt < 0)
                {
                    contadorNegaitius++;
                }

                else
                {
                    contadorPositius++;
                }

                linea = numeros.ReadLine();
            }

            numeros.Close();

            Console.WriteLine($"Numeros positivos: {contadorPositius}");
            Console.WriteLine($"Numeros negativos {contadorNegaitius}");
        }
    }
}
