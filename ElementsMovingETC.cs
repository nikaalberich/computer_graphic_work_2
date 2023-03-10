using System.Drawing;

namespace Laba2Capybara
{
    //Interface with operations move and draw element
    internal interface ElementsMovingETC
    {
        //MoveElement element
        void MoveElement(int dx, int dy);

        //Draw element
        void Draw(Graphics g);

        //Scale element by his center
        void Scale(float scaleIndex);

        //RotateElement element by rotate point
        void RotateElement(double angle, PointF rotatePoint);
    }
}
