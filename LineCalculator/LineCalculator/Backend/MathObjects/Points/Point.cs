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
        private double X;
        /// <summary>
        /// y coordiante
        /// </summary>
        private double Y;

        #endregion PrivateFields

        #region Constructor
        /// <summary>
        /// Contstructor for a Point object
        /// </summary>
        /// <param name="x"> x coordinate</param>
        /// <param name="y"> y coordinate</param>
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        #endregion Constructor

        #region Getters
        public double GetX()
        {
            return this.X;
        }

        public double GetY()
        {
            return this.Y;
        }
        #endregion Getters

    }
}
