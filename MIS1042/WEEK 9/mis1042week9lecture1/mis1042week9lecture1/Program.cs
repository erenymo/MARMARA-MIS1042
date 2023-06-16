namespace mis1042week9lecture1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = { 1, 2, 3, 4, 3, 5, 6, 7, 3, 8, 9, 10 };

            /*
             // Count Odd and Even Numbers
            int[] result = OddEvenNumQty(myArr);

            // index 0 for odd, 1 for even.

            Console.WriteLine($"Even number qty : {result[1]}");
            Console.WriteLine($"Odd number qty : {result[0]}");

            */

            // int item = 3;

            /*
            // CONTINUE STATEMENT

            for (int i = 0; i < myArr.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"First: {myArr[i]}");
                if (myArr[i] == 3)
                {
                    continue; // for döngüsü continue'yi çalıştırdıktan sonra duruyor ve bir sonraki iterationa geçiyor.
                }

                Console.WriteLine($"Last :{myArr[i]}");
            }
            */

            /*
            // LINEAR SEARCH
            int[] result = SearchArrayAll(myArr, item);
            if (result.Length > 0)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine($"{item} found in index: {result[i]}");
                }
            } else
            {

                Console.WriteLine("Not matched");
            }


            /*
            // Elemanı bulduğunda sonlanır
            int indexNum = SearchArrayFirst(myArr, item);

            Console.WriteLine($"Searching item : {item}");
            if (indexNum == -1)
            {
                Console.WriteLine("Item not found");
            }else
            {
                Console.WriteLine("Item found at index: " + indexNum);
            }
            */

            /*
            // FIZZBUZZ Test
            int[] arr = new int[100];

            for (int i = 0; i < arr.Length; i++) 
            {
                arr[i] = i + 1;
            }

            for (int i = 0;i < arr.Length; i++)
            {
                if (arr[i] % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                } else if (arr[i] % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                } else if (arr[i] % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                } else
                {
                    Console.WriteLine(arr[i]);
                }
            }
            */

        }



        /*
        // Count Odd and Even Numbers
        static int[] OddEvenNumQty(int[] arr)
        {
            int[] oddEvenCount = new int[2]; // index 0 for odd, 1 for even.

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    oddEvenCount[1]++;
                } else
                {
                    oddEvenCount[0]++;
                }
            }

            return oddEvenCount;
        }
        */

        /*
        // Dizideki istenen tüm elemanları bulana kadar çalışır.
        static int[] SearchArrayAll(int[] arr, int item)
        {
            int[] foundItems = new int[0];


            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == item)
                {
                    if(foundItems.Length > 0)
                    {
                        //creating foundItems copy
                        int[] temp = new int[foundItems.Length];

                        for (int j = 0; j < temp.Length; j++)
                        {
                            temp[j] = foundItems[j];
                        }

                        foundItems = new int[foundItems.Length + 1];

                        for (int k = 0; k < temp.Length; k++)
                        {
                            foundItems[k] = temp[k];
                        }
                    } else
                    {
                        foundItems = new int[foundItems.Length + 1];
                    }
                    foundItems[foundItems.Length - 1] = i;
                }
            }
            return foundItems;
        }

        // Elemanı bulduğunda sonlanır.
        static int SearchArrayFirst(int[] arr, int item)
        {
            int index = -1;

            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] == item)
                {
                    index = i;
                    Console.WriteLine("item found");
                    
                }
                Console.WriteLine(i);
            }
            return index;
        }
        */
        
    }
}