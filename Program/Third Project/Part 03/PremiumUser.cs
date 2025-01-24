using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program.Third_Project.Part_01;

namespace Program.Third_Project.Part_03
{ 
    internal class PremiumUser : User
    {
        public override Discount GetDiscount()
        {
            return new FlatDiscount(100);
        }
    }
}
