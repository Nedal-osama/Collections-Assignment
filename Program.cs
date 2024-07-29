using System.Collections;

namespace Collections_Assignment
{
    public class Program
    {

        public static void Main(string[] args)
        {
            #region ReverseList
            /*  ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };
              Reverse(list);

              foreach (var item in list)
              {
                  Console.WriteLine(item);
              }
          }

          private static void Reverse(ArrayList list)
          {
              int left = 0;
              int right = list.Count - 1;

              while (left < right)
              {
                  var temp = list[left];
                  list[left] = list[right];
                  list[right] = temp;

                  left++;
                  right--;
              }
          }*/
            #endregion


            #region EvenNumber
            /*    List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
                List<int> evenNumbers = GetEvenNumbers(numbers);

                foreach (var num in evenNumbers)
                {
                    Console.WriteLine(num);
                }

            }

            private static List<int> GetEvenNumbers(List<int> numbers)
            {
                List<int> evenNumbers = new List<int>();

                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        evenNumbers.Add(number);
                    }
                }

                return evenNumbers;
            */
            #endregion
            #region FixedSizeList
            /*    FixedSizeList<int> fixedList = new FixedSizeList<int>(3);

                try
                {
                    fixedList.Add(1);
                    fixedList.Add(2);
                    fixedList.Add(3);

                    fixedList.Add(4);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try
                {
                    for (int i = 0; i < fixedList.Count; i++)
                    {
                        Console.WriteLine(fixedList.Get(i));
                    }

                    Console.WriteLine(fixedList.Get(3));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }*/
            #endregion


            #region FirstNonRepeatedCharacter
            string str = "nedal";
            int index = FindFirstNonRepeatedCharacter(str);
            Console.WriteLine("Index of first non-repeated character: " + index);
            #endregion
        }

        private static int FindFirstNonRepeatedCharacter(string str)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            Dictionary<char, int> charIndex = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                    charIndex[c] = i;
                }
            }

            foreach (var kvp in charCount)
            {
                if (kvp.Value == 1)
                {
                    return charIndex[kvp.Key];
                }
            }

            return -1;
        
           }
    }
}