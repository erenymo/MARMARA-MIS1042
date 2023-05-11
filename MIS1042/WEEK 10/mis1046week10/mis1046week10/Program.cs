namespace mis1046week10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
            //#########REVERSE THE ARRAY#########
            int[] myArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Diziyi tersine çevirme
            for (int i=0; i<(myArr.Length/2);i++)
            {
                int varTemp = myArr[myArr.Length-1-i];
                myArr[myArr.Length - 1 - i] = myArr[i];
                myArr[i] = varTemp;
            }

            Console.WriteLine("------");    

            for (int i=0;i<myArr.Length;i++) 
            {
                Console.WriteLine($"{i} : {myArr[i]}");
            }    
            **/

            /**
            #####SWAP TWO NUMBERS#########

            int x = 5;
            int y = 6;

            int temp = x;
            x = y;
            y = temp;
            **/



            //#########COPY AN ARRAY -- SHALLOW AND DEEP COPY#########


            //int[] myArr = { 1, 2, 3, 4, 5 };
            //int[] myArr2 = new int[5];

            /*for (int i = 0; i < myArr2.Length; i++)
            {
                Console.WriteLine($"{i} : {myArr2[i]}");
            }

            Console.WriteLine("------");*/

            //myArr2 = myArr;

            /*
            for (int i = 0; i < myArr2.Length; i++)
            {
                Console.WriteLine($"{i} : {myArr2[i]}");
            }*/

            //Console.WriteLine("------");

            //Console.WriteLine($"myArr[2] : {myArr[2]}");
            //Console.WriteLine($"myArr2[2] : {myArr2[2]}");

            //myArr[2] = 42;

            //Console.WriteLine($"myArr[2] : {myArr[2]}");
            //Console.WriteLine($"myArr2[2] : {myArr2[2]}");


            //int[] myArr = { 1, 2, 3, 4, 5 };
            //int[] myArr2 = new int[5];

            //Array.Copy(myArr, myArr2, 3); // (source array,destination array,how many elements are going to be copied)

            //myArr.CopyTo(myArr2, 0); 


            //Console.WriteLine($"myArr[2] : {myArr[2]}");
            //Console.WriteLine($"myArr2[2] : {myArr2[2]}");

            //myArr[2] = 42;

            //Console.WriteLine("------");
            //Console.WriteLine($"myArr[2] : {myArr[2]}");
            //Console.WriteLine($"myArr2[2] : {myArr2[2]}");

            //Console.WriteLine("------");
            //for (int i = 0; i < myArr2.Length; i++)
            //{
            //    Console.WriteLine($"{i} : {myArr2[i]}");
            //}

            //#########CHECK IF ARRAYS ARE EQUAL#########

            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //int[] arr2 = { 1,2,3,4,5 };

            //bool equal = true;

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    if (arr1[i] != arr2[i]) 
            //    { 
            //        equal = false;
            //        break;
            //    }
            //}

            //if (equal) 
            //{
            //    Console.WriteLine("Both arrays are equal.");
            //} else
            //{
            //    Console.WriteLine("They are not equal.");
            //}


            //string myStr1 = "marmara";
            //string myStr2 = "matmara";

            //Console.WriteLine(myStr1 == myStr2);    // == it checks if it is equal or not.
            // myStr1.CompareTo(myStr2);

            //bool equal = true;

            //for (int i = 0; i < myStr1.Length; i++)
            //{
            //    if (myStr1[i] != myStr2[i])
            //    {
            //        equal = false;
            //    }
            //}

            //if (equal)
            //{
            //    Console.WriteLine("equal.");
            //}
            //else
            //{
            //    Console.WriteLine("not equal.");
            //}

            //myStr1[0] = 'b';  // Mutable(değeri değişebilir) vs Immutable(değeri değişemez : string)

            // #########PALINDROME EXAMPLE#########

            //int[] arr = { 5, 4, 3, 4, 5};

            string arr = "tenet";

            bool palindrome = true;

            //for (int i = 0; i < (arr.Length / 2); i++)
            //{
            //    if (arr[i] != arr[arr.Length - 1 - i])
            //    {
            //        palindrome = false;
            //        break;
            //    }
            //}


            for (int i = 0, k = arr.Length-1; i < (arr.Length / 2); i++,k--)
            {
                if (arr[i] != arr[k])
                {
                    palindrome = false;
                    break;
                }
            }

            if (palindrome)
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }
        }
    }
}