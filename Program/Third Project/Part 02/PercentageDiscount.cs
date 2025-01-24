using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Third_Project.Part_01
{
    internal class PercentageDiscount : Discount
    {
        public decimal Percentage { get; set; }

        public PercentageDiscount(decimal _percentage)
        {
            Percentage = _percentage;
            Name = "Percentage Discount";
        }

        public override decimal CalculateDiscount(decimal _price, int _quantity)
        {
            return _price * _quantity * (Percentage / 100);
        }
    }
}
