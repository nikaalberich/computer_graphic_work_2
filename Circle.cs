using System;
using System.Drawing;

namespace Laba2Capybara
{
    //Circle element
    internal class Circle : Graphic
    {
        //Parametric constructor
        public Circle(string name, int pointsAmount, PointF centerPoint, int rad) : base(name, centerPoint)
        {
            //Add circle points to list
            for (int i = 0; i < pointsAmount; i++)
            {
                float x = centerPoint.X + (float)(rad * Math.Cos(2 * Math.PI / 100 * i));
                float y = centerPoint.Y + (float)(rad * Math.Sin(2 * Math.PI / 100 * i));

                _points.Add(new PointF(x, y));
            }
        }
    }
}
