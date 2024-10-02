using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionParametros
{
    class Rectangle
    {
        private double length, width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        public double ObtenArea()
        {
            return length * width;
        }
    }
}
