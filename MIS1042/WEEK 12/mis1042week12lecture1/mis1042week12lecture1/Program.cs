namespace mis1042week12lecture1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ALL PRIMITIVE VARIABLES ARE STRUCT IN C#.

            // Conversion between numeric types
            //int x = 42;
            //float y = x;
            //int z = (int)y;  // y'yi int'e dönüştür ve değeri z'ye ata. 

            // Parse


            // Conversion String to a Number
            //string myString = "Marmara";

            //int myInt = int.Parse(myString);
            //float myFloat = float.Parse(myString);
            //double myDouble = double.Parse(myString);
            //long myLong = long.Parse(myString);

            //int myInt2;

            //bool result = int.TryParse(myString, out myInt2);

            //if (result)
            //{
            //    Console.WriteLine(myInt2);
            //}

            //float myFloat2;
            //bool result2 = float.TryParse(myString, out myFloat2);

            //double myDouble2;
            //bool result3 = double.TryParse(myString, out myDouble2);

            //Converting a number to a string

            //int myInt = 42;

            //myInt.ToString();

            //Console.WriteLine(myInt);

            //float myFloat = 42.555f;
            //myFloat.ToString();

            //bool myBool = true;
            //myBool.ToString();

            //String myString = "Marmara";

            //char[] myArr = myString.ToCharArray();

            //myArr[myArr.Length - 1] = 'e';

            //foreach (char c in myArr)
            //{
            //    Console.WriteLine(c);
            //}


            // SWITCH EXPRESSION

            //var x = switch (x) // switch statement
            //{
            //    case 1:
            //        Console.WriteLine("x is 1");
            //        break;
            //    case 22:
            //        Console.WriteLine("x is 22");
            //        break;
            //    case 42:
            //        Console.WriteLine("x is 42");
            //        break;
            //    default:
            //        Console.WriteLine("x is something else");
            //        break;
            //}

            //int x = 42;

            //// Switch expression
            //char myChar = x switch
            //{
            //    1 => 'a',
            //    2 => 'b',
            //    42 => 'c',
            //    _ => 'd'
            //};  // switch expression ends with ; 

            //Console.WriteLine(myChar);

            //int grade = 77;

            //char gradeChar = GetGrade(grade);
            //Console.WriteLine($"Student's grade is {gradeChar}");

            //float weight = 85f;
            //float height = 1.80f;

            //Console.WriteLine(BMI(weight, height));


            //// DATETIME Type (class)

            //DateTime today = DateTime.Now;

            //Console.WriteLine(today);

            //Console.WriteLine($"Day : {today.Day}");
            //Console.WriteLine($"Mont : {today.Month}");
            //Console.WriteLine($"Year : {today.Year}");
 
            //Console.WriteLine($"Hours : {today.Hour}");
            //Console.WriteLine($"Minute : {today.Minute}");
            //Console.WriteLine($"Second : {today.Second}");
            
            
        }

        // Grade Calculator
        //static char GetGrade(int score)
        //{
        //    char grade = score switch
        //    {
        //        < 60 => 'F',
        //        < 70 => 'D',
        //        < 80 => 'C',
        //        < 90 => 'B',
        //        < 100 => 'A',
        //        _ => 'F',
        //    };
        //    return grade;
        //}

        //// BMI Calculator
        //static string BMI(float weight, float height)
        //{
        //    float bmi = weight / (height * height );
        //    string report = bmi switch
        //    {
        //        < 18.5f => "eat more, underweight",
        //        < 25f => "normal",
        //        < 30f => "eat less, overweight",
        //        _ => "obese, go doctor"
        //    }; 

        //    return report;
        //}
    }
}