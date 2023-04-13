namespace BMIandMore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // CIRCUMFERENCE OF CIRCLE = 2*PI*r
            double radius = 2.0;
            Console.WriteLine("Radius of the circile is : " + radius);
            Console.WriteLine($"Circumference of the circle is : {Math.Ceiling(Circumference(radius))}"); // Math.Ceiling - ondalıklı sayıyı kendisinden büyük en küçük tam sayıya yuvarlar.
            Console.WriteLine($"Area of the circle is : {Math.Ceiling(Area(radius))}");
            */

            // BODY MASS INDEX CALC
            double height = 180;
            double weight = 85;

            double bmi = BMICalc(height, weight);
            Console.WriteLine($"BMI is : {Math.Round(bmi)}");

            Console.WriteLine($"Feedback : {BMIEvaluation(bmi)}");
            Console.WriteLine("----------------");


            /*
            // COMPARISON OPERATORS
             
            <- SMALLER
            >- BIGGER
            == EQUAL
            <= SMALL OR EQUAL
            >= BIGGER OR EQUAL
            != NOT EQUAL
             

            comparison operators might not work properly on floating point numbers. float and double.
            this rule is valid especially for == (equality operator)
             */

            // IF ELSE STATEMENTS (statements does not return a value)

            int firstNum = 42;
            int secondNum = 101;

            if (firstNum < secondNum) // if the statement in paranthesis is true, it will execute code that inside the curly brackets
            {
                // iki süslü parantezin arasına tanımladığımız değişkenlerin etki alanı, tanımlandığı iki süslü parantezin arasındadır.

                Console.WriteLine("firstNum is smaller than the secondNum");
            }
            else if (firstNum == secondNum)
            {
                Console.WriteLine("firstNum is equal to the secondNum");
            }
            else
            {
                Console.WriteLine("firstNum is bigger than the secondNum");
            }

            Console.WriteLine("After the if statement");

            Console.WriteLine("----------------");
            /*
             LOGIC OPERATORS
            
            && - and
            || - or
            !  - not

            they accept boolean values
             */
            int x = 42;
            int y = 101;
            int a = 15;
            int b = 25;
            bool q = x < 100;
            bool w = y > x;

            Console.WriteLine($"Value of q is : {q}");
            Console.WriteLine($"Value of w is : {w}");
            Console.WriteLine("------");
            Console.WriteLine($"q && w : {q && w}");
            Console.WriteLine($"q || w : {q || w}");
            Console.WriteLine($"!q : {!q}");
            Console.WriteLine($"!w : {!w}");

            Console.WriteLine("----------------");

            Console.WriteLine($"(a > b) && (x > y) : {(a > b) && (x > y)}");

            Console.WriteLine($"((a > b) && (x > y)) || (x > a) : {((a > b) && (x > y)) || (x > a)}");

            Console.WriteLine("----------------");
            // DRIVING LICENCE

            int age = 16; // should be greater than or equal to 18
            int examResult = 70; // evaluation criteria is if its above 70 its a success.
            bool practicalExam = true;
            string name = "Eren Balta";
            bool hasRightToGetLicence = DriversLicenceEval(age, examResult, practicalExam);

            ResultReport(name, age, examResult, practicalExam, hasRightToGetLicence);

            Console.WriteLine($"");



        }
        static double BMICalc(double heightInCm, double weight)
        {
            // BODY MASS INDEX = weight / height * height

            double heightInM = heightInCm / 100; // unit is converted from centimeter to meter
            double heightPowTwo = Math.Pow(heightInM, 2); // Math.Pow(height, 2) instead of height**2

            double bmi = weight / heightPowTwo;
            return bmi;
        }

        static string BMIEvaluation(double bmi)
        {
            if (bmi < 18.5)
            {
                return "You are underweighted. Eat More !";
            }
            else if (bmi <= 24.9)
            {
                return "You are normal weighted. Keep continuing with this weight !";
            }
            else if (bmi <= 24.9)
            {
                return "You are overweighted. Try to eat less !";
            }
            else
            {
                return "You are obese. See a doctor !";
            }
        }

        static bool DriversLicenceEval(int age, int exam, bool practical)
        {
            if ((age >= 18) && (exam > 70) && practical)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void ResultReport(string name, int age, int exam, bool practical, bool finalEval)
        {
            Console.WriteLine("");
            Console.WriteLine("+++++ DRIVERS LICENCE EVALUATION REPORT ++++++");
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"Exam : {exam}");

            string drivingExam = "";
            if (practical)
            {
                drivingExam = "Passed";
            }
            else
            {
                drivingExam = "Failed";
            }

            Console.WriteLine($"Driving Exam : {drivingExam}");

            string finalResult = "";

            if (finalEval)
            {
                finalResult = "Congrats ! You can get a driving licence.";
            }
            else
            {
                if (age < 18)
                {
                    finalResult += "You have to be older than 18 yeras old.";
                }

                if (exam <= 70)
                {
                    finalResult += "You have to get a minimum of 71 marks from the exam";
                }

                if (!practical)
                {
                    finalResult += "You failed from practical evaluation. Try again";
                }

            }
            Console.WriteLine("-------");
            Console.WriteLine($"Final Evaluation : {finalResult}");

        }


        /*  CIRCLE EXAMPLE
        static double Circumference(double r) 
        {
            double circumference = 2 * Math.PI * r;
            return circumference; 
        }

        static double Area(double r)
        {
            double area = Math.PI * Math.Pow(r, 2);
            return area;
        }
        */

    }
}