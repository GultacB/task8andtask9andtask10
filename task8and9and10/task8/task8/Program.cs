
    



namespace task8
{
    public class Mylist
    {
        public static void  ArrayAdd(int[] number)
        {
            int[] array = new int[6] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("elave edeceyiniz ededi daxil edin");
            int number = int.Parse(Console.ReadLine());
            int[] array2 = new int[7];
            for (int i = 0; i < 6; i++)
            {
                array2[i] = array[i];
            }
            array = array2;
            array[6] = number;
            Console.WriteLine("netice");
            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine(array[i]);
            }

            
               
            
        }

    }
}