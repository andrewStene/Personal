using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plate_Calculator
{
    public partial class Form1 : Form
    {
        private double _totalWeight;
        private double _barWeight;

        private double[] _plateSizes;

        private double plate45 = 0;
        private double plate35 = 0;
        private double plate25 = 0;
        private double plate10 = 0;
        private double plate5 = 0;
        private double plate2half = 0;

        public Form1()
        {
            InitializeComponent();
            _totalWeight = 0;
            _barWeight = 0;
            _plateSizes = new double[] { 2.5, 5, 10, 25, 35, 45 };
        }

        private void FillTextBox()
        {
            _totalWeight -= _barWeight;
            FindMin(_totalWeight);

            if (plate45 % 2 == 1 || plate35 % 2 == 1 || plate25 % 2 == 1 || plate10 % 2 == 1 || plate5 % 2 == 1 || plate2half % 2 == 1)
                FindMin(_totalWeight);
                
            outputBox.Text = plate45.ToString() + " x 45\n" + plate35.ToString() + " x 35\n" + plate25.ToString() + " x 25\n" + plate10.ToString() + " x 10\n" + plate5.ToString() + " x 5\n" + plate2half.ToString() + " x 2.5\n";

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            _totalWeight = Convert.ToDouble(totalWeight.Text);
            _barWeight = Convert.ToDouble(barWeight.Text);

            if (_barWeight > _totalWeight)
            {
                MessageBox.Show("Error: Bar weighs more than the total weight. Please check and try again.");
            }

            FillTextBox();

            _totalWeight = 0;
            _barWeight = 0;

        }

        private void FindMin(double d)
        {

        }

    }

    public class WeightPlate
    {

        public double _weight { get; private set; }

        public WeightPlate()
        {
            _weight = 0;
            using var file = new System.IO.StreamWriter("test.txt");

        }

        public WeightPlate(double weight)
        {
            _weight = weight;
        }
    }
}
