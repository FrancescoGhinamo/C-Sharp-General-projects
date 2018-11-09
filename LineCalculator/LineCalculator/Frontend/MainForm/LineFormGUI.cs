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
        private PointList points;

        public LineFormGUI()
        {
            InitializeComponent();
        }

        public void LineFormGUI_Load(object sender, System.EventArgs e)
        {
            points = new PointList();
        }

        private void BtnParse_Click(object sender, EventArgs e)
        {

        }
    }
}
