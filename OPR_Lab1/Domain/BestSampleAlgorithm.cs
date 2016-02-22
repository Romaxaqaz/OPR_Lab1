using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bestcode.MathParser;
using System.Windows.Forms;
using System.Drawing;

namespace OPR_Lab1.Domain
{
    [Serializable]
    public class BestSampleAlgorithm
    {
        private ExtendedPoint Point;

        #region private variables
        private string function = string.Empty;
        private double testStep = 1;
        private double workStep = 0;
        private double result = 0;
        private int countVectrors = 5;
        private int quantitativeSolutionsSteps = 3;
        #endregion

        /// <summary>
        /// End Point params
        /// </summary>
        public ExtendedPoint EndPoint { get { return Point; } set { Point = value; } }
        /// <summary>
        /// Function string
        /// </summary>
        public string Functioon { get { return function; } set { function = value; } }
        /// <summary>
        /// Test step. Default = 1;
        /// </summary>
        public double TestStep { get { return testStep; } set { testStep = value; } }
        /// <summary>
        /// Work step. Default = TestStep * 2;
        /// </summary>
        public double WorkStep { get { return workStep; } set { workStep = value; } }
        /// <summary>
        /// Quantity vectors. Default = 5;
        /// </summary>
        public int QuantityVectrors { get { return countVectrors; } set { countVectrors = value; } }
        /// <summary>
        /// Quantitative Solutions Steps. Default = 3;
        /// </summary>
        public int QuantitativeSolutionsSteps { get { return quantitativeSolutionsSteps; } set { quantitativeSolutionsSteps = value; } }
        /// <summary>
        /// Extented point list
        /// </summary>
        public List<ExtendedPoint> PointList = new List<ExtendedPoint>();

        /// <summary>
        /// initialization parameters
        /// </summary>
        /// <param name="function">Function</param>
        /// <param name="startPoint">Start X and Y </param>
        /// <param name="testSstep">Test step. Default==2</param>

        public BestSampleAlgorithm() { }

        public BestSampleAlgorithm(string function, Point startPoint, double testSstep)
        {
            Point.X = startPoint.Y;
            Point.Y = startPoint.Y;
            this.function = function;
            this.testStep = testSstep;
        }

        /// <summary>
        /// Generate vectors in starting point
        /// </summary>
        /// <param name="step"></param>
        /// <param name="point"></param>
        private void GenerateVectors(double step, ExtendedPoint point)
        {
            for (int i = 0; i < countVectrors; i++)
            {
                Random random = new Random(DateTime.Now.Millisecond);
                double randomAngle = random.Next(0, 360);
                var X = point.X + (step * Math.Sin(randomAngle));
                var Y = point.Y + (step * Math.Cos(randomAngle));

                PointList.Add(new ExtendedPoint(
                    X,
                    Y,
                    ResultFunction(X, Y),
                    randomAngle
                    ));
            }
        }

        /// <summary>
        /// We do work step
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        private ExtendedPoint StartWorkStep(ExtendedPoint point)
        {
            if (workStep == 0) workStep = testStep * 2;
            var X = point.X + (workStep * Math.Sin(point.Angle));
            var Y = point.Y + (workStep * Math.Cos(point.Angle));
            point.X = X;
            point.Y = Y;
            return point;
        }

        /// <summary>
        /// Start solution
        /// </summary>
        /// <returns> Result solution</returns>
        public double StartSolution()
        {
            int count = 0;
            do
            {
                try
                {
                    GenerateVectors(testStep, Point);
                    var bestDot = PointList.Find(x => x.ValueFunction == PointList.Min(y => y.ValueFunction));
                    Point = StartWorkStep(bestDot);
                    result = Point.ValueFunction;
                    PointList.Clear();
                    count++;
                }
                catch (Bestcode.MathParser.ParserException)
                {
                    MessageBox.Show("Incorrect input function");
                    break;
                }
            }
            while (count < quantitativeSolutionsSteps);
            return result;
        }

        /// <summary>
        /// Аunction solution method
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private double ResultFunction(double x, double y)
        {
            MathParser parser = new MathParser();
            parser.Expression = function;
            parser.X = x;
            parser.Y = y;
            return parser.ValueAsDouble; ;
        }
    }
}
