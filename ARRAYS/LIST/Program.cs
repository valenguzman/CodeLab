namespace LIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int LIMIT = 10;
            int[] vector = new int[10];
            int[] taula = { 1, 2, 3 };


            List<int> llista = new List<int>();

            for (int numero = 1; numero < LIMIT; numero++)
            {
                llista.Add(numero);
            }

            static void EscriuLLista(List<int> llista)
            {
                Console.WriteLine("[");

                for (int posicio = 0; posicio < llista.Count; posicio++)
                {
                    Console.WriteLine($"{llista[posicio]} ,");
                }
                Console.WriteLine("]");
            }

            static bool Conte(List<int> llista, int element)
            {
                int posicio = 0;

                llista.Add(element);

                while (llista[posicio] != element)
                {
                    posicio++;
                }
                llista.RemoveAt(llista.Count - 1);

                return posicio != llista.Count;
            }
        }
    }
}
