using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerProgrammingPracticeCode4_15_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Excerses number 1
            //input :none
            //process:no process
            //output
            Console.WriteLine("Hello World");
            */

            /*
            //EX 2 simple caulator
            //input 2 numbers
            //decalves variabels
            double number1 = 0;
            double number2 = 0;
            double resultadd = 0;
            double resultsub = 0;
            double resultmul = 0;
            double resultdiv = 0;


            //promt user input for number 1
            Console.WriteLine("enter number 1");
            number1 = Convert.ToDouble(Console.ReadLine());

            //promt user inpt for number 2
            Console.WriteLine("enter number 2");
            number2 = Convert.ToDouble(Console.ReadLine());

            //processing:add, subtract, multiply, and divison
            resultadd = number1 + number2;
            resultsub = number1 - number2;
            resultmul = number1 * number2;
            resultdiv = number1 / number2;


            //outputs:results
            Console.WriteLine(" starting numbers " + number1 + " : " + number2 + " \n " +
                " Addtion: " + resultadd + " \n " +
                " Subtraction: " + resultsub + " \n " +
                " Multiply: " + resultmul + " \n " +
                " Divide: " + resultdiv);
            */

            /*
            //Ex3 find area of circle
            //declaer varibles
            double cirarea = 0;
            double cirradius = 0;

            //promt user input
            Console.WriteLine(" enter the radious of the circle ");
            cirradius = Convert.ToDouble(Console.ReadLine());

            //caluates area of circle
            //cirarea = Math.PI * (cirradius * cirradius);
            cirarea = Math.PI * Math.Pow(cirradius, 2);

            //outputs results
            Console.WriteLine(" the area of the circle is " + cirarea);
           */

            /*
            //Ex4 convert celsisu to fahrenheit

            //decaler vairbels
            double celtemp = 0;
            double fahtemp = 0;

            //promt user input
            Console.WriteLine(" Enter a temp in celsius ");
            celtemp = Convert.ToDouble(Console.ReadLine());
            
            //calcualte temp in faherenhiet
            fahtemp = (celtemp * 9 / 5) + 32;

            //outputs results
            Console.WriteLine(" the celsisu temp " + celtemp + " is equal to " + fahtemp);
            */

            /*
            //Ex5 detemine if even or odd

            //decalre vairbles 
            int userIntinput = 0;
            int resultnumber = 0;

            //promt user input
            Console.WriteLine(" enter an integer to see if its even of odd ");
            userIntinput = Convert.ToInt32(Console.ReadLine());

            //determines if even or odd
            resultnumber = userIntinput % 2;

            //output results
            if (resultnumber == 0)
            {
                Console.WriteLine(" user input is even number ");
            }
            else
            {
                Console.WriteLine(" user input is odd number ");
            }
            */
            
            //Ex 6 age in moths

            //decaleva varibels 
            int ageyears = 0;
            int agemonths = 0;

            //promt user input
            Console.WriteLine(" enter your age ");
            ageyears = Convert.ToInt32(Console.ReadLine());

            //calualte age in mothns
            agemonths = ageyears * 12;

            //outputs results
            Console.WriteLine(" you are " + ageyears + " years old in months you are " + agemonths);
            



            Console.Read();

        }
    }
}
