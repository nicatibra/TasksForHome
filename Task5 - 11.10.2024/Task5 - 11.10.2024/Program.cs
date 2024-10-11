//2. CustomResize methodu yaradılır. Method parametr olaraq int tipindən array və params olaraq int-lər qəbul edir.
//Paramslardan gələn dəyərləri həmin arraya əlavə etsin və sonda dəyişilmiş hal köhnə arrayide(argument olaraq oturulen array) deyishdirsin .
//(Array resize istifade etmirsiz ozunuz Custom yazirsiz)

namespace Task5___11._10._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrNumbers = { 1, 2, 10 };
            CustomResize(ref arrNumbers, 4, 5, 6, 7, 8, 9);

            Console.WriteLine("Resized array: ");
            for (int i = 0; i < arrNumbers.Length; i++)
            {
                Console.WriteLine(arrNumbers[i]);
            }
        }

        public static void CustomResize(ref int[] array, params int[] nums)
        {
            int[] newArr = new int[array.Length + nums.Length];

            for (int i = 0; i < array.Length; i++)
            {
                newArr[i] = array[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                newArr[array.Length + i] = nums[i];
            }

            array = newArr;
        }
    }
}
