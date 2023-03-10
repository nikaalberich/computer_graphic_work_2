using System;
using System.Collections.Generic;
using System.Drawing;

namespace Laba2Capybara
{
    //Triangle element
    internal class Triangle : Graphic
    {
        //Parametric constructor
        public Triangle(string name, PointF point1, PointF point2, PointF point3) : base(name, GetCenterPoint(point1, point2, point3))
        {
            //Add triangle points to list
            _points.Add(point1);
            _points.Add(point2);
            _points.Add(point3);
        }

        //Private method to calculate the center point of the triangle
        private static PointF GetCenterPoint(PointF point1, PointF point2, PointF point3)
        {
            float centerX = (point1.X + point2.X + point3.X) / 3;
            float centerY = (point1.Y + point2.Y + point3.Y) / 3;

            return new PointF(centerX, centerY);
        }
    }
}
