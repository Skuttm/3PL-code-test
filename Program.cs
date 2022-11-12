using System.Linq;

// Tests for 1
Console.WriteLine(isStringNumber("123")); // true
Console.WriteLine(isStringNumber("0.242")); // true
Console.WriteLine(isStringNumber("Code Test")); // false
Console.WriteLine(isStringNumber("10E30")); // true
Console.WriteLine("\n\n");

// Tests for 2
Console.WriteLine(
  numCharacterOccurrences("One Fish, Two Fish, Red Fish, Blue Fish", 'F')
); // 4
Console.WriteLine(numCharacterOccurrences("abbcccddddeeeee", 'f')); // 0
Console.WriteLine(numCharacterOccurrences("abbcccddddeeeee", 'b')); // 2
Console.WriteLine(numCharacterOccurrences("abbcccddddeeeee", 'c')); // 3
// Console.WriteLine(numCharacterOccurrences("This results in an error", "this"));
Console.WriteLine("\n\n");

// Tests for 3
Console.WriteLine(String.Join(",", removeDuplicatesFromArray(new [] {1, 1, 2, 2, 3, 4, 5}))); // [1, 0, 2, 0, 3, 4, 5]
Console.WriteLine(String.Join(",", removeDuplicatesFromArray(new [] {1, 1, 1, 1, 1, 1, 1}))); // [1, 0, 0, 0, 0, 0, 0]
Console.WriteLine(String.Join(",", removeDuplicatesFromArray(new [] {1, 2, 3, 4, 5, 6, 7}))); // [1, 2, 3, 4, 5, 6, 7]
Console.WriteLine(String.Join(",", removeDuplicatesFromArray(new [] {1, 2, 1, 1, 1, 1, 1}))); // [1, 0, 0, 0, 0, 0, 2]
Console.WriteLine("\n\n");

// Tests for 4
Console.WriteLine(String.Join(",", findMissingNumbers(new [] {1, 2, 3, 4, 6}))); // [1, 0, 2, 0, 3, 4, 5]
Console.WriteLine(String.Join(",", findMissingNumbers(new [] {1, 2, 3, 4, 6, 7, 9, 8, 10}))); // [1, 0, 0, ]
Console.WriteLine(String.Join(",", findMissingNumbers(new [] {1, 2, 3, 4, 6, 9, 8}))); // [1, 0, 2, 0, 3, 4, 5]
Console.WriteLine(String.Join(",", findMissingNumbers(new [] {1, 2, 3, 4, 9, 8}))); // [1, 0, 2, 0, 3, 4, 5]
Console.WriteLine("\n\n");

// Test for 5
Console.WriteLine(String.Join(",", findSumPairs(new [] {2, 4, 3, 5, 6, -2, 4, 7, 8, 9}, 7))); // [[2, 5], [4, 3], [3, 4], [-2, 9]]

  // 1. Write a program to check if a String is a Number
Boolean isStringNumber(string str) {
  double number;
  return double.TryParse(str, out number);
}

// 2. Write a program to count the number of occurrences of a character in an input string
int numCharacterOccurrences(string str, char character) {
  return str.Split(character).Count() - 1;
}

// 3. How to remove duplicates from an array
int[] removeDuplicatesFromArray(int[] array)
{
  List<int> list = array.ToList();
  list.Sort();
  List<int> result = new List<int>();
  
  foreach (int number in list)
  {
    result.Add(!result.Contains(number) ? number : 0);
  }
  return result.ToArray();
}

// 4. Find the missing number in a given non-sorted integer array of 1 to 10
int[] findMissingNumbers(int[] array) {
  List<int> result = new List<int>();

  for (int i = 1; i <= 10; i++) {
    if (!array.Contains(i)) result.Add(i);
  }

  return result.ToArray();
}

// 5. Find all pairs in an array of integers whose sum is equal to a given number
List<(int, int)> findSumPairs(int[] array, int sum) {
  List<(int, int)> result = new List<(int, int)>();

  for (int i = 0; i < array.Length; i++)
  {
    int a = array[i];
    for (int j = i; j < array.Length; j++) {
      int b = array[j];
      if (a + b == sum) result.Add((a, b));
    }
  }

  return result;
}
