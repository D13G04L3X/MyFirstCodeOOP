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

                Console.WriteLine("*********Testing latest implementation*******");
                Console.WriteLine("");

                Employee salaryEmployee = new SalaryEmployee()    //instacnciar el objeto de la clase hija a la abstracta
                {
                    Id = Convert.ToInt32(Console.ReadLine()),
                    FirstName = Console.ReadLine(),
                    LastName = Console.ReadLine(),
                    BirthDate = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    HiringDate = new Date(2022, 3, 4),
                    IsActive = Convert.ToBoolean(Console.ReadLine()),
                    Salary = Convert.ToDecimal(Console.ReadLine())            // Convierte el double a un decimal con la M al final

                };

                Console.WriteLine(salaryEmployee);              // Va a dibujar lo que se hizo en la creación del objeto anterior 

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

