using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program.Third_Project.Part_01;

namespace Program.Third_Project.Part_03
{
    //Create an abstract class User with:
    //o A Name property to store the user name.
    //o An abstract method GetDiscount() that returns a Discount object.
    //Implement the following specific user types:
    //o RegularUser: Applies a PercentageDiscount of 5%.
    //o PremiumUser: Applies a FlatDiscount of $100.
    //o GuestUser: No discount is applied 
    internal class GuestUser : User
    {
        public override Discount GetDiscount()
        {
            return null;
        }
    }
}
