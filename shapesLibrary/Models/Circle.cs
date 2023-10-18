using shapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes.Models
{
    public class Circle : IShape
    {
        private readonly int _radius;
        public Circle(int radius)
        {
            if (radius <= 0)
                throw new Exception("don't be 0 or less");

            _radius = radius;
        }
        public float GetSquare()
        {
            float square = (float)(Math.PI * (Math.Pow(_radius, 2)));

            return square;
        }
    }
}
