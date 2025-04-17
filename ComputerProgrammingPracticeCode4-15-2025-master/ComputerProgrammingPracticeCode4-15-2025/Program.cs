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
            /*
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
            */
            /*
            //Ex 7 Simple Interest Calculator
            
            //decalre vairbales
            double principleamout = 0;
            double interestrate = 0;
            int timeyears = 0;
            double totalinterest = 0;

            //promt user input
            Console.WriteLine(" Enter the pricple amount ");
            principleamout = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Enter the intrest rates(in decmial format) ");
            interestrate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Enter the time of the loan in years ");
            timeyears = Convert.ToInt32(Console.ReadLine());

            //calate loan
            totalinterest = principleamout * interestrate * timeyears;

            //output results
            Console.WriteLine(" the total interest of the loan is: " + totalinterest);
            */
            /*
            //Ex 8 name greeting

            //decaler variables
            string username = "";

            //promt user input
            Console.WriteLine(" enter your name ");
            username = Console.ReadLine();

            //output results
            Console.WriteLine(" Hello " + username);
            */
            /*
            //Ex9 Sum of two number

            //decaler variables
            int usernumber1 = 0;
            int usernumber2 = 0;
            int ussernumbersum = 0;

            //promt user input
            Console.WriteLine(" enter the first number ");
            usernumber1 = Convert.ToInt32(Console.ReadLine());

            //promt user input
            Console.WriteLine(" enter the second number ");
            usernumber2 = Convert.ToInt32(Console.ReadLine());


            //calcualtes the total sum
            for (int i = 0; i < usernumber1; i++)
            {
                ussernumbersum = ussernumbersum + 1;
            }

            for (int i = 0; i < usernumber2; i++)
            {
                ussernumbersum = ussernumbersum + 1;
            }

            //outputs results
            Console.WriteLine(" the results of the sum is: " + ussernumbersum);

            /*
            foreach (int i in usernumber1)
            {
                ussernumbersum = ussernumbersum + 1;
            }
            */

            /*
            //Ex10 simple password checkor

            //decalr varibles
            string userpassword = "";
            string userconfirmpassword = "";

            //promt user input 
            Console.WriteLine(" enter a password ");
            userpassword = Console.ReadLine();

            //promt user input
            Console.WriteLine(" confirm the password ");
            userconfirmpassword= Console.ReadLine();

            //if else to determine if password is the same of not
            if (userpassword == userconfirmpassword)
            {
                Console.WriteLine(" welcome ");
            }
            else
            {
                Console.WriteLine(" wrong password ");
            }
            */

            /*
            //EX 11 number classififcation

            //decalres variables
            int userinput = 0;
            int oddeventst = 0;

            //promt user input 
            Console.WriteLine(" enter an integer ");
            userinput = Convert.ToInt32(Console.ReadLine());

            //calcsulates if its postive negatic or zero
            if (userinput == 0)
            {
                Console.WriteLine(" user input is zero ");
            }
            else if(userinput >= 1)
            {
                //Console.WriteLine(" user input is a postive number");


                //checks to see if its even or od
                oddeventst = userinput % 2;
                if (oddeventst == 0)
                {
                    Console.WriteLine(" the number is a postive even number ");

                }
                else
                {
                    Console.WriteLine(" the number is a positve odd number ");
                }



            }
            else
            {
               // Console.WriteLine(" user input is  a negative number");
                //checks to see if its even or odd


                //checks to see if its even or od
                oddeventst = userinput % 2;
                if (oddeventst == 0)
                {
                    Console.WriteLine(" the number is a negative even number ");

                }
                else
                {
                    Console.WriteLine(" the number is a negeative odd number");
                }

            }
            */
            /*
            //Ex 12 grade converter

            //decalers variables 
            int numbergrade = 0;
            string lettergrade = "";
            int gradeD10 = 0;

            //promt user input 
            Console.WriteLine(" enter a number grade as a integer ");
            numbergrade = Convert.ToInt32(Console.ReadLine());


            gradeD10 = numbergrade / 10;
            

            //switch to find letter grade
            switch (gradeD10)
            {
                case 10:
                case 9:
                    //outputs A grade  90-100
                    Console.WriteLine(" the letter grade is A");
                    break;
                case 8:
                    //outputs B grade 80-89
                    Console.WriteLine(" the letter grade is B ");
                    break;
                case 7:
                    //outputs C grade 70-79
                    Console.WriteLine(" the letter grade is C ");
                    break;
                case 6:
                    //outputs D grade 60-69
                    Console.WriteLine(" the letter grade is D ");
                    break;
                case 5:
                    //outputs F grade 0-59
                    Console.WriteLine(" the letter grade is F ");
                    break;
                default:
                    //outputs invalid grade
                    Console.WriteLine(" grade entered was invalid" ); 
                    break;

            }
            */

            









          Console.Read();

        }
    }
}
