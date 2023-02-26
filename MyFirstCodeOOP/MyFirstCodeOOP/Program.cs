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

                Employee salaryEmployee = new SalaryEmployee()    //instacnciar el objeto de la clase hija a la abstracta
                {
                    Id = 1000,
                    FirstName = "Monica",
                    LastName = "Galindo",
                    BirthDate = new Date(1950, 2, 5),
                    HiringDate = new Date(2022, 12, 31),
                    IsActive = true,
                    Salary = 200000.34M             //Convierte el double a un decimal con la M al final

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

