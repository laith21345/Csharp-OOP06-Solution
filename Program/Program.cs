using Microsoft.VisualBasic;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Xml.Linq;
using Program.Part_01.First_Project;
using Program.Part_01.Second_Project;
using Program.Third_Project.Part_03;
using Program.Third_Project.Part_01;

namespace Program
{
    internal class Program
    {
        //not completed
        public static byte TryReadByte()
        {
            //switch (Type.GetTypeCode(typeof(TRead)))
            //{
            //    case int:
            //        isParsed = true;
            //        break;
            //}
            bool isParsed;
            byte number;
            do
            {
                isParsed = byte.TryParse(Console.ReadLine(), out number);

                if (isParsed)
                    return number;
                else
                    Console.WriteLine("Invalid byte");

            }
            while (true);

        }

        public static int TryReadInt()
        {
            bool isParsed;
            int number;
            do
            {
                isParsed = int.TryParse(Console.ReadLine(), out number);

                if (isParsed)
                    return number;
                else
                    Console.WriteLine("Invalid int");

            }
            while (true);

        }

        public static decimal TryReadDecimal()
        {
            bool isParsed;
            decimal number;
            do
            {
                isParsed = decimal.TryParse(Console.ReadLine(), out number);

                if (isParsed)
                    return number;
                else
                    Console.WriteLine("Invalid decimal");

            }
            while (true);

        }



        //بسم الله الرحمن الرحيم
        //Assignment 06 OOP
        static void Main(string[] args)
        {
            #region First Project
            // =================================================================================================
            // --------------------------------- First Project -------------------------------------------------------
            // =================================================================================================
            //
            //1. Define 3D Point Class and the basic Constructors(use chaining in constructors).
            //2. Override the ToString Function to produce this output:
            //            Point3D P = new Point3D(10, 10, 10);
            //            Console.WriteLine(P.ToString());
            //            Output: “Point Coordinates: (10, 10, 10)”.
            //3. Read from the User the Coordinates for 2 points P1, P2(Check the input using try Pares, Parse, Convert).
            //4. Try to use  ==
            //If(P1 == P2)   Does it work properly? "No i should overload on it"
            //5. Define an array of points and sort this array based on X &Y coordinates.
            //6. Implement ICloneable interface to be able to clone the object. 

            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(P);

            //double x;
            //double.TryParse(Console.ReadLine(), out x);

            //double y = double.Parse(Console.ReadLine());
            //double z = Convert.ToDouble(Console.ReadLine());

            //Point3D P1 = new Point3D(x, y, z);


            //double.TryParse(Console.ReadLine(), out x);
            //y = double.Parse(Console.ReadLine());
            //z = Convert.ToDouble(Console.ReadLine());

            //Point3D P2 = new Point3D(x, y, z);

            //Point3D[] points = { P1, P2 };

            //Console.WriteLine("Before Sorting");
            //for (int i = 0; i < points.Length; i++)
            //{
            //    Console.WriteLine(points[i]);
            //}
            //Console.WriteLine();

            //Console.WriteLine("After Sorting");
            //Array.Sort(points, new Point3DXYComparer());
            //for (int i = 0; i < points.Length; i++)
            //{
            //    Console.WriteLine(points[i]);
            //}

            #endregion

            #region Second Project
            //Define Class Maths that has four methods:
            //●	Add()
            //●	Subtract()
            //●	Multiply()
            //●	Divide()
            //Each of them takes two parameters.
            //Call each method in Main ().
            //NOTE : Modify the program so that you do not have to create an instance of class to call the four methods. 

            //Console.WriteLine(Maths.Add(5,3));
            //Console.WriteLine(Maths.Add(5.54,3));


            //Console.WriteLine(Maths.Subtract(5,3));
            //Console.WriteLine(Maths.Subtract(5.54,3));


            //Console.WriteLine(Maths.Multiply(5,3));
            //Console.WriteLine(Maths.Multiply(5.54,3));


            //Console.WriteLine(Maths.Divide(5,3));
            //Console.WriteLine(Maths.Divide(5.54,3));

            //Console.WriteLine(Maths.Divide(5.54,0));
            #endregion

            #region Third Project
            //You are tasked with designing a system for an e-commerce platform that calculates discounts for different types of users and products.
            //This system should utilize abstraction and include the following parts:

            #region Part 01
            //*****************************************
            // ------- Part 01: Abstract Discount Class
            //*****************************************
            //
            //Create an abstract class Discount with:
            //** An abstract method CalculateDiscount(decimal price, int quantity) that returns the discount
            //   amount based on the original price and quantity.
            //** A Name property to store the type of discount.  
            #endregion

            #region Part 02
            //*****************************************
            // ------- Part 02: Specific Discounts
            //*****************************************
            //
            //Implement the following concrete discount classes:
            //o PercentageDiscount:
            //▪	    Accepts a percentage (e.g., 10%).
            //▪	    Formula: Discount Amount = Price×Quantity×(Percentage/100)
            //o FlatDiscount:
            //▪	    Accepts a fixed amount to be deducted(e.g., $50).
            //▪	    Formula: Discount Amount = Flat Amount×min(Quantity, 1)
            //o BuyOneGetOneDiscount:
            //▪	    Applies a 50 % discount if the quantity is greater than 1.
            //▪	    Formula: Discount Amount = (Price / 2)×(Quantity÷2)

            #endregion

            #region Part 03
            //*****************************************
            // ------- Part 03: Discount Applicability 
            //*****************************************
            //
            //Create an abstract class User with:
            //o A Name property to store the user name.
            //o An abstract method GetDiscount() that returns a Discount object.
            //Implement the following specific user types:
            //o RegularUser: Applies a PercentageDiscount of 5%.
            //o PremiumUser: Applies a FlatDiscount of $100.
            //o GuestUser: No discount is applied  

            #endregion

            #region Part 04
            //*****************************************
            // ------- Part 04: Integration
            //*****************************************
            //
            //Write a program that:
            //o Ask  the user to input their type(Regular, Premium, or Guest).
            //o Allows the user to input product details(price and quantity).
            //o Calculates and displays the total discount and final price after applying
            //  the appropriate discount. 

            //byte userType;
            //User user = null;

            //Console.WriteLine("Select the number of the user type:");
            //Console.WriteLine("1.Regular user");
            //Console.WriteLine("2.Premium user");
            //Console.WriteLine("3.Guest");

            //do
            //{
            //    userType = TryReadByte();

            //    if (userType < 1 || userType > 3)
            //        Console.WriteLine("Invalid Choice");
            //}
            //while (userType < 1 || userType > 3);

            //switch (userType)
            //{
            //    case 1:
            //        user = new RegularUser();
            //        break;
            //    case 2:
            //        user = new PremiumUser();
            //        break;
            //    case 3:
            //        user = new GuestUser();
            //        break;
            //}

            //Console.WriteLine("Enter price and quantity for the item");
            //decimal price = TryReadDecimal();
            //int quantity = TryReadInt();

            //decimal discount = user!.GetDiscount().CalculateDiscount(price, quantity);
            //decimal totalPrice = price * quantity - discount;

            //Console.WriteLine($"Price ={price}\nQuantity ={quantity}\nDiscount ={discount}\nTotal price ={totalPrice}");

        }
        #endregion
        #endregion

    }
}

