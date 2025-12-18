namespace EX06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MARCA_DE_FI = null;

            StreamReader numeros2 = new StreamReader ("NUMEROS2.TXT");

            int contadorSuma = 0;
            int contadorNumeros = 0;

            string linea = numeros2.ReadLine();

            while (linea != MARCA_DE_FI)
            {
                contadorSuma += Convert.ToInt32(linea);
                contadorNumeros++;

                linea = numeros2.ReadLine();
            }

            numeros2.Close();

            int mediana = CalucarMediana(contadorNumeros, contadorSuma);

            Console.WriteLine($"La mediana total és de: {mediana}");
        }

        private static int CalucarMediana(int contadorNumeros, int contadorSuma)
        {
            int mediana = contadorSuma / contadorNumeros;

            return mediana;
        }
    }
}
