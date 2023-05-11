using System.Diagnostics.Metrics;

namespace mis1042week10l2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random rnd = new Random(); // creating random numbers

            //int[] myArr = new int[1000]; // elemanlar 0-9 arasında

            //int[] counter = new int[10];

            //for (int i = 0; i < myArr.Length; i++)
            //{
            //    myArr[i] = rnd.Next(0, 10);  // creates random numbers between 0 - 9 
            //}

            //for (int i = 0;i < myArr.Length; i++)
            //{
            //    counter[myArr[i]]++;
            //}

            //for (int i = 0; i < counter.Length ; i++)
            //{
            //    Console.WriteLine($"Number {i} : {counter[i]}");
            //}


            // MULTIDIMENSIONAL ARRAYS

            //Random rnd = new Random();

            //int[,] myMultiArr = new int[10, 20];  // this multi dimensional array has 20*10  elements inside.

            //myMultiArr[0, 0] = 42; // assigning a value of multi dimensional array

            //Console.WriteLine(myMultiArr[0,0]);

            //int[,,,] myFourDimensionalArr = new int[10, 10, 10, 10]; // this four dimensional array has 10*10*10*10 elements inside.
            //// even if you use it or not use it, it is going to reserve this memory.


            //for (int i = 0; i < myMultiArr.GetLength(0); i++)  // .GetLength for which dimension you want to get the length.  0 is the first dimension.
            //{
            //    for (int j = 0; j < myMultiArr.GetLength(1); j++) // 1 is the second dimension
            //    {
            //        myMultiArr[i,j] = rnd.Next(1,101);
            //    }
            //}

            //for (int i = 0; i < myMultiArr.GetLength(0); i++)  // .GetLength for which dimension you want to get the length.  0 is the first dimension.
            //{
            //    for (int j = 0; j < myMultiArr.GetLength(1); j++) // 1 is the second dimension
            //    {
            //        Console.WriteLine($"{i}, {j} = {myMultiArr[i,j]}");
            //    }
            //}

            // JAGGED ARRAY

            int[][] myJaggedArr = new int[3][]; // 3 sub arrays

            myJaggedArr[0] = new int[7];
            myJaggedArr[1] = new int[3];
            myJaggedArr[2] = new int[5];

            Random rnd = new Random();

            for (int i = 0; i < myJaggedArr.Length; i++)
            {
                for (int k = 0;k < myJaggedArr[i].Length; k++)
                {
                    myJaggedArr[i][k] = rnd.Next(1, 101);
                }
            }


            for (int i = 0; i < myJaggedArr.Length; i++)
            {
                for (int k = 0; k < myJaggedArr[i].Length; k++)
                {
                    Console.WriteLine($"{i}-{k} : {myJaggedArr[i][k]}");
                }
            }

            int[][] studentAges = new int[10][];

            studentAges[0] = new int[5900];
            studentAges[1] = new int[6000];


        }
    }
}