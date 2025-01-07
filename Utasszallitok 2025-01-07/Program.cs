namespace Utasszallitok_2025_01_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Jarmuadat> jarmuadatok = new();
            foreach (var sor in File.ReadAllLines("utasszallitok.txt").Skip(1))
            {
                jarmuadatok.Add(new Jarmuadat(sor));
            }
            Console.WriteLine($"4. feladat: {jarmuadatok.Count} darab repűlőgép van");
        }
    }
}
