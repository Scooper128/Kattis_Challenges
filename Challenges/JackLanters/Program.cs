using System;
namespace JackLanters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var data = line.Split(' ');
            var i1 = int.Parse(data[0]); //first integer
            var i2 = int.Parse(data[1]); //second integer
            var i3 = int.Parse(data[2]);
            Console.WriteLine(i1*i2*i3);
        }
    }
}