using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Third_Project.Part_01
{
    internal class FlatDiscount : Discount
    {
        public decimal Amount { get; set; }

        public FlatDiscount(decimal _amount)
        {
            Amount = _amount;
            Name = "Flat Discount";
        }

        public override decimal CalculateDiscount(decimal _price, int _quantity)
        {
            return Amount * Math.Min(_quantity, 1);
        }
    }

}
