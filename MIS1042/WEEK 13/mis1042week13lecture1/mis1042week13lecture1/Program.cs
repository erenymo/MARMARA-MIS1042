namespace mis1042week13lecture1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             // Bilal'in sorduğu soru (marmara -> mermere)
             string myString = "marmara";
             string myString2 = "";

             char[] myCharArray = myString.ToCharArray();

             for (int i = 0; i < myCharArray.Length; i++)
             {
                 if (myString[i] == 'a')
                 {
                     myString2 += 'e';
                 }else
                 {
                     myString2 += myString[i];
                 }
             }

             Console.WriteLine(myString2);

             //Console.WriteLine(myCharArray);


             //myString = "";
             //for (int i = 0; i < myCharArray.Length; i++)
             //{
             //    myString += myCharArray[i];
             //}

             //myString = string.Join(" ",myCharArray);


             //Console.WriteLine(myString);
            */

            /*
            DateTime firstDateTime = new DateTime(2023, 5, 30, 10, 04, 00);
            DateTime secondDateTime = new DateTime(2023, 6, 7, 09, 00, 00);
            Console.WriteLine(firstDateTime);
            Console.WriteLine(secondDateTime);
            Console.WriteLine("-----");

            TimeSpan result = secondDateTime - firstDateTime;
            Console.WriteLine($"Days: {result.Days}");
            Console.WriteLine($"Hours: {result.Hours}");
            Console.WriteLine($"Minutes: {result.Minutes}");
            Console.WriteLine($"Seconds: {result.Seconds}");
            */
            /*
            Console.Write("Please enter your birth date : ");
            
            string userEntry = Console.ReadLine(); // String olarak hafızada tutuyor.

            DateTime birthDay;

            bool isConverted = DateTime.TryParse(userEntry, out birthDay);

            if (isConverted)
            {
                TimeSpan result = DateTime.Now - birthDay;
                Console.WriteLine($"You are {result.Days} days old");
                Console.WriteLine($"Total Minutes : {result.TotalMinutes}");
                Console.WriteLine($"Total Hours : {result.TotalHours}");

            }
            else
            {
                Console.WriteLine($"Please enter valid date !");
            }
            */

            /*
            TimeSpan myTimeSpan = new TimeSpan(25,10, 5, 30); // days, hours, minutes, seconds, miliseconds

            TimeSpan[] myArr = new TimeSpan[5];
            myArr[0] = TimeSpan.FromDays(1);
            myArr[1] = TimeSpan.FromHours(1);
            myArr[2] = TimeSpan.FromMinutes(1);
            myArr[3] = TimeSpan.FromSeconds(1);
            myArr[4] = TimeSpan.FromMilliseconds(1);

            foreach (TimeSpan t in myArr)
            {
                Console.WriteLine(t);
            }
            */
            /*
            // DateTime ve TimeSpan arasındaki işlemler
            DateTime dateTime = DateTime.Now;

            TimeSpan timeSpan = TimeSpan.FromDays(10000);

            DateTime result = dateTime - timeSpan; // Datetime - Timespan also returns Datetime. 

            Console.WriteLine(dateTime);
            Console.WriteLine(result);    
            Console.WriteLine(result.DayOfWeek);
            */

            /////////// DateTimeOffset

            //DateTimeOffset dateTimeOffset = DateTimeOffset.Now;

            //TimeSpan timeSpan = TimeSpan.FromDays(1);

            //Console.WriteLine(dateTimeOffset);

            //dateTimeOffset += timeSpan;

            //Console.WriteLine(dateTimeOffset);

            //DateTimeOffset dateTime = new DateTimeOffset(2021, 5, 30, 10, 00, 00, TimeSpan.FromHours(3));

            /*
            /////// DateOnly - TimeOnly
            DateTime myDate = DateTime.Now;
            Console.WriteLine(myDate);

            DateOnly dateOnly = new DateOnly(2023,5,30);
            TimeOnly timeOnly = new TimeOnly(11, 09, 00);

            Console.WriteLine(dateOnly);
            Console.WriteLine(timeOnly);
            */


            Console.Write("Please enter your birth date: ");

            string birthDayStr = Console.ReadLine();

            DateTime birthDay;

            bool isConverted = DateTime.TryParse(birthDayStr, out birthDay);

            if (isConverted)
            {
                TimeSpan result = DateTime.Now - birthDay;

                int age = (int)result.TotalDays / 365; // .TotalDays returns double, we should type conversion double to int.

                Console.WriteLine($"You are {age} years old");
                
            } else
            {
                Console.WriteLine("Please enter a valid date");
            }

            /*
            TimeSpan maxTime = TimeSpan.MaxValue;
            Console.WriteLine(maxTime);
            maxTime += new TimeSpan(0, 0, 0, 1);
            Console.WriteLine(maxTime);
            */
        }
    }
}