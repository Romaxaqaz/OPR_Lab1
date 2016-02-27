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
using OPR_Lab1.Serializer;

namespace OPR_Lab1
{
    public partial class Form1 : Form
    {
        private readonly string SerializePathObject = "OPR_SAVE_PARAMS.bin";
        private BestSampleAlgorithm best;

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            best = GetObjectBestSampleAlgorithm();
            if (best != null) SetControlParams(best);
            if (best == null) SaveCheckBox.Checked = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random(DateTime.Now.Millisecond);

            string function = FunctionTextBox.Text;
            double testStep = double.Parse(TestStepInputTextBox.Text.Replace(".", ","));

            ExtendedPoint point = new ExtendedPoint();
            point.X = random.Next(-10, 10);
            point.Y = random.Next(-10, 10);

            best = new BestSampleAlgorithm(function, testStep);
            best.QuantityVectrors = int.Parse(VectorsInputTextBox.Text);

            var result = best.StartSolution(point);
            OutPutXLabel.Text = best.EndPoint.X.ToString();
            OutPutYLabel.Text = best.EndPoint.Y.ToString();
            XinputLabel.Text = point.X.ToString();
            YinputLabel.Text = point.Y.ToString();
            ResultOutputLable.Text = result.ToString();
        }

        private void XinputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 45 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && SaveCheckBox.Checked)
            {
                ObjectSerializer<BestSampleAlgorithm> objSerializer = new ObjectSerializer<BestSampleAlgorithm>();
                objSerializer.SaveSerializedObject(best, SerializePathObject);
                e.Cancel = true;
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
                this.Dispose();
            }
        }

        private BestSampleAlgorithm GetObjectBestSampleAlgorithm()
        {
            BestSampleAlgorithm bestAlgorithm = new BestSampleAlgorithm();
            try
            {
                ObjectSerializer<BestSampleAlgorithm> objSerializer = new ObjectSerializer<BestSampleAlgorithm>();
                BestSampleAlgorithm yourObjectFromFile = objSerializer.GetSerializedObject(SerializePathObject);
                if (yourObjectFromFile != null)
                {
                    bestAlgorithm = yourObjectFromFile;
                }
                else
                {
                    bestAlgorithm = null;
                }
            }
            catch (Exception) { }
            return bestAlgorithm;
        }

        private void SetControlParams(BestSampleAlgorithm best)
        {
            FunctionTextBox.Text = best.Functioon;
            TestStepInputTextBox.Text = best.TestStep.ToString();
            VectorsInputTextBox.Text = best.QuantityVectrors.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
