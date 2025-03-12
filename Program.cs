namespace FrekventSiffra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We have three tests, including one with negative numbers
            int[] numbersTestEmpty = {}; // The array is empty
            int[] numbersTestOne = { 1, 1, - 1, 5, 5, -1,  6, 6, 6, 3, 3, 5, 6, 8, -1, -1 }; // -1
            int[] numbersTestTwo = { 1, 3, 2, 3, 4, 1, 3, 2, 2, 2, 5 }; // 2
            int[] numbersTestThree = { 7, 7, 5, 5, 1, 1, 1, 2, 2, 2 }; // 1

            ConsolePrint(numbersTestEmpty);
            ConsolePrint(numbersTestOne);
            ConsolePrint(numbersTestTwo);
            ConsolePrint(numbersTestThree);
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

        //A function so that we don't need to write this code multiple times
        //Maybe at some point we want 10, or 50+ tests
        static void ConsolePrint(int[] numbers)
        {
            //If the array is empty
            if (numbers.Length == 0)
            {
                Console.WriteLine("The array is empty");
                return;
            }
            Console.WriteLine($"The lowest number with the highest frequancy is: {FindFrequentNum(numbers)}");
        }
    }
}
