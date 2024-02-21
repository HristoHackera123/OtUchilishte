using System.Collections.Generic;

namespace ListEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine("Chetni: " + string.Join(" ",GetEvenElements(list)));
            Console.WriteLine("Nechetni: " + string.Join(" ",GetOddElements(list)));
        }
        static List<int> GetEvenElements(List<int> numbers)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result.Add(numbers[i]);
                }
            }
            return result;
        } 
        static List<int> GetOddElements(List<int> numbers)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    result.Add(numbers[i]);
                }
            }
            return result;
        }
    }
}
