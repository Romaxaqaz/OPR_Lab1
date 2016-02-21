using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bestcode.MathParser;
using OPR_Lab1.Domain;

namespace OPR_Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string function = FunctionTextBox.Text;
            int testStep = int.Parse(TestStepInputTextBox.Text);
            Point point = new Point();
            point.X = int.Parse(XinputTextBox.Text);
            point.Y = int.Parse(YinputTextBox.Text); ;
            BestSampleAlgorithm best = new BestSampleAlgorithm(function, point, testStep);
            var result = best.StartSolution();
            ResultOutputLable.Text = result.ToString();
        }
    }
}
