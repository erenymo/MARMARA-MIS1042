namespace mis1042week11lecture1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ##################################
            // ############ FOREACH #############
            // ##################################

            //char[] myArr = {'a','b','c','d','e','f','g'};

            //for (int i = 0; i < myArr.Length; i++)
            //{
            //    Console.WriteLine(myArr[i]);
            //}

            //Console.WriteLine("-----");

            //foreach (char c in myArr) // ({variable} in {array}) Dizideki tüm elemanları geziyor 
            //{
            //    Console.WriteLine(c);
            //}

            //string name = "Marmara"; // Strings are immutable (cannot be changed).

            //foreach (var n in name)  // Do not use var data type at the exam.
            //{
            //    Console.Write(n);
            //}

            //int[] myArr = { 1, 2, 3, 4, 5 };
            //int[,] myMultiArr = { { 1, 2, 3, 35 }, { 4, 5, 6, 35 }, { 7, 8, 9, 35 } };
            //int[,] myMultiArr2 = new int[3, 3];

            //myMultiArr[0, 0] = 42;
            //myMultiArr[0, 1] = 43;
            //myMultiArr[0, 2] = 44;

            //foreach (int i in myMultiArr)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("-----");
            //foreach (int i in myMultiArr2)
            //{
            //    Console.WriteLine(i);
            //}

            //int[][] myJaggedArr = new int[3][];

            //myJaggedArr[0] = new int[7];
            //myJaggedArr[1] = new int[3];
            //myJaggedArr[2] = new int[5];

            //myJaggedArr[0][0] = 42;
            //myJaggedArr[1][0] = 71;
            //myJaggedArr[2][0] = 11;

            //foreach (int[] arr in myJaggedArr) 
            //{
            //    foreach (int i in arr)
            //    {
            //        Console.Write($"Value is : {i}\n");
            //    }
            //    Console.WriteLine("\n---"); 
            //}

            //  \n -> new line
            //  \t -> tab space

            // ##################################
            // ####### WHILE LOOP ###############
            // ##################################

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int j = 0;

            //char userKey = ' ';

            //bool isAlive = true;

            //while (isAlive) 
            //{

            //}

            //while (userKey == ' ')
            //{
            //    Console.WriteLine("Hit a key except spacebar");
            //    userKey = Console.ReadKey().KeyChar;
            //}

            //Console.WriteLine("Program ended");


            //int myVar = 0;

            //while(true)
            //{
            //    if (myVar > 10)
            //    {
            //        break;
            //    }

            //    myVar++;
            //}

            //int myVar = 0;

            //bool check = true;

            //bool check2 = true;

            //while (check || check2)
            //{
            //    myVar++;

            //    if (myVar > 50 && check)
            //    {
            //        check = false;
            //        Console.WriteLine("Value of check changed as False");
            //    }

            //    if (myVar > 100)
            //    {
            //        check2 = false;
            //        Console.WriteLine("Value of check2 changed as False");
            //    }
            //}
            //Console.WriteLine("Program Ended");

            //Console.WriteLine($"myVar : {myVar}");
            //Console.WriteLine($"check : {check}");
            //Console.WriteLine($"check2 : {check2}");


            // ####### FACTORIAL #######

            //int factorial = 36;

            //long factorialResult = Factorial(factorial); ;

            //Console.WriteLine($"{factorial}! = {factorialResult}");

        }

        //static long Factorial(int number)
        //{
        //    long result = 1;

        //    while (number > 1)
        //    {

        //        result *= number; // CONPOUND ASSIGNMENT
        //        number--;

        //    }

        //    return result;
        //}
    }
}
