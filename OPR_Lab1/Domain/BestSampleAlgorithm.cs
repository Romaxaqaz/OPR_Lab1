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
        private int countVectrors = 5;
        private int quantitativeSolutionsSteps = 20;
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

        public BestSampleAlgorithm(string function, double testSstep)
        {
            this.function = function;
            this.testStep = testSstep;
        }

        /// <summary>
        /// Generate vectors in starting point
        /// </summary>
        /// <param name="step"></param>
        /// <param name="point"></param>
        private IList<ExtendedPoint> GenerateVectors(double step, ExtendedPoint point)
        {
            var resultList = new List<ExtendedPoint>();
            Random random = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < countVectrors; i++)
            {
<<<<<<< HEAD
                double randomAngle = random.NextDouble() + random.Next(-3, 3);
                var x = point.X + (step * Math.Cos(randomAngle));
                var y = point.Y + (step * Math.Sin(randomAngle));

                resultList.Add(new ExtendedPoint(x, y, ResultFunction(x, y), randomAngle));
=======
                Random random = new Random(DateTime.Now.Millisecond);
                double randomAngle = random.Next(0, 360);
                var X = point.X + (step * Math.Sin(randomAngle));
                var Y = point.Y + (step * Math.Cos(randomAngle));
                //save x,y,result function and angle for work step
                PointList.Add(new ExtendedPoint(
                    X,
                    Y,
                    ResultFunction(X, Y),
                    randomAngle
                    ));
>>>>>>> origin/master
            }

            return resultList;
        }

        /// <summary>
        /// We do work step
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        private ExtendedPoint MakeWorkStep(ExtendedPoint point, ExtendedPoint bestDot)
        {
            if (workStep == 0) workStep = testStep * 2;
            var x = point.X + (workStep * Math.Cos(bestDot.Angle));
            var y = point.Y + (workStep * Math.Sin(bestDot.Angle));
            point.X = x;
            point.Y = y;
            point.ValueFunction = ResultFunction(point.X, point.Y);
            return point;
        }

        /// <summary>
        /// Start solution
        /// </summary>
        /// <returns> Result solution</returns>
        public double StartSolution(ExtendedPoint point)
        {
            int count = 0;
            var actualTestStep = testStep;
            point.ValueFunction = ResultFunction(point.X, point.Y);
            try
            {
<<<<<<< HEAD
                do
=======
                try
                {
                    //generate vectrors
                    GenerateVectors(testStep, Point);
                    //search min value function
                    var bestDot = PointList.Find(x => x.ValueFunction == PointList.Min(y => y.ValueFunction));
                    //working step in the direction of point
                    Point = StartWorkStep(bestDot);
                    result = Point.ValueFunction;
                    PointList.Clear();
                    count++;
                }
                catch (Bestcode.MathParser.ParserException)
>>>>>>> origin/master
                {
                    var vectors = GenerateVectors(actualTestStep, point);
                    var bestDot = vectors.Where(x => x.ValueFunction == vectors.Min(y => y.ValueFunction)).First();
                    if (bestDot.ValueFunction > point.ValueFunction)
                    {
                        actualTestStep = actualTestStep / 2;
                    }
                    else
                    {
                        point = MakeWorkStep(point, bestDot);
                        count++;
                    }
                }
                while (actualTestStep > 0.001);
            }
            catch (Bestcode.MathParser.ParserException)
            {
                MessageBox.Show("Incorrect input function");
            }

            EndPoint = point;
            return point.ValueFunction;
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
            return parser.ValueAsDouble;
        }
    }
}
