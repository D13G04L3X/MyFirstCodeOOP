using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    public abstract class Employee
    {
        #region Properties

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Date BirthDate { get; set; }                 //setea los valores que se ingresan como fecha
        public Date HiringDate { get; set; }                // Fecha de contratación
        public bool IsActive { get; set; }

        #region Methods

        public abstract decimal GetValueToPay();            // (Abstract) Metodo sin implemnetación y sin llaves que no retorna valor

        public override string ToString()
        {
            return String.Format(                                   //Mejor que la extrapolación de $
                "-------EMPLOYEE-------\n\t" +
                "Id.................{0}\n\t" +
                "Last Name..........{2}\n\t" +
                "First Name.........{1}\n\t" +
                "Birth Day..........{3}\n\t" +
                "Hiring Date........{4}\n\t" +
                "Is Active?.........{5}",
                Id,
                FirstName,
                LastName,
                BirthDate,
                HiringDate,
                IsActive);

            //return $"-----EMPLOYEE------\n\t " +                      //Son saltos de línea
            //    $"ID: {Id} \n\t " +
            //    $"FirstName: {FirstName} \n\t " +
            //    $"LastName: {LastName} \n\t " +
            //    $"BirthDate: {BirthDate} \n\t " +
            //    $"HiringDate: {HiringDate} \n\t " +
            //    $"IsActive?: {IsActive}";      
        }

        #endregion

        #endregion


    }
}
