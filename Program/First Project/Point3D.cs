using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Part_01.First_Project
{
    //*************************
    // ------- First Project :
    //*************************
    //
    //1. Define 3D Point Class and the basic Constructors(use chaining in constructors).
    //2. Override the ToString Function to produce this output:
    //            Point3D P = new Point3D(10, 10, 10);
    //            Console.WriteLine(P.ToString());
    //            Output: “Point Coordinates: (10, 10, 10)”.
    //3. Read from the User the Coordinates for 2 points P1, P2(Check the input using try Pares, Parse, Convert).
    //4. Try to use  ==
    //If(P1 == P2)   Does it work properly? 
    //5. Define an array of points and sort this array based on X &Y coordinates.
    //6. Implement ICloneable interface to be able to clone the object. 
    internal class Point3D
    {

        #region Properties
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        #endregion

        #region Constructor
        public Point3D(double _x, double _y, double _z)
        {
            X = _x;
            Y = _y;
            Z = _z;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }
        #endregion

    }
}
