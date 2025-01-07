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
            //4.
            Console.WriteLine($"4. feladat: {jarmuadatok.Count} darab repűlőgép van");

            //5.
            int boeing = 0;
            foreach (var r in jarmuadatok)
            {
                string[] b = r.Típus.Split("Boeing");
                boeing++;
            }
            double gepek = (boeing - jarmuadatok.Count);

            Console.WriteLine($"5. feladat: {gepek} darab Boeing repűlőgép van");
        }
    }
}
