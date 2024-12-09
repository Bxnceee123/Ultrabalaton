namespace Ultrabalaton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Versenyző> versenyzők = new();
            foreach (var sor in File.ReadAllLines("ub2017egyeni.txt").Skip(1))
            {
                versenyzők.Add(new Versenyző(sor));
            }
            Console.WriteLine($"3. feladat: Egyéni indulók: {versenyzők.Count} fő");
        }
    }
}
