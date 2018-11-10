using LineCalculator.Backend.MathObjects.Points;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCalculator.Backend.MathObjects.Equation
{
    /// <summary>
    /// Representation of an equation of type y = mx + q
    /// </summary>
    public class LinearEquation
    {
        #region PrivateFields
        /// <summary>
        /// m coefficent of the equation
        /// </summary>
        private double M { get; }
        /// <summary>
        /// q coeffficent of the equation
        /// </summary>
        private double Q { get; }

        #endregion PrivateFields

        #region Constructor
        /// <summary>
        /// Constructor for LinearEquation from given string
        /// </summary>
        /// <param name="eqn">String of the equation in form y=mx+q</param>
        public LinearEquation(string eqn)
        {
            eqn.ToLower();
            try
            {
                M = Double.Parse(eqn.Substring(eqn.IndexOf('=') + 1, eqn.IndexOf('x') - eqn.IndexOf('=') - 1));
            }
            catch (Exception)
            {
                M = 1;
            }

            try
            {
                Q = Double.Parse(eqn.Substring(eqn.IndexOf('x') + 1));
            }
            catch (Exception)
            {
                Q = 0;
            }
        }

        #endregion Constructor

        #region MathMethods
        public Point Eval(double x)
        {
            return new Point(x, M * x + Q);
        }
        #endregion MathMethods
    }
}
