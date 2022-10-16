using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        //initial layout from lectures
        //Set up while/try/ifelseif to call from menu selection
        //Trouble with references...
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            while (true)
            {
                int menu = DisplayMenu();

                try
                {
                    //intelisence recomends to let it build a reference but returns a blank method...
                    if (menu == 1)
                    {
                        Console.WriteLine("Input A Number:");
                        var operation = client.PrimeNumber(int.Parse(Console.ReadLine()));
                        Console.WriteLine(operation + "\n");
                    }
                    else if (menu == 2)
                    {
                        Console.WriteLine("Input Numbers:");
                        var operation = client.SumOfDigits(int.Parse(Console.ReadLine()));
                        Console.WriteLine(operation + "\n");
                    }
                    else if (menu == 3)
                    {
                        Console.WriteLine("Input A String:");
                        var operation = client.ReverseString(Console.ReadLine());
                        Console.WriteLine(operation + "\n");
                    }
                    else if (menu == 4)
                    {
                        Console.WriteLine("Input a HTML Tag:");
                        var tag = Console.ReadLine();
                        Console.WriteLine("Input Some Text:");
                        var data = Console.ReadLine();
                        var operation = client.PrintHtmlTags(tag, data);
                        Console.WriteLine(operation + "\n");
                    }
                    else if (menu == 5)
                    {
                        Console.WriteLine("Input Ascending or Decending");
                        var type = Console.ReadLine();
                        Console.WriteLine("Inout An Array, Spacing With A Comma ',' :");
                        var data = Console.ReadLine();
                        var arr = client.SortNumbers(type, Array.ConvertAll(data.Split(','), int.Parse));
                        Console.WriteLine("{0}\n", string.Join(",", arr));
                    }
                    else if (menu == 6)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }


        //menu recycled from old projects
        //Names from the assignment page
        static int DisplayMenu()
        {
            Console.WriteLine("WCF Assignment 1");
            Console.WriteLine("1. Prime Number");
            Console.WriteLine("2. Sum Of Digits");
            Console.WriteLine("3. Reverse A String");
            Console.WriteLine("4. Print HTML Tags");
            Console.WriteLine("5. Sort 5 Numbers");
            Console.WriteLine("6. Exit");
            Console.Write("Make A Selection: ");

            var client = Console.ReadLine();

            Console.Clear();

            try
            {
                return int.Parse(client);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}