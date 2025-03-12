# FrequentNumber-CodeTest-
A code test for the following assigment:

Write a method that accepts an array of integers and returns the most frequent number in the array.
If multiple numbers have the same frequency, return the lowest number.

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Explanation:

Strategy:
The goal is to determine the most frequently occurring number in an array. If multiple numbers share the highest frequency, the smallest number should be returned. To achieve this, I will:

1. Count the occurrences of each number.
2. Identify the maximum frequency.
3. Select the smallest number among those that appear with the maximum frequency.

Data Types and Structures Used:
1. Array (int[]): The input is an array of integers, which will be processed to determine frequencies.
2. Dictionary (Dictionary<int, int>): This will store each unique number as a key and its occurrence count as a value.
3. LINQ Methods (GroupBy, ToDictionary, Max, Where, OrderBy): These will help efficiently group numbers, find the most frequent ones, and return the smallest when ties exist.

Algorithm Approach:
1. Grouping & Counting: Use GroupBy to categorize numbers and then convert the groups into a dictionary where each number is mapped to its frequency.
2. Find Maximum Frequency: Identify the highest count using Max().
3. Find the Smallest Number with Max Frequency: Use Where to filter numbers that match the highest frequency, then sort them in ascending order and pick the first.

Potential Difficulties and Solutions:
1. Handling Large Arrays:
Challenge: If the array is large, performance might be a concern.
Solution: Using a dictionary ensures that counting occurrences happens in O(n) time complexity.

2. Handling Empty Arrays:
Challenge: If the input array is empty, the method should not attempt to access elements.
Solution: Add a check at the beginning of the function:

"if (arr == null || arr.Length == 0)
    throw new ArgumentException("Array cannot be empty");"

Handling Edge Cases (e.g., all elements are unique, all elements are the same, negative numbers, large numbers):
The method should work fine in all cases because it correctly finds and sorts numbers.
