namespace Assignment5._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 1 };
            int[] array2 = { 1, 2, 3, 4 };
            int[] array3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            Console.WriteLine(DoubleNum(array1));
            Console.WriteLine(DoubleNum(array2));
            Console.WriteLine(DoubleNum(array3));
        }
        static bool DoubleNum(int[] numbers)
        {   
            for (int i = 0; i < numbers.Length; i++)
            {
                int checkThisNum = numbers[i];
                int counter = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    
                    if (numbers[j] == checkThisNum)
                    {
                        counter++;
                    }
                    if (counter == 2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
