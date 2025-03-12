namespace FrekventSiffra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 1, 1, 5, 5, 5, 6, 6, 6, 3, 3, 3, 1, 5, 8 };
            Console.WriteLine(FindFrequentNum(numbers));
        }

        static int FindFrequentNum(int[] numbers)
        {
            //We group the numbers by their value and count the frequency of each number and save in a dictionary
            var frequencyMap = numbers.GroupBy(num => num).ToDictionary(num => num.Key, num => num.Count());

            //We find the number with the highest frequency
            int maxFrequency = frequencyMap.Values.Max();

            //We return them smallest number with the highest frequency
            return frequencyMap.Where(num => num.Value == maxFrequency)
                               .OrderBy(num => num.Key)
                               .First()
                               .Key;
        }
    }
}
