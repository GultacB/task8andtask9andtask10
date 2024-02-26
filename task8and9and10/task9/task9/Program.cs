
namespace task9
{
    public class Mylist
    {
        public  static void ArrayRemove(int[] number)
        {
            int[] array = new int[6] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("silmek istediyiniz elementin index nomresini daxil edin:");
            int index = int.Parse(Console.ReadLine());
            array[index] = 0;
            Console.WriteLine("netice");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }


}