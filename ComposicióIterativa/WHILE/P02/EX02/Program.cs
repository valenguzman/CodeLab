namespace EX02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MARCA_DE_FI = null;

            StreamReader numeros = new StreamReader("NUMEROS.TXT");

            int contadorNumeros = 0;

            string linea = numeros.ReadLine();


            while (linea != MARCA_DE_FI)
            {
                linea = numeros.ReadLine();
                contadorNumeros++;
            }

            numeros.Close();

            Console.WriteLine($"Cantidad de numeros: {contadorNumeros}");
        }
    }
}
