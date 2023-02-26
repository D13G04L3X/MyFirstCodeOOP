using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    public class CommissionEmployee : Employee              // Se hace la herencia de la clase
    {
        #region Properties
        public float CommissionPercentage { get; set; }
        public decimal Sales { get; set; }          //Ventas

        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)ConvertPercentage(CommissionPercentage);
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tCommission Percentage......{ConvertPercentage(CommissionPercentage):P2}" +
                $"\n\tSales......................{Sales:C2}" +                           //Currency, valor monetario de 2 cifras
                $"\n\tValue to pay...............{GetValueToPay():C2}";
        }

        public float ConvertPercentage(double commissionPercentage)             //Requirimiento de porcentaje
        {
            return (CommissionPercentage/100);
        }
        #endregion
    }
}
