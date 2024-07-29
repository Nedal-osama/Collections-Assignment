using System.Collections;

namespace Collections_Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region ReverseList
            ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };
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
        }
        #endregion

    }
}