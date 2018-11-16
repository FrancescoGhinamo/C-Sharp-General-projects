using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCalculator.Backend.MathObjects.Points
{
    /// <summary>
    /// Dynamic list of Points
    /// </summary>
    public class PointList : List<Point>
    {
        /// <summary>
        /// New method to add a point to the List
        /// </summary>
        /// <param name="p">Point to add</param>
        public new void Add(Point p)
        {
            if(p != null)
            {
                base.Add(p);
            }
            
        }
    }
}
