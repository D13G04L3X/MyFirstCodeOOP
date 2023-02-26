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
        public Date BirthDate { get; set; }
        public Date HiringDate { get; set; }                // Fecha de contratación
        public bool IsActive { get; set; }

        #region Methods

        public abstract decimal GetValueToPay();            // (Abstract) Metodo sin implemnetación y sin llaves que no retorna valor

        public override string ToString()
        {
            return $"---EMPLOYEE---\n\t " +                      //Son saltos de línea
                $"ID: {Id} \n\t " +
                $"FirstName: {FirstName} \n\t " +
                $"LastName: {LastName} \n\t " +
                $"BirthDate: {BirthDate} \n\t " +
                $"HiringDate: {HiringDate} \n\t " +
                $"IsActive?: {IsActive}";              
        
        }

        #endregion

        #endregion


    }
}
