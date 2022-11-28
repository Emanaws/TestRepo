using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Write a C# Sharp program that takes a number and a width also a number, as input and then displays 
            a triangle of that width, using that number.
            
          Console.WriteLine("Please Provide Your Number");
            int N = int.Parse(Console.ReadLine());
            int c = 1;
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++) 
                {
                    Console.Write(c + " ");
                    c++;
                }*/
            /*--------------------------
            int N = int.Parse(Console.ReadLine());
            int c = 1;
            for (int i = N; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(c + " ");
                        c++;
                    }
                    Console.WriteLine();
                 }
            */
            /*
             Write a C# Sharp program that takes two numbers as input and perform an 
            operation (+,-,*,x,/) on them and displays the result of that operation
             
            int Num = 50;
            int Deno = 5;
            int result = Num - Deno;
            Console.WriteLine("Result = {0}", result);
           */

            /*
            Write a C# Sharp program that takes the radius of a circle as input and 
            calculate the perimeter and area of the circle.
            PI= 3.14
             
            Console.WriteLine("Enter Radious: ");
            double Radious = Convert.ToDouble(Console.ReadLine());
            double A = Math.PI * Radious * Radious;
            //double A = (3.14) * Radious * Radious;
            Console.WriteLine("Area of circle: " + A);
            */
            /*
             Write a C# Sharp program that takes distance and time as input and displays the speed in 
             kilometres per hour and miles per hour
            
            float distance;
            float hour, min, sec;

            float timeSec;
            float mps;
            float kph, mph;

            Console.Write("Input distance(metres): ");
            distance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(hour): ");
            
            hour = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(minutes): ");
            min = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(seconds): ");
            sec = Convert.ToSingle(Console.ReadLine());

            timeSec = (hour * 3600) + (min * 60) + sec;
            mps = distance / timeSec;
            kph = (distance / 1000.0f) / (timeSec / 3600.0f);
            mph = kph / 1.609f;

            Console.WriteLine("Your speed in metres/sec is {0}", mps);
            Console.WriteLine("Your speed in km/h is {0}", kph);
            Console.WriteLine("Your speed in miles/h is {0}", mph);
            */

            /*
             Write a C# Sharp program that takes a character as input and check the input (lowercase) is a vowel, 
             a digit, or any other symbol.
           

            char symbol;
            Console.Write("Enter your symbol: ");
            symbol = Convert.ToChar(Console.ReadLine());
            if((symbol == 'a') || (symbol == 'e') || (symbol=='i') || (symbol=='o') || (symbol=='u'))
                Console.WriteLine("It's a lowercase vowel.");
            else if((symbol >= '0') && (symbol <= '9'))
                Console.WriteLine("It's a digit.");
            else
                Console.Write("It's another symbol.");
           */
            /*
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i + ", ");
            }*/

            /* Write a program to revert your name
            
            // original string
            string str = "Redwan Omer";
            // reverse the string
            string red = string.Join(" ", str.Split(' ').Select(s => new String(s.Reverse().ToArray())));
            Console.WriteLine(red);
            */
            /*Write a program to convert your name into upper case
             Option1
                    string str; 
                    Console.WriteLine("Please Enter Your Name");
                    str = Console.ReadLine().ToString();
                    string upperstr = str.ToUpper();
                     Console.Write("Converted string is: " + upperstr);
           
            //Option2
                    string str;
                    Console.WriteLine("Please Enter Your Name");
                    str = Console.ReadLine().ToString();
                    Console.WriteLine("Converted string is: " +  str.ToUpper()); 
             */
			 Console.WriteLine("please enter your name");
            string str = Console.ReadLine().ToString();
            string result = str.Substring(0,1).ToUpper() + str.Substring(1);
                Console.WriteLine(result);
               Console.ReadLine();
        }
    }
}
