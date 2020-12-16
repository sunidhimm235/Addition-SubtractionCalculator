using System;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //This program is developed in C# to provide two types of calculations or operations, addition and 
            //subtraction.

            //Array
            double[] AddHistory = new double[100];
            double[] SubHistory = new double[100];

            //Caling Variables
            char input;
            double input1, input2, total;
            int AddCount = 0, SubCount = 0;

            //Program
            Write("What type of calculation or operation do you want to perform? Type 'A' for Addition and " +
                "'S' for Subtraction or 'Q' to Quit: ");
            input = Convert.ToChar(ReadLine());

            while(input != 'Q')
            {
                if(input == 'A')
                {
                    Write("Enter the first number: ");
                    input1 = Convert.ToDouble(ReadLine());
                    AddHistory[AddCount] = input1;
                    AddCount++;
                    Write("Enter the second number: ");
                    input2 = Convert.ToDouble(ReadLine());
                    AddHistory[AddCount] = input2;
                    AddCount++;
                    total = AddiTion(input1, input2);
                    WriteLine("Your total is {0}.", total);
                    AddHistory[AddCount] = total;
                    AddCount++;
                    Write("What type of calculation or operation do you want to perform? Type 'A' for Addition and " +
                        "'S' for Subtraction or 'Q' to Quit: ");
                    input = Convert.ToChar(ReadLine());
                }
                else if(input == 'S')
                {
                    Write("Enter the first number: ");
                    input1 = Convert.ToDouble(ReadLine());
                    SubHistory[SubCount] = input1;
                    SubCount++;
                    Write("Enter the second number: ");
                    input2 = Convert.ToDouble(ReadLine());
                    SubHistory[SubCount] = input2;
                    SubCount++;
                    total = SubTraction(input1, input2);
                    WriteLine("Your total is {0}.", total);
                    SubHistory[SubCount] = total;
                    SubCount++;
                    Write("What type of calculation or operation do you want to perform? Type 'A' for Addition and " +
                        "'S' for Subtraction or 'Q' to Quit: ");
                    input = Convert.ToChar(ReadLine());
                }
            }

            //History
            Write("Do you want to see your history of calculations? Type 'Y' for Yes and 'N' for No: ");
            input = Convert.ToChar(ReadLine());
            if(input == 'Y')
            {
                WriteLine("Your addition history is:");
                for(int a = 0; a < AddHistory.Length; a = a + 3)
                {
                    int a1 = a + 1;
                    int a2 = a + 2;
                    if (AddHistory[a] != 0 && AddHistory[a1] != 0 && AddHistory[a2] != 0)
                        WriteLine("{0} + {1} = {2}", AddHistory[a], AddHistory[a1], AddHistory[a2]);
                }
                WriteLine("Your subtraction history is:");
                for (int s = 0; s < SubHistory.Length; s = s + 3)
                {
                    int s1 = s + 1;
                    int s2 = s + 2;
                    if (SubHistory[s] != 0 && SubHistory[s1] != 0 && SubHistory[s2] != 0)
                        WriteLine("{0} - {1} = {2}", SubHistory[s], SubHistory[s1], SubHistory[s2]);
                }
            }
            //End
            WriteLine("Thank you using my program!");
        }

        //Subtraction method
        private static double SubTraction(double i1, double i2)
        {
            double total;
            total = i1 - i2;
            return total;
        }

        //Addition method
        private static double AddiTion(double i1, double i2)
        {
            double total;
            total = i1 + i2;
            return total;
        }
    }
}
