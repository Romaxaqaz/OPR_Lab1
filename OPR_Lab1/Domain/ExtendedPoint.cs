using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPR_Lab1.Domain
{
    public struct ExtendedPoint
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Angle { get; set; }
        public double ValueFunction { get; set; }

        /// <summary>
        /// Initialization params ExtendedPoint
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="valueFunction"></param>
        /// <param name="angle"></param>
        public ExtendedPoint(double x, double y, double valueFunction, double angle)
        {
            this.X = x;
            this.Y = y;
            this.ValueFunction = valueFunction;
            this.Angle = angle;
        }
    }
}
