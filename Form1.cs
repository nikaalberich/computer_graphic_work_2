using Laba2Capybara.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        //RotateElement point coordinates
        private int _cx;
        private int _cy;

        //MoveElement indexes
        private int moveLeftIndex;
        private int moveRightIndex;

        //RotateElement index
        private int rotateIndex;

        //Scale indexes
        private float scaleIncreaseIndex;
        private float scaleDecreaseIndex;

        //Picture to draw
        private readonly AllElementsForm _picture;

        //Standart constructor
        public Form1()
        {
            InitializeComponent();

            //Memory allocation
            _picture = new AllElementsForm();

            //Output elements to checked list box
            _picture.Elements.ForEach(e => checkedListBoxWithElements.Items.Add(e.Name));

            //MoveElement indexes assignments
            moveLeftIndex = trackBarMoveLeft.Value;
            moveRightIndex = trackBarMoveRight.Value;

            //Scale indexes asssignments
            scaleIncreaseIndex = (float)(trackBarIncrease.Value / 10.0);
            scaleDecreaseIndex = (float)(trackBarDecrease.Value / 10.0);

            //RotateElement index assignment
            rotateIndex = trackBarRotate.Value;
        }

        //Paint action for picture box
        private void PictureBoxWithPicture_Paint(object sender, PaintEventArgs e)
        {
            //Draw picture
            _picture.Draw(e.Graphics);

            //Draw rotate point
            e.Graphics.DrawEllipse(Pens.Red, _cx, _cy, 4, 4);
        }

        //Mouse click action for picture box 
        private void PictureBoxWithPicture_MouseClick(object sender, MouseEventArgs e)
        {
            //Change coordinates of rotate point
            _cx = e.X;
            _cy = e.Y;

            //Update picture
            pictureBoxWithPicture.Refresh();
        }

        //Item check action for checked list box                                                   
        private void CheckedListBoxWithElements_ItemCheck(object sender, ItemCheckEventArgs e) => _picture.CheckElement(e.Index, e.NewValue == CheckState.Checked);

        //Click action for button move left 
        private void ButtonMoveLeft_Click(object sender, EventArgs e)
        {
            //If axis X checked - move for X
            //If axis Y checked - move for Y
            //If axis X and Y checked - move for X and Y
            _picture.MoveElement(checkBoxAxisX.Checked ? -moveLeftIndex : 0, checkBoxAxisY.Checked ? -moveLeftIndex : 0);

            //Update picture
            pictureBoxWithPicture.Refresh();
        }

        //Click action for button move right 
        private void ButtonMoveRight_Click(object sender, EventArgs e)
        {
            //If axis X checked - move for X
            //If axis Y checked - move for Y
            //If axis X and Y checked - move for X and Y
            _picture.MoveElement(checkBoxAxisX.Checked ? moveRightIndex : 0, checkBoxAxisY.Checked ? moveRightIndex : 0);

            //Update picture
            pictureBoxWithPicture.Refresh();
        }

        //Click action for button increase size
        private void ButtonIncreaseSize_Click(object sender, EventArgs e)
        {
            //Scale element by 1.5 times
            _picture.Scale(scaleIncreaseIndex);

            //Update picture
            pictureBoxWithPicture.Refresh();
        }

        //Click action for button decrease size
        private void ButtonDecreaseSize_Click(object sender, EventArgs e)
        {
            //Scale element by 0.5 times
            _picture.Scale(scaleDecreaseIndex);

            //Update picture
            pictureBoxWithPicture.Refresh();
        }

        //Click action for button rotate
        private void ButtonRotate_Click(object sender, EventArgs e)
        {
            //RotateElement element by rotateIndex * 30 rad
            _picture.RotateElement(rotateIndex * 30, new PointF(_cx, _cy));

            //Update picture
            pictureBoxWithPicture.Refresh();
        }

        //Scroll action for track bar move left                             
        private void TrackBarMoveLeft_Scroll(object sender, EventArgs e) => moveLeftIndex = trackBarMoveLeft.Value;

        //Scroll action for track bar move right                            
        private void TrackBarMoveRight_Scroll(object sender, EventArgs e) => moveRightIndex = trackBarMoveRight.Value;

        //Scroll action for track bar rotate                              
        private void TrackBarRotate_Scroll(object sender, EventArgs e) => rotateIndex = trackBarRotate.Value;

        //Scrool action for track bar increase                        
        private void TrackBarIncrease_Scroll(object sender, EventArgs e) => scaleIncreaseIndex = (float)(trackBarIncrease.Value / 10.0);

        //Scrool action for track bar decrease                             
        private void TrackBarDecrease_Scroll(object sender, EventArgs e) => scaleDecreaseIndex = (float)(trackBarDecrease.Value / 10.0);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxWithPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
