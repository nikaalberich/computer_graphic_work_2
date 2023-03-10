using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Laba2Capybara
{
    //Rectangle element
    internal class Rectangle : Graphic
    {
        //Parametric constructor
        public Rectangle(string name, PointF centerPoint, List<int> xPoints, List<int> yPoints) : base(name, centerPoint)
        {   
            
            
            //Add rectangle points to list
            for (int i = 0; i < xPoints.Count; i++)
            {
                _points.Add(new Point(xPoints[i], yPoints[i]));         
            }

            //Add first point one more time, for correct draw of element
            _points.Add(new Point(xPoints[0], yPoints[0]));
        }
    }
}
