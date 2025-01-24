using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Third_Project.Part_01
{
    internal abstract class Discount
    {
        // Property to store the type of discount
        public string Name { get; set; } = "Discount";

        // Abstract method to calculate the discount amount
        public abstract decimal CalculateDiscount(decimal price, int quantity);
    }
}
