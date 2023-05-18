namespace mis1042week11lecture2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string firstName = "Marmara";

            //bool isFound = false;

            //char charToLook = 'm';

            //int index = 0;

            //while (!isFound && index< firstName.Length) 
            //{
            //    if (charToLook == firstName[index])
            //    {
            //        isFound = true;
            //        break;
            //    }
            //    index++;
            //}

            //if (isFound)
            //{
            //    Console.WriteLine($"{charToLook} is found in {firstName}. Index Value is {index}");
            //} else
            //{
            //    Console.WriteLine($"{charToLook} is not found in {firstName}.");
            //}


            // ####### DO WHILE LOOP #######

            //Random rnd = new Random();

            //int hiddenNumber = rnd.Next(0, 101);

            //Console.WriteLine($"Hidden Number is: {hiddenNumber}");

            //bool winCondition = false;

            //Console.WriteLine("**************************************");
            //Console.WriteLine("**                                  **");
            //Console.WriteLine("**      GUESS THE NUMBER GAME       **");
            //Console.WriteLine("**                                  **");
            //Console.WriteLine("**************************************");

            //do
            //{
            //    Console.WriteLine();
            //    Console.Write("Guess the number: ");
            //    string guessString = Console.ReadLine();

            //    int guess;

            //    bool resultOfParse = int.TryParse(guessString, out guess); //intParse()

            //    while (!resultOfParse)
            //    {
            //        Console.Write("\rPlease type a numeric value: ");
            //        guessString = Console.ReadLine();
            //        resultOfParse = int.TryParse(guessString, out guess);
            //    }

            //    if (guess == hiddenNumber)
            //    {
            //        Console.WriteLine("You won!");

            //        Console.Write("Do you want to play again? [Y / N]");

            //        ConsoleKeyInfo answer = Console.ReadKey();

            //        do
            //        {
            //            if (answer.KeyChar == 'Y' || answer.KeyChar == 'y' || answer.KeyChar == 'N' || answer.KeyChar == 'n')
            //            {
            //                break;
            //            }
            //            else
            //            {

            //                Console.Write("\rPlease use only [Y]es or [N]o keys:");
            //                answer = Console.ReadKey();
            //            }

            //        } while (true);


            //        if (answer.KeyChar == 'Y' || answer.KeyChar == 'y')
            //        {
            //            hiddenNumber = rnd.Next(0, 101);
            //            Console.WriteLine($"\nHidden Number is: {hiddenNumber}");
            //            continue;
            //        }
            //        else if (answer.KeyChar == 'N' || answer.KeyChar == 'n')
            //        {
            //            Console.WriteLine("\nThank you for playing!");
            //            winCondition = true;
            //        }

            //    }
            //    else if (guess > hiddenNumber)
            //    {
            //        Console.WriteLine("Your guess is too high!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Your guess is too low!");
            //    }

            //} while (!winCondition);

            //float myFloat = 42.55f;
            //int myInt = (int)myFloat; // EXPLICIT CONVERSION   FLOAT TO INTEGER

            //Console.WriteLine($"my Float : {myFloat}");
            //Console.WriteLine($"my Float : {myInt}");
            //Console.WriteLine($"----------");

            //int myInt2 = 42;
            //float myFloat2 = myInt2; // IMPLICIT CONVERSION

            //Console.WriteLine($"my Float : {myFloat2}");
            //Console.WriteLine($"my Float : {myInt2}");

            //long myLong = 42;
            //int x = (int)myLong;

            //Console.WriteLine($"Long max value is : {long.MaxValue}");
            //Console.WriteLine($"Long max value is : {int.MaxValue}");

        }
    }
}