
 namespace task10
{
    public class Mylist
    {
        public static void MinandMaxValue(int[] array)
        {
            int[] array = new int[6] { 1, 2, 3, 4, 5, 6 };
            int maxvalue = array[0];
            int minvalue = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxvalue)
                {
                    maxvalue = array[i];
                }
                if (array[i] < minvalue)
                {
                    minvalue = array[i];
                }
            }
            Console.WriteLine("en boyuk eded:" + maxvalue);
            Console.WriteLine("en kicik eded:" + minvalue);
        }
    }
}