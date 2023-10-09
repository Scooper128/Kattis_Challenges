namespace Monopoly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hotels = int.Parse(Console.ReadLine());
            String spaces = Console.ReadLine();
            int[] spacesSplit = spaces.Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(spacesSplit);
            
        }
    }
}