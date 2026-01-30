namespace Digitalis_Nyomozoiroda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bizonyitek b = new Bizonyitek(67, "rablas", "nigger", 3);
            Szemely s = new Szemely("Kozcka Steve", 67, "Úszó bajnok");
            Gyanusitott g = new Gyanusitott(s,70,"őrizetben");
            Donteshozo d = new Donteshozo();
            d.Donteshozas(g,b);
        }
    }
}
