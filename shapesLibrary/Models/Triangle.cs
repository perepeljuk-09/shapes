using shapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes.Models
{
    public class Triangle : IShape
    {
        private readonly int _firstSide;
        private readonly int _secondSide;
        private readonly int _fhirdSide;
        public Triangle(int firstSide, int secondSide, int thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
                throw new Exception("don't be 0 or less");

            _firstSide = firstSide;
            _secondSide = secondSide;
            _fhirdSide = thirdSide;
        }
        public float GetSquare()
        {
            float halfPerimetr = (float)(_firstSide + _secondSide + _fhirdSide) / 2;

            float square = (float)Math.Sqrt(halfPerimetr * (halfPerimetr - _firstSide) * (halfPerimetr - _secondSide) * (halfPerimetr - _fhirdSide));

            return square;
        }

        public bool CheckIsRectangular()
        {
            (int gip, int firstkat, int secondkat) sides = GetGipotenuzeAndKatets();

            bool result = Math.Pow(sides.gip, 2) == Math.Pow(sides.firstkat, 2) + Math.Pow(sides.secondkat, 2);
            return result;
        }

        private (int, int, int) GetGipotenuzeAndKatets()
        {
            List<int> arr = new List<int> { _firstSide, _secondSide, _fhirdSide };
            int max = arr.Max();

            int gip = arr.Find(x => x == max);
            arr.Remove(max);

            return (gip, arr[0], arr[1]);
        }
    }
}
