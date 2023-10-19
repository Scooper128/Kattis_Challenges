namespace Challenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int changes = int.Parse(Console.ReadLine());
            int perYear = int.Parse(Console.ReadLine());
            int yearChange = (changes / perYear);
            int currentYear = yearChange + 2022;
            Console.WriteLine(currentYear);
        }
    }
}