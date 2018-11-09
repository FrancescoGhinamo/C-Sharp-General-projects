using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCalculator.Backend.MathObjects.Points
{

    /// <summary>
    /// Ponit in the cartesian plate of type (x, y)
    /// </summary>
    public class Point
    {
        #region PrivateFields
        /// <summary>
        /// x coordinate
        /// </summary>
        private double x { get; }
        /// <summary>
        /// y coordiante
        /// </summary>
        private double y { get; }

        #endregion PrivateFields

        #region Constructor
        /// <summary>
        /// Contstructor for a Point object
        /// </summary>
        /// <param name="x"> x coordinate</param>
        /// <param name="y"> y coordinate</param>
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        #endregion Constructor
    }
}
