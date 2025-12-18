namespace EX08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader numeros = new StreamReader("NUMEROS.TXT");

            string linea = numeros.ReadLine();

            int maxim = Convert.ToInt32(linea);
            int minim = maxim;

            while (linea != null)
            {

                if (Convert.ToInt32(linea) > maxim)
                {
                    maxim = Convert.ToInt32(linea);
                }
                else if (Convert.ToInt32(linea) < minim)
                {
                    minim = Convert.ToInt32(linea);
                }

                linea = numeros.ReadLine();
            }

            numeros.Close();

            Console.WriteLine($"Valor més gran: {maxim}");
            Console.WriteLine($"Valor més petit: {minim}");


        }
    }
}
