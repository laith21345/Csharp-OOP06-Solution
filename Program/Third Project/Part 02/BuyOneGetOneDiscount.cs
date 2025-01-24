using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Third_Project.Part_01
{
    internal class BuyOneGetOneDiscount : Discount
    {
        public BuyOneGetOneDiscount()
        {
            Name = "Buy One Get One Discount";
        }

        public override decimal CalculateDiscount(decimal _price, int _quantity)
        {
            if (_quantity > 1)
            {
                return _price * 0.5M;
            }
            else
                return (_price / 2) * (_quantity / 2);
        }
    }
}
