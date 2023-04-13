namespace exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fire(10, 100, true);
        }

        static void Fire(int weaponType, float enemyHealth, bool penalty)
        {
            // 5 types of weapons

            int projectileEnergyLevel = 0;

            // switch statements
            /*
            switch (weaponType)
            {
                case 0:
                    Console.WriteLine("Weapon type 0");
                    break;
                case 1:
                    Console.WriteLine("Weapon type 1");
                    break;
                case 2:
                    Console.WriteLine("Weapon type 2");
                    break;
                case 3:
                    Console.WriteLine("Weapon type 3");
                    break;
                case 4:
                    Console.WriteLine("Weapon type 4");
                    break;
                default:
                    Console.WriteLine($"There is no such thing as weapon type {weaponType}");
                    Console.WriteLine("Pick one of weapons between 0 to 4");
                    break;
            }
            */
            /*
            Console.WriteLine("MONTH - SEASON IDENTIFIER");
            Console.Write("Please enter the month as a number (Jan = 1 ... Dec = 12) : ");
            string userInput = Console.ReadLine(); //It is used to get values from the user in the console.  purple cube symbol means method.

            //CONVERT STRING TO AN INTEGER
            int month = Convert.ToInt32(userInput);

                switch (month)
                {
                    case 12:
                    case 1:
                    case 2:
                        Console.WriteLine("Season is winter");
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("Season is Spring");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("Season is Spring");
                        break;
                    default : 
                        Console.WriteLine("Season is Autmn");
                        break;
                }
            */

            /*
            Console.WriteLine("COURSE PERFORMANCE EVALUATOR");
            Console.Write("Please enter your grade as a character (A, B, C, D, F,) : ");

            char grade = Console.ReadKey().KeyChar; // 
            
            // CONVERT CHAR TO LOWERCASE
            //string gradeString = grade.ToString(); // char to string because .ToLower(); is work on string.
            //char gradeLowercase =Convert.ToChar(gradeString.ToLower()); // string to char

            char gradeLowerCase = Char.ToLower(grade); 
            
            Console.WriteLine();

            switch (gradeLowerCase)
            {
                case 'a':
                    Console.WriteLine("Excellent");
                    break;
                case 'b':
                    Console.WriteLine("Good");
                    break;
                case 'c':
                    Console.WriteLine("Average");
                    break;
                case 'd':
                    Console.WriteLine("Should be improved");
                    break;
                case 'f':
                    Console.WriteLine("Failed");
                    break;
                default:
                    Console.WriteLine("Please enter your grade as a character (A, B, C, D, F,) : ");
                    break;

            */

            /*
            Console.WriteLine("DIVISIBLE CHECK");
            Console.Write("Enter a number : ");

            string numString = Console.ReadLine();
            int num = Convert.ToInt32(numString);

            Console.WriteLine($"You have entered : {num}");

            
            if ((num%3 == 0) || (num%5 ==0)) // (değer döndürmez)
            {
                Console.WriteLine($"It is divisible by 3 or 5");
            }
            else
            {
                Console.WriteLine($"It is not divisible by 3 or 5");
            }
            


            // ? - TERNARY OPERATOR (değer döndürür)
            // soru işaretinden önceki kısmın değerlendirme sonucu doğruysa iki noktanın sol tarafını döndür, yanlışsa sağ tarafını döndür.
            string message = (num % 3 == 0) || (num % 5 == 0) ? "It is divisible by 3 or 5" : "It is not divisible by 3 or 5"; // short version of if else statement
            Console.WriteLine(message); */

            /*
            Console.WriteLine("VOWEL CHECK");
            Console.Write("Please enter a character : ");

            char userEnter = Console.ReadKey().KeyChar;
            char userEnterUpperCase = Char.ToUpper(userEnter);

            bool isVowel = VowelCheck(userEnterUpperCase);
            Console.WriteLine();

            if (isVowel)
            {
                Console.WriteLine("Vowel ");
            } else
            {
                Console.WriteLine("Not vowel");
            }
            */

            Console.WriteLine("REGISTRATION OF THE EVENT");
            Console.Write("Please enter your age : ");

            string ageInString = Console.ReadLine();
            int age = Convert.ToInt32(ageInString);

            if ((age >= 18 && age <= 25) || (age >= 40 && age <= 45))
            {
                Console.WriteLine("You can attend the event");
            }
            else
            {
                Console.WriteLine("You cannot attend the event. Your age should be between 18 - 25 or 40 - 45");
            }
        }
        /*
        static bool VowelCheck(char characterToCheck)
        {
            bool result = characterToCheck == 'A' || characterToCheck == 'E' || characterToCheck == 'U' || characterToCheck == 'I' || characterToCheck == 'O';
            return result;
        }
        */
    }
}