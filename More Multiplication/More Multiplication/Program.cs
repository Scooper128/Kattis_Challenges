namespace More_Multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String num1=Console.ReadLine();
            String num2=Console.ReadLine();
            int[] num1Ar = num1.Split(' ').Select(int.Parse).ToArray();
            int[] num2Ar = num2.Split(' ').Select(int.Parse).ToArray();
            /*List<List<int>> grid = new List<List<int>>();
            List<int> gridTemp = new List<int>();
            foreach (int app in num2List) {   
                foreach (int num in num1List)
                {
                    gridTemp.Add(num * app);
                    Console.WriteLine(gridTemp);
                }
                grid.Add(gridTemp);
                Console.WriteLine(grid);
            }
            Console.WriteLine(grid);
             */

        }
    }
}