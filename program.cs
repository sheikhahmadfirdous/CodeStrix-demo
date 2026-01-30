using System;
using System.Data;
using System.IO.Pipelines;
using System.Runtime.InteropServices;
using System.Threading; // Required for the waiting part
class program
{
    static void Main()
    {


        Console.WriteLine("Enter 1 to print even Numbers:\nEnter 2 to print odd Number\nEnter 3 to buy a Coffie \nEnter 4 to check is number prime number or not\n Enter 5 to show prime numbers  ");
        int userNumber = int.Parse(Console.ReadLine());
        switch (userNumber)
        {
            case 1:
                Console.WriteLine("Even numbers from 0 to 1000:");


                for (int i = 0; i <= 1000; i = i + 2)
                {
                    Console.WriteLine(i);
                }
                break;

            case 2:

                Console.WriteLine("Enter a number:");
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine(num + " is even number.");
                }
                else
                {
                    Console.WriteLine(num + " is odd number .");

                }
                break;

            case 3:

                int Coffieprice = 0;
            start:
                Console.WriteLine("Please Slect your Coffie size \n Enter 1 for Small \n Enter 2 for Medium\n Enter 3 forS Large:");
                int UserChoice = int.Parse(Console.ReadLine());

                switch (UserChoice)
                {
                    case 1:
                        Coffieprice += 10;
                        break;

                    case 2:
                        Coffieprice += 20;
                        break;

                    case 3:
                        Coffieprice += 30;
                        break;

                    default:
                        Console.WriteLine("your choice {0} is invalid" , UserChoice);
                        goto start;
                }
                Desion:
                Console.WriteLine("Do you want to buy another Coffie ? Yes/NO");
                string UserDesion = Console.ReadLine().
                    swich(UserDesion.ToUpper());
                     {
                    case "YES":
                        goto start;
                        case "NO":
                        break;
                        Console.WriteLine("Invalid input. {0} Please enter 'yes' or 'no'." ,UserDesion);
                        goto Desion;


                    }
                     Console.WriteLine("Thank you for Shopping with us")
                     Console.WriteLine("your total coffie price is {0} ", Coffieprice);
                // close inner switch
                break; // end case 3 of outer switch

            case 4:
                Console.WriteLine("Using while loop to print numbers from 0 to 4:");
                int a = 0;
                while (a < 5)
                {
                    Console.WriteLine(a);
                    a++;
                }
                break;

            case 5:

                Console.WriteLine("Ente your number ");
                int numb = int.Parse(Console.ReadLine());

                bool isPrime = true;

                if (numb <= 1)
                    isPrime = false;
                else
                {
                    for (int x = 2; x <= Math.Sqrt(numb); x++)
                    {
                        if (numb % x == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                if (isPrime)
                    Console.WriteLine(numb + " is a prime number.");
                else
                    Console.WriteLine(numb + " is not a prime number.");
                break;


        }
    }
}











