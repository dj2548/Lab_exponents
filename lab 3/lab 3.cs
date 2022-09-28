using System;
using System.Security.Cryptography.X509Certificates;

namespace lab_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
           bool run = true;
            while (run)
            {
                Console.WriteLine("Learn you squares and cubes! \n");
                Console.WriteLine("Enter a number: ");
                double num = double.Parse(Console.ReadLine());
                

                for (int i = 1; i <= num; i++)
                {
                    double num2 = i * i;
                    double num3 = i * i * i;

                    Console.WriteLine(i + "\t" + num2 + "\t" + num3);
                }
                Console.WriteLine("Would you like to Continue? (Y/N)");
                string input = Console.ReadLine();
                if (input == "n")
                { 
                run = false;
                    {

                    } if (input == "y") 
                    {
                             run = true;
                            }
                }
                
            }
        }
    }
}

        