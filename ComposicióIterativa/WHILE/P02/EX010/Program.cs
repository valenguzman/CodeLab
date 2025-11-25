namespace EX010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int contadorLlançaments = 0;
            int contador1 = 0;
            int contador6 = 0;

            while (contador1 != contador6 || contador1 == 0)
            {
                int valor = rnd.Next(1, 7);
                contadorLlançaments++;  //sumar contador

                if (valor == 1)
                {
                    contador1++;
                }

                else if (valor == 6)
                {
                    contador6++; //sumar contador
                }
            }

            Console.WriteLine($"El total de llançaments, han sigut: {contadorLlançaments}"); 
            Console.WriteLine($"El valor '1', ha sortit {contador1} vegades.");
            Console.WriteLine($"El valor '6', ha sortit {contador6} vegades.");
        }
    }
}
