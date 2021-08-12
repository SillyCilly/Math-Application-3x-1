using System;

namespace _3x___1
{
    class Program
    {
        static void Main(string[] args)
        {
            //setting up a boolean variable to check when the user wants to stop using the program                     
            bool userCheck = true;

            while (userCheck)
            {
                Console.WriteLine("Enter the number: ");
                int getnumber = Convert.ToInt32(Console.ReadLine());

                //creating an index to keep tabs on number of steps
                int index = 1;
                while (Calc(getnumber) > 0)
                {
                    //prints the number after calculation
                    Console.WriteLine(Calc(getnumber));
                    
                    //condition to stop at 1 or reset the numberr
                    if (Calc(getnumber) == 1)
                    {
                        break;
                    }
                    else
                    {
                        getnumber = Calc(getnumber);

                        index ++;
                    }
                    
                }

                Console.WriteLine("The total number of steps to reach 1: " + index);
                Console.WriteLine();

                //asking if user wants to continue
                Console.WriteLine("Do you want to choose another number? (y/n)");

                string cont = Console.ReadLine();
                
                //switch cases to check user's reply
                switch (cont)
                {
                    case "y":
                        Console.Clear();
                        break;

                    case "n":
                        Console.WriteLine("Thanks for using the program!");
                        System.Threading.Thread.Sleep(800);
                        Console.WriteLine(".");
                        System.Threading.Thread.Sleep(800);
                        Console.WriteLine(".");
                        System.Threading.Thread.Sleep(800);
                        Console.WriteLine(".");
                        Environment.Exit(0);
                        break;

                    case "yes":
                        Console.Clear();
                        break;

                    case "no":
                        Console.WriteLine("Thanks for using the program!");
                        System.Threading.Thread.Sleep(800);
                        Console.WriteLine(".");
                        System.Threading.Thread.Sleep(800);
                        Console.WriteLine(".");
                        System.Threading.Thread.Sleep(800);
                        Console.WriteLine(".");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Error, please try again");

                        System.Threading.Thread.Sleep(800);
                        Console.WriteLine(".");
                        System.Threading.Thread.Sleep(800);
                        Console.WriteLine(".");
                        System.Threading.Thread.Sleep(800);
                        Console.WriteLine(".");
                        Console.WriteLine();
                        break;
                }


            }
           

           
        }

        static int Calc(int num1)
        {
            int result;

            
            if (num1%2 == 0)
            {
                result = num1 / 2;
            }
            else
            {
                result = (num1 * 3) + 1;
            }

                   
            return result;

            
        }
    }
}
