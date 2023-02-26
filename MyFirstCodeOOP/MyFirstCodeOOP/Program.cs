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
                var dateObject = new Date(2002, 12, 3);                    //Notipado de C#, para saber el tipo de dato que recibe la variable, aparte necesita el número de variables que debo traer
                Console.WriteLine(dateObject);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

