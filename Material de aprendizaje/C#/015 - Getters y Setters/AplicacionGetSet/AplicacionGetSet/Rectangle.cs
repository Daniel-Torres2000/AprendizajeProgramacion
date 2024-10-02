using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionGetSet
{
    class Rectangle
    {
        private double length, width;
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if(value > 0.0)
                {
                    length = value;
                }
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0.0)
                {
                    width = value;
                }
            }
        }
        public double ObtenerArea()
        {
            return width * length;
        }
    }
}
