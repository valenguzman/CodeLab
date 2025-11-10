namespace EX08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el precio del produto:");

            int precioProduto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el porcentaje del impuesto aplicado:");

            int impuestoAplicado = Convert.ToInt32(Console.ReadLine());

            double iva = precioProduto * impuestoAplicado / 100;

            double ivaAplicado = precioProduto + iva;

            Console.WriteLine($"Precio sin impuestos aplicados: {precioProduto}");
            Console.WriteLine($"Impuestos: {iva}");
            Console.WriteLine($"Precio con el impuesto aplicado: {ivaAplicado}");

        }
    }
}
