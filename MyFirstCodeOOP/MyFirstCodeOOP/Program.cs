using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MyFirstCodeOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Date dateObject = new Date(2023, 2, 29);
                Console.WriteLine("****************");
                Console.WriteLine("* OOP CONCEPTS *");
                Console.WriteLine("****************");

                Console.WriteLine("Please put your birth date year:");
                var year = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Please put your birth date month:");
                var month = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Please put your birth date day:");
                var day = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine(new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)));
                Console.WriteLine("");



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

