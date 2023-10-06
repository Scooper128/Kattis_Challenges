namespace More_Multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String num1=Console.ReadLine();
            String num2=Console.ReadLine();
            var num1List = num1.ToArray();
            var num2List = num2.ToArray();
            int[,] grid;
            int[] gridTemp;
            foreach(int app in num2List) {   
                foreach (int num in num1List)
                {
                    gridTemp.Append(num * app);
                }
            }
                                                            
            
        }
    }
}