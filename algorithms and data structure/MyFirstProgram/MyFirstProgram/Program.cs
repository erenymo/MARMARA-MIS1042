using Eren; /* you don't have to write Eren in front of MyFirstClass again and again. */
using System.Reflection.Metadata;

namespace MyFirstProgram /* Defining different namespaces for different teams */
{
    internal class Program
    {
        static void Main(string[] args) // All C# programs starts with Main method.
        {
            MyFirstClass x = new MyFirstClass();

            x.MyMethod();

            /*
            // THE DIFFERENCE BETWEEN FUNCTION VS METHOD

            functions and methods are the same things in different locations
            methods should be located in classes
            function should be located outstide of classes
        
            // THE DIFFERENCE BETWEEN STATEMENT AND EXPRESSION
            statements do something but do not return a value.
            Expressions return a value.

            */


            //TODO: Do something here
            Console.WriteLine("Hello, World!");
            Console.WriteLine(""); // CTRL + left click action opens the source code that written by microsoft (where does this method come from).

            Console.WriteLine("--------------------------------");

            /*
             Method Parameters : () it confirms that the text is a method. 
             [] - attribute
            */


            /*************************************************/
            /*                  VARIABLES                    */
            /*************************************************/

            /*
            
            // Primitive Variables - Boxes with a fixed size
            
            integers : int, long                        consumes 4 bytes of memory
            floating point numbers: float, double              
            decimal : decimal (1000.15 TL)
            true / false : booleans  - bool
            single character : char   'A' 'B'


            // Object  (not primitive) - are more flexible about their size : 

            strings(char array) : string  (string's size cannot be identified at the beginning)


            // Notation

            myFirstVariable - camel case
            MyFirstVariable - pascal case
            i_myFirstVariable - hungarian notation
            my-first-variable - kebab case
           
            // HOW TO DEFINE VARIABLE
             
            C# is a STATICALLY TYPED LANGUAGE - you have to mention the variable type
            (PYTHON , JAVASCRIPT DYNAMICLY TYPED LANGUAGE)
            [variable type] [variable name] = [value]
             
            variable names must be meaningful and logical.
            variable names should start with letter (can't start with number). 
            use Camel Case naming (myFirstVariableName)

             */

            double vat = 1.18;  // Expression
            double appleBasePrice = 15.0;   // Expression
            double pearBasePrice = 17.0;    // Expression
            double quinceBasePrice = 12.0;  
            double garlicBasePrice = 30.0;

            string currencyName; // you can define a variable without assigning the value.
            currencyName = " TL";

            

            Console.WriteLine("PRODUCT PRICE LIST");
            Console.WriteLine("******************");

            Console.Write("Apple : ");  // Console.Write = won't create a new line after the text.
            Console.Write(appleBasePrice * vat); // *(operator) is used for multiplication. 
            Console.WriteLine(currencyName);   // Console.WriteLine = create a new line after the text.

            Console.Write("Pear : ");   // Statement
            Console.Write(pearBasePrice * vat); 
            Console.WriteLine(currencyName); // Statement

            Console.Write("Quince : ");
            Console.Write(quinceBasePrice * vat);
            Console.WriteLine(currencyName);

            Console.Write("Garlic : ");
            Console.Write(garlicBasePrice * vat);
            Console.WriteLine(currencyName);

            Console.WriteLine("");
            Console.WriteLine("--------------------------------");

            /*
            1 byte = 8 bit
            1 bit = 0 or 1
            RAM'ın herbir hücresinde 1 byte'lik alan var.

            // For the numbers without decimal points (INT TYPES) (TAM SAYILAR) 
            short          consumes less memory
            int - integer  consumes 4 bytes of memory
            long -         consumes 6 8 bytes of memory


            // integer over flow

            if you exceed max value of int, it goes to min value;
            if you exceed min value of int, it goes to max value (like a circle)

            you can change int to long to avoid this issue.
             */

            short myFirstShort = 102;
            Console.WriteLine("MyFirstInteger value : " + myFirstShort);
            Console.WriteLine("MyFirstInteger memory space : " + sizeof(short));
            Console.WriteLine("Biggest number a short can keep : " + short.MaxValue);
            Console.WriteLine("Smallest number a short can keep : " +short.MinValue);
            Console.WriteLine("");

            int myFirstInteger = 15;
            Console.WriteLine("MyFirstInteger value : "+ myFirstInteger);
            Console.WriteLine("MyFirstInteger memory space : " + sizeof(int));
            Console.WriteLine("Biggest number an int can keep : " + int.MaxValue);
            Console.WriteLine("Smallest number an int can keep : " + int.MinValue);

            Console.WriteLine("");

            long myFirstLong = 42;
            Console.WriteLine("MyFirstInteger value : " + myFirstLong);
            Console.WriteLine("MyFirstInteger memory space : " + sizeof(long));
            Console.WriteLine("Biggest number a long can keep : " + long.MaxValue);
            Console.WriteLine("Smallest number a long can keep : " + long.MinValue);

            Console.WriteLine("");
            Console.WriteLine("############");
            Console.WriteLine("");

            /* unassigned forms of integers */

            ushort myFirstUShort = 102;
            Console.WriteLine("MyFirstUInteger value : " + myFirstUShort);
            Console.WriteLine("MyFirstUInteger memory space : " + sizeof(ushort));
            Console.WriteLine("Biggest number a ushort can keep : " + ushort.MaxValue);
            Console.WriteLine("Smallest number a ushort can keep : " + ushort.MinValue);
            Console.WriteLine("");

            uint myFirstUInteger = 15;
            Console.WriteLine("MyFirstUInteger value : " + myFirstUInteger);
            Console.WriteLine("MyFirstUInteger memory space : " + sizeof(uint));
            Console.WriteLine("Biggest number an uint can keep : " + uint.MaxValue);
            Console.WriteLine("Smallest number an uint can keep : " + uint.MinValue);

            Console.WriteLine("");

            ulong myFirstULong = 42;
            Console.WriteLine("MyFirstUInteger value : " + myFirstULong);
            Console.WriteLine("MyFirstUInteger memory space : " + sizeof(ulong));
            Console.WriteLine("Biggest number a ulong can keep : " + ulong.MaxValue);
            Console.WriteLine("Smallest number a ulong can keep : " + ulong.MinValue);


            Console.WriteLine("");
            Console.WriteLine("--------------------------------");

            // integer over flow

            int integerOverFlow = int.MaxValue;
            Console.WriteLine("Integer at max value : " + integerOverFlow);
            integerOverFlow = integerOverFlow + 1;
            Console.WriteLine("Integer exceeded max value : " + integerOverFlow);

            Console.WriteLine("");
            Console.WriteLine("--------------------------------");

            int integerOverFlow2 = int.MinValue;
            Console.WriteLine("Integer at min value : " + integerOverFlow2);

            /* The checked keyword is used to explicitly check overflow and conversion of integral type values at compile time.
            checked 
            {
                integerOverFlow2 = integerOverFlow2 - 1;
            }
            */

            Console.WriteLine("Integer exceeded min value : " + integerOverFlow2);

            Console.WriteLine("");
            Console.WriteLine("--------------------------------");


            /*
            // For the numbers with decimal points (ONDALIKLI SAYILAR)

            FLOAT - you have to use 'f' at the end of the value when you define a float variable.
            FLOAT (4bytes) - The first 6 digits of the decimal part are precise.
            DOUBLE (8bytes)- The first 12 digits of the decimal part are precise.
            DECIMAL (16bytes)- you have to use 'm' at the end of the value when you define a decimal variable.
            
            epsilon - shows us the sensitiviness 
            
            
            for monetary calculations, use decimal,  do not use float or double because of the precision issues.
            float and double don't have unassigned form
            */



            float myFirstFloat = 42.0f;
            Console.WriteLine("MyFirstFloat value : " + myFirstFloat);
            Console.WriteLine("Biggest number for float : " + float.MaxValue);
            Console.WriteLine("Smallest number for float : " + float.MinValue);
            Console.WriteLine("Memory consumption of a float variable : " + sizeof(float));
            Console.WriteLine(float.Epsilon); // float veri tipinin gösterebileceği en küçük pozitif tam sayı değerini temsil eder.

            Console.WriteLine("");

            double myFirstDouble = 42.0;
            Console.WriteLine("MyFirstDouble value : " + myFirstDouble);
            Console.WriteLine("Biggest number for double : " + double.MaxValue);
            Console.WriteLine("Smallest number for double : " + double.MinValue);
            Console.WriteLine("Memory consumption of a double variable : " + sizeof(double));
            Console.WriteLine(double.Epsilon); // double veri tipinin gösterebileceği en küçük pozitif tam sayı değerini temsil eder.

            Console.WriteLine("");

            decimal myFirstDecimal = 42.0m;
            Console.WriteLine("MyFirstDecimal value : " + myFirstDecimal);
            Console.WriteLine("Biggest number for decimal : " + decimal.MaxValue);
            Console.WriteLine("Smallest number for decimal : " + decimal.MinValue);
            Console.WriteLine("Memory consumption of a decimal variable : " + sizeof(decimal));

            Console.WriteLine("");
            Console.WriteLine("--------------------------------");

            /*
            BOOLEAN consumes 1 byte of memory
            true or false
            */

            bool myFirstBool = true;
            Console.WriteLine("My first bool value : " + myFirstBool);
            Console.WriteLine("Boolean memory consumption : " + sizeof(bool));

            Console.WriteLine("");
            Console.WriteLine("--------------------------------");

            /*
            CHAR

            C# characters represented in UTF-16 (consumes 2 bytes or 4 bytes of memory)
            every character represented in numbers.
            only keep 1 character 
            use single quotes. ''


            escape sequence characters (they are not visible but do smth on the screen)
            \n --> new line
            \t --> tab space
            \a --> alert sound
             */

            char myFirstChar = 'A';
            Console.WriteLine("MyFirstChar value : " + myFirstChar);
            Console.WriteLine("Char type memory consumption : " + sizeof(char));
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");

            /*
            STRINGS
            */

            string myFirstString = "Eren BALTA";
            Console.WriteLine("MyFirstString value : " + myFirstString);


            int myVar = 7;
            Console.WriteLine("Value of myVar : " + myVar);

            string myName = "Eren" + " " + "BALTA";
            Console.WriteLine(myName);

            //STRING INTERPOLATION  ($"string : {variable}")

            string justAnotherStringWithInterp = $"Value of myVar : {myVar}";
            Console.WriteLine(justAnotherStringWithInterp);

            Console.WriteLine("");

            string name = "Eren";
            string surname = "BALTA";
            int courseQty = 7;
            string job = "Student";

            string report = $"Name : {name}\nSurname : {surname}\nJob Title : {job}\nCourse Quantity : {courseQty}";
            
            Console.WriteLine(report);
            Console.WriteLine($"Absolute value of 2 - 4 = {Math.Abs(2-4)}");

            /* OPERATORS
            + - % * / ++ -- ()

            you can also use % operator to take several digit numbers

            unary - expects one operands
            binary - expects two operands
            ternary - expects three operands

            Variables : Precedence and Associativity
            https://www.tutorialspoint.com/csharp/csharp_operators_precedence.htm
            */

            ulong myNumber = 5462374569465652;
            ulong myNumber2 = 10000;

            ulong remainder = myNumber % myNumber2;
            Console.WriteLine("remainder is : " + remainder);

            /*
            // COMPOUND ASSIGNMENT  += , -= , *= , /= , ++ , --
            int myNum = 9;
            myNum = myNum + 3;   or  myNum += 3;    increases myNum value by 3

            myNum = myNum + 1;   or  myNum++;  increases myNum value by 1

            ++myNum = önce +1 ekler daha sonra değeri döndürür

            myNum++ = önce değeri döndürür daha sonra +1 ekler.
             */


            //========= CONST KEYWORD - Constant =========

            /*
             when you define const with variable, you can not change it's value later.
             use PascalCase when you define a variable with const keyword
             

            int myIntVar;
            myIntVar = 7;
            myIntVar = 15;
            myIntVar = 42;

            const int MyConst = 42;

            const float VatConst = 1.18f;
            */

            Console.WriteLine("");
            Console.WriteLine("--------------------------------");

            /*************************/
            /*        METHOD         */
            /*************************/

            /*
            () Operator confirms that the text is a method.
            () - manipulate operator precedence(öncelik) 
            Method kullanmanın amacı, tekrar eden kod bloğunu tek bir methodla birden fazla kez kullanmaya yarar. 
            Use PascalCase notation while you are defining a method. 
             */


            //CONSTANT DEFINITIONS
            const float VAT = 1.10f;

            //VARIABLE DEFINITIONS
            float appleBasePrice2 = 15.0f; 
            float pearBasePrice2 = 17.0f; 
            float quinceBasePrice2 = 12.0f;
            float garlicBasePrice2 = 30.0f;

            string currencyName2= "TL"; 

            //REPORTING
            Console.WriteLine("PRODUCT PRICE LIST");
            Console.WriteLine("******************");

            Console.WriteLine($"Apple : {appleBasePrice2 * VAT} {currencyName2}");  

            Console.WriteLine($"Pear : {pearBasePrice2 * VAT} {currencyName2}");   

            Console.WriteLine($"Quince : {quinceBasePrice2 * VAT} {currencyName2}");

            Console.WriteLine($"Garlic : {garlicBasePrice2 * VAT} {currencyName2} ");
            Console.WriteLine("-----");

            int absoluteValue = Math.Abs(-2);
            Console.WriteLine(absoluteValue);

            Report(); // use the method name and paranthesis to call a method. 


        }


        /*
        If you want a method to return value, you have define the variable type(int, double, string) before the method name.
        for ex: static int Calculation() {}

        If you don't, then use void keyword mean that the method will not return anything.
        for ex: static void Report() {}
         */

        static void Report() // void keyword mean that this method will not return anything.
        {
            Console.WriteLine("Hello from");
            Console.WriteLine("Report Method");

        }

        
    }
}