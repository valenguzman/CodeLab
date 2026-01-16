namespace ARRAYS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] tempMaxima = new double[365];
            double[] tempMinima = new double[365];

            tempMaxima[5] = Convert.ToInt32(Console.ReadLine());
            tempMaxima[0] = Convert.ToInt32(Console.ReadLine());

            //funcio();
            funcio2();
        }

        static void funcio()
        {
            int[] numeros = new int[3];


            for (int index = 0; index < numeros.Length; index++)
            {
                numeros[index] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void funcio2()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // new int[10] + inicialització

            for (int index = 0; index < numeros.Length; index++)
            {
                Console.WriteLine($"El contingut de la posicio {index} es {numeros[index]}");
            }
        }
    }
}
