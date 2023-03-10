using System.Collections.Generic;
using System.Drawing;

namespace Laba2Capybara.Classes
{
    //Picture to draw
    internal class AllElementsForm : ElementsMovingETC
    {
        //List with elements to draw
        public List<Graphic> Elements { get; set; }

        //List with elements checks
        private readonly List<bool> elementChecks;

        //Standard construcor
        public AllElementsForm()
        {
            //Memory allocation
            Elements = new List<Graphic>();
            elementChecks = new List<bool>();

            //Add elements to list
            Elements.Add(new Rectangle("Тіло капібари", new PointF(100,100 ), new List<int> { 200, 400, 400, 200 }, new List<int> { 100, 100, 200, 200 }));
            Elements.Add(new Circle("Голова капібари", 300, new PointF(150, 90), 50));
            Elements.Add(new Rectangle("Передня лапа капібари", new PointF(200, 105), new List<int> { 210, 260, 260, 210 }, new List<int> { 200, 200, 250, 250 }));
            Elements.Add(new Rectangle("Задня лапа капібари", new PointF(200, 105), new List<int> {400, 350, 350, 400 }, new List<int> { 200, 200, 250, 250 }));
            Elements.Add(new Circle("Всевидяче око капібари", 100, new PointF(150, 70), 5));
            Elements.Add(new Rectangle("Мордочка капібари", new PointF(200, 105), new List<int> { 90,100, 100, 70 }, new List<int> { 70, 70, 100, 100 }));



            //Add checks to list
            for (int i = 0; i < Elements.Count; i++)
            {
                elementChecks.Add(false);
            }
        }

        //Method, that checks element (draw element or not)
        public void CheckElement(int index, bool value)
        {
            //Incorrect index
            if (index < 0)
            {
                return;
            }

            elementChecks[index] = value;
        }

        //Method, that draws all of the elements
        public void Draw(Graphics g) => Elements.ForEach(e => e.Draw(g));

        //Method, that moves checked elements
        public void MoveElement(int dx, int dy)
        {
            for (int i = 0; i < Elements.Count; i++)
            {
                if (elementChecks[i])
                {
                    Elements[i].MoveElement(dx, dy);
                }
            }
        }

        //Method, that scales checked elements by their center
        public void Scale(float scaleIndex)
        {
            for (int i = 0; i < Elements.Count; i++)
            {
                if (elementChecks[i])
                {
                    Elements[i].Scale(scaleIndex);
                }
            }
        }

        //Method, that rotates checked elements by their center
        public void RotateElement(double angle, PointF rotatePoint)
        {
            for (int i = 0; i < Elements.Count; i++)
            {
                if (elementChecks[i])
                {
                    Elements[i].RotateElement(angle, rotatePoint);
                }
            }
        }
    }
}
