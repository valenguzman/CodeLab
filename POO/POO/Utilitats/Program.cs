namespace Utilitats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CadenaDeCaracters c, d, e;

            c = new CadenaDeCaracters();


            c.EsMotDePas = true;
            c.CaracterDelMotDePas = '*';
            d = new CadenaDeCaracters(new char[] {'p','e','p' }, true, 'X');
            Console.WriteLine($"Es mot de pas la c? {c.EsMotDePas}"); //son el mismo objecto
            Console.WriteLine($"Es mot de pas la c? {d.EsMotDePas}");

            c.Escriu();
            d.Escriu();
        }
    }
}
