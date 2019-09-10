using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateConvexHullPoints
{
    class RadialSort : IComparer<Point>
    {
        Point pivot;

        public RadialSort(Point pivot)
        {
            this.pivot = pivot;
        }

        public int Compare(Point pt1, Point pt2)
        {
          //  int cmp = Lib.SignedArea(pivot, pt1, pt2);
            return 1;
        }
    }
}
