using System;
using System.Collections.Generic;
using System.Drawing;

namespace Laba2Capybara
{
    //Graphic element
    internal class Graphic : ElementsMovingETC
    {
        //Element name
        public string Name { get; set; }

        //Center point of element
        private PointF centerPoint;

        //Element points
        public List<PointF> _points;

        //Parametric constrcutor
        public Graphic(string name, PointF centerPoint)
        {
            //Set class values
            Name = name;
            this.centerPoint = centerPoint;

            //Memory allocation
            _points = new List<PointF>();
        }

        //Method, that draws element
        public void Draw(Graphics g) => g.DrawLines(Pens.Black, _points.ToArray());


        // Координаты центральной точки элемента (хранятся в переменных centerPoint.X и centerPoint.Y) изменяются на значение смещения по осям X и Y.
        // Координаты остальных точек элемента изменяются на те же значения смещения по осям X и Y.
        public void MoveElement(int dx, int dy)
        {
            //MoveElement center point of element
            centerPoint.X += dx;
            centerPoint.Y += dy;

            //MoveElement another points of element
            for (int i = 0; i < _points.Count; i++)
            {
                PointF point = _points[i];
                point.X += dx;
                point.Y += dy;
                _points[i] = point;
            }
        }

        // Находит новую центральную точку элемента, умножая координаты текущей центральной точки на значение масштаба.
        // Вычисляет разницу между старой и новой центральной точками, сохраняя ее в переменных dx и dy.
        // Устанавливает новую центральную точку элемента с помощью формулы, использующей новое значение масштаба и сохраненные значения dx и dy.
        // Изменяет координаты всех точек элемента, используя ту же формулу, что и для центральной точки.
       
        public void Scale(float scaleIndex)
        {
            //New center of element
            float newCentralFigurePointX = centerPoint.X * scaleIndex;
            float newCentralFigurePointY = centerPoint.Y * scaleIndex;

            //Position difference between old and new center point
            float dx = centerPoint.X - newCentralFigurePointX;
            float dy = centerPoint.Y - newCentralFigurePointY;

            //Set new center to element
            centerPoint.X = centerPoint.X * scaleIndex + dx;
            centerPoint.Y = centerPoint.Y * scaleIndex + dy;

            //Set new points positions
            for (int i = 0; i < _points.Count; i++)
            {
                PointF point = _points[i];
                point.X = point.X * scaleIndex + dx;
                point.Y = point.Y * scaleIndex + dy;
                _points[i] = point;
            }
        }

        // Угол поворота преобразуется в радианы, чтобы использовать функции тригонометрии, которые работают с радианами.
        // Центральная точка элемента сохраняется в переменных currentX и currentY.
        // Новые координаты центральной точки вычисляются с помощью формулы поворота, использующей новый угол и точку поворота.
        // Координаты остальных точек элемента изменяются с помощью той же формулы, что и для центральной точки.

        public void RotateElement(double angle, PointF rotatePoint)
        {
            //Converting angle to radian
            angle = angle * Math.PI / 180;

            //RotateElement center point of element
            float currentX = centerPoint.X;
            float currentY = centerPoint.Y;

            centerPoint.X = (float)(rotatePoint.X + (currentX - rotatePoint.X) * Math.Cos(angle) - (currentY - rotatePoint.Y) * Math.Sin(angle));
            centerPoint.Y = (float)(rotatePoint.Y + (currentX - rotatePoint.X) * Math.Sin(angle) + (currentY - rotatePoint.Y) * Math.Cos(angle));

            //RotateElement another points of element
            for (int i = 0; i < _points.Count; i++)
            {
                currentX = _points[i].X;
                currentY = _points[i].Y;

                PointF point = _points[i];
                point.X = (float)(rotatePoint.X + (currentX - rotatePoint.X) * Math.Cos(angle) - (currentY - rotatePoint.Y) * Math.Sin(angle));
                point.Y = (float)(rotatePoint.Y + (currentX - rotatePoint.X) * Math.Sin(angle) + (currentY - rotatePoint.Y) * Math.Cos(angle));
                _points[i] = point;
            }
        }
    }
}
