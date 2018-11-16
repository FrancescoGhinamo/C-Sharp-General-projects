using LineCalculator.Backend.MathObjects.Equation;
using LineCalculator.Backend.MathObjects.Points;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Point = LineCalculator.Backend.MathObjects.Points.Point;

namespace LineCalculator
{
    /// <summary>
    /// The LineForm
    /// </summary>
    public partial class LineFormGUI : Form
    {
        /// <summary>
        /// List of points
        /// </summary>
        private PointList Points;

        public LineFormGUI()
        {
            InitializeComponent();
        }

        public void LineFormGUI_Load(object sender, System.EventArgs e)
        {
            Points = new PointList();
        }

        private void BtnParse_Click(object sender, EventArgs e)
        {
            LinearEquation eq = new LinearEquation(TxtEqn.Text);
            
            Points.Clear();
            LstPoint.Items.Clear();
            //Points.Add(new Point(1, 0));

            //stack overflow
            for (int i = 0; i < 100; i++)
            {
                Points.Add(eq.Eval(i));
            }

            foreach (Point p in Points)
            {
                LstPoint.Items.Add(p.GetX().ToString() + "\t\t" + p.GetY().ToString());
            }
            
        }
    }
}
