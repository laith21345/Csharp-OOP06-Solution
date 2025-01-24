using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Part_01.First_Project
{
    internal class Point3DXYComparer : IComparer<Point3D>
    {
        public int Compare(Point3D? first, Point3D? second)
        {
            if (first == null && second == null) return 0;
            if (first == null) return -1;
            if (second == null) return 1;

            sbyte xIsLarge = (sbyte)first.X.CompareTo(second.X);

            if (xIsLarge != 0)
                return xIsLarge;

            return first.Y.CompareTo(second.Y);
        }
    }
}
