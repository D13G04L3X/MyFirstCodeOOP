using System;                       // Se pueden implementar n interfaces
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP.Helper
{
    public class EmployeeHelper
    {
        #region Fields
        private Employee _salaryEmployee;
        private Employee _commissionEmployee;
        private Employee _contractorEmployee;
        private Employee _baseCommissionEmployee;

        #endregion

        #region Methods

        public EmployeeHelper(Employee salaryEmployee, Employee commissionEmployee, Employee contractorEmployee, Employee baseCommissionEmployee)               //Constructor
        {
            _salaryEmployee = salaryEmployee;
            _commissionEmployee = commissionEmployee;
            _contractorEmployee = contractorEmployee;
            _baseCommissionEmployee = baseCommissionEmployee;
        }

        public decimal GetPayrollFromActiveEmployees() 
        {
            ICollection<Employee> employees = new List<Employee>()           //Lista del tipo Employee, nombre de la lista se instancia como una lista 
                {
                    _salaryEmployee,
                    _commissionEmployee,
                    _contractorEmployee,
                    _baseCommissionEmployee
                };

            decimal payroll = 0;

            foreach (Employee employee in employees)              // De la lista de empleados se saca cada empleado. El foreach se usa para coleeciones y/o listas
            {
                if (employee.IsActive == true)
                {
                    Console.WriteLine("");
                    Console.WriteLine(employee);                        // El ToString() es por defecto, por eso no se declara
                    Console.WriteLine("");
                    payroll += employee.GetValueToPay();
                }
            }

            return payroll;

        }
        #endregion
    }
}
