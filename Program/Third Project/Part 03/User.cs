using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program.Third_Project.Part_01;

namespace Program.Third_Project.Part_03
{
    internal abstract class User
    {
        public string Name { get; set; }

        public abstract Discount GetDiscount();
    }
}
