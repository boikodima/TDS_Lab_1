using System;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[50];
            Random rand = new Random();


            #region Bubblesort
            Console.WriteLine("Array before sort");

            for (int i = 0; i < 50; i++)
            {
                myArr[i] = rand.Next(100);
                Console.Write(myArr[i] + " ");
            }

            BubbleSort(myArr);
            Console.WriteLine("\n\nArray after bubblesort");
            for (int i = 0; i < 50; i++)
            {
            Console.Write(myArr[i] + " ");
            }
            #endregion
		}
	}
}
