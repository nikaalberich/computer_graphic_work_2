namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxWithPicture = new System.Windows.Forms.PictureBox();
            this.checkedListBoxWithElements = new System.Windows.Forms.CheckedListBox();
            this.buttonMoveLeft = new System.Windows.Forms.Button();
            this.checkBoxAxisX = new System.Windows.Forms.CheckBox();
            this.checkBoxAxisY = new System.Windows.Forms.CheckBox();
            this.buttonMoveRight = new System.Windows.Forms.Button();
            this.buttonIncreaseSize = new System.Windows.Forms.Button();
            this.buttonDecreaseSize = new System.Windows.Forms.Button();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.trackBarMoveLeft = new System.Windows.Forms.TrackBar();
            this.trackBarMoveRight = new System.Windows.Forms.TrackBar();
            this.trackBarRotate = new System.Windows.Forms.TrackBar();
            this.trackBarIncrease = new System.Windows.Forms.TrackBar();
            this.trackBarDecrease = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWithPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMoveLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMoveRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIncrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDecrease)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxWithPicture
            // 
            this.pictureBoxWithPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxWithPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pictureBoxWithPicture.Location = new System.Drawing.Point(13, 12);
            this.pictureBoxWithPicture.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxWithPicture.Name = "pictureBoxWithPicture";
            this.pictureBoxWithPicture.Size = new System.Drawing.Size(587, 534);
            this.pictureBoxWithPicture.TabIndex = 0;
            this.pictureBoxWithPicture.TabStop = false;
            this.pictureBoxWithPicture.Click += new System.EventHandler(this.pictureBoxWithPicture_Click);
            this.pictureBoxWithPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxWithPicture_Paint);
            this.pictureBoxWithPicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxWithPicture_MouseClick);
            // 
            // checkedListBoxWithElements
            // 
            this.checkedListBoxWithElements.BackColor = System.Drawing.SystemColors.Info;
            this.checkedListBoxWithElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkedListBoxWithElements.FormattingEnabled = true;
            this.checkedListBoxWithElements.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkedListBoxWithElements.Location = new System.Drawing.Point(608, 13);
            this.checkedListBoxWithElements.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBoxWithElements.Name = "checkedListBoxWithElements";
            this.checkedListBoxWithElements.Size = new System.Drawing.Size(403, 112);
            this.checkedListBoxWithElements.TabIndex = 1;
            this.checkedListBoxWithElements.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBoxWithElements_ItemCheck);
            // 
            // buttonMoveLeft
            // 
            this.buttonMoveLeft.BackColor = System.Drawing.Color.Yellow;
            this.buttonMoveLeft.Location = new System.Drawing.Point(608, 177);
            this.buttonMoveLeft.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMoveLeft.Name = "buttonMoveLeft";
            this.buttonMoveLeft.Size = new System.Drawing.Size(207, 37);
            this.buttonMoveLeft.TabIndex = 2;
            this.buttonMoveLeft.Text = "Перемістити ліворуч";
            this.buttonMoveLeft.UseVisualStyleBackColor = false;
            this.buttonMoveLeft.Click += new System.EventHandler(this.ButtonMoveLeft_Click);
            // 
            // checkBoxAxisX
            // 
            this.checkBoxAxisX.AutoSize = true;
            this.checkBoxAxisX.Location = new System.Drawing.Point(1038, 22);
            this.checkBoxAxisX.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAxisX.Name = "checkBoxAxisX";
            this.checkBoxAxisX.Size = new System.Drawing.Size(127, 20);
            this.checkBoxAxisX.TabIndex = 3;
            this.checkBoxAxisX.Text = "По осі абцис (х)";
            this.checkBoxAxisX.UseVisualStyleBackColor = true;
            // 
            // checkBoxAxisY
            // 
            this.checkBoxAxisY.AutoSize = true;
            this.checkBoxAxisY.Location = new System.Drawing.Point(1038, 59);
            this.checkBoxAxisY.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAxisY.Name = "checkBoxAxisY";
            this.checkBoxAxisY.Size = new System.Drawing.Size(145, 20);
            this.checkBoxAxisY.TabIndex = 4;
            this.checkBoxAxisY.Text = "По осі ординат (у)";
            this.checkBoxAxisY.UseVisualStyleBackColor = true;
            // 
            // buttonMoveRight
            // 
            this.buttonMoveRight.BackColor = System.Drawing.Color.Cyan;
            this.buttonMoveRight.Location = new System.Drawing.Point(608, 132);
            this.buttonMoveRight.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMoveRight.Name = "buttonMoveRight";
            this.buttonMoveRight.Size = new System.Drawing.Size(207, 37);
            this.buttonMoveRight.TabIndex = 5;
            this.buttonMoveRight.Text = "Перемістити праворуч";
            this.buttonMoveRight.UseVisualStyleBackColor = false;
            this.buttonMoveRight.Click += new System.EventHandler(this.ButtonMoveRight_Click);
            // 
            // buttonIncreaseSize
            // 
            this.buttonIncreaseSize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonIncreaseSize.Location = new System.Drawing.Point(608, 222);
            this.buttonIncreaseSize.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIncreaseSize.Name = "buttonIncreaseSize";
            this.buttonIncreaseSize.Size = new System.Drawing.Size(207, 37);
            this.buttonIncreaseSize.TabIndex = 6;
            this.buttonIncreaseSize.Text = "Збільшити розмір обраної(х) фігури\r\n";
            this.buttonIncreaseSize.UseVisualStyleBackColor = false;
            this.buttonIncreaseSize.Click += new System.EventHandler(this.ButtonIncreaseSize_Click);
            // 
            // buttonDecreaseSize
            // 
            this.buttonDecreaseSize.BackColor = System.Drawing.Color.Red;
            this.buttonDecreaseSize.Location = new System.Drawing.Point(608, 267);
            this.buttonDecreaseSize.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDecreaseSize.Name = "buttonDecreaseSize";
            this.buttonDecreaseSize.Size = new System.Drawing.Size(207, 37);
            this.buttonDecreaseSize.TabIndex = 7;
            this.buttonDecreaseSize.Text = "Зменшити розмір";
            this.buttonDecreaseSize.UseVisualStyleBackColor = false;
            this.buttonDecreaseSize.Click += new System.EventHandler(this.ButtonDecreaseSize_Click);
            // 
            // buttonRotate
            // 
            this.buttonRotate.BackColor = System.Drawing.Color.Gray;
            this.buttonRotate.Location = new System.Drawing.Point(608, 312);
            this.buttonRotate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(207, 37);
            this.buttonRotate.TabIndex = 8;
            this.buttonRotate.Text = "Покрутити туди-сюди";
            this.buttonRotate.UseVisualStyleBackColor = false;
            this.buttonRotate.Click += new System.EventHandler(this.ButtonRotate_Click);
            // 
            // trackBarMoveLeft
            // 
            this.trackBarMoveLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarMoveLeft.Location = new System.Drawing.Point(823, 132);
            this.trackBarMoveLeft.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarMoveLeft.Minimum = 1;
            this.trackBarMoveLeft.Name = "trackBarMoveLeft";
            this.trackBarMoveLeft.Size = new System.Drawing.Size(188, 56);
            this.trackBarMoveLeft.TabIndex = 9;
            this.trackBarMoveLeft.Value = 1;
            this.trackBarMoveLeft.Scroll += new System.EventHandler(this.TrackBarMoveLeft_Scroll);
            // 
            // trackBarMoveRight
            // 
            this.trackBarMoveRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarMoveRight.Location = new System.Drawing.Point(823, 177);
            this.trackBarMoveRight.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarMoveRight.Minimum = 1;
            this.trackBarMoveRight.Name = "trackBarMoveRight";
            this.trackBarMoveRight.Size = new System.Drawing.Size(188, 56);
            this.trackBarMoveRight.TabIndex = 10;
            this.trackBarMoveRight.Value = 1;
            this.trackBarMoveRight.Scroll += new System.EventHandler(this.TrackBarMoveRight_Scroll);
            // 
            // trackBarRotate
            // 
            this.trackBarRotate.Location = new System.Drawing.Point(823, 322);
            this.trackBarRotate.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarRotate.Maximum = 4;
            this.trackBarRotate.Minimum = 1;
            this.trackBarRotate.Name = "trackBarRotate";
            this.trackBarRotate.Size = new System.Drawing.Size(188, 56);
            this.trackBarRotate.TabIndex = 13;
            this.trackBarRotate.Value = 1;
            this.trackBarRotate.Scroll += new System.EventHandler(this.TrackBarRotate_Scroll);
            // 
            // trackBarIncrease
            // 
            this.trackBarIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarIncrease.Location = new System.Drawing.Point(823, 222);
            this.trackBarIncrease.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarIncrease.Maximum = 20;
            this.trackBarIncrease.Minimum = 12;
            this.trackBarIncrease.Name = "trackBarIncrease";
            this.trackBarIncrease.Size = new System.Drawing.Size(188, 56);
            this.trackBarIncrease.TabIndex = 14;
            this.trackBarIncrease.Value = 12;
            this.trackBarIncrease.Scroll += new System.EventHandler(this.TrackBarIncrease_Scroll);
            // 
            // trackBarDecrease
            // 
            this.trackBarDecrease.Location = new System.Drawing.Point(823, 267);
            this.trackBarDecrease.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarDecrease.Maximum = 9;
            this.trackBarDecrease.Minimum = 5;
            this.trackBarDecrease.Name = "trackBarDecrease";
            this.trackBarDecrease.Size = new System.Drawing.Size(188, 56);
            this.trackBarDecrease.TabIndex = 15;
            this.trackBarDecrease.Value = 5;
            this.trackBarDecrease.Scroll += new System.EventHandler(this.TrackBarDecrease_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1195, 559);
            this.Controls.Add(this.trackBarDecrease);
            this.Controls.Add(this.trackBarIncrease);
            this.Controls.Add(this.trackBarRotate);
            this.Controls.Add(this.trackBarMoveRight);
            this.Controls.Add(this.trackBarMoveLeft);
            this.Controls.Add(this.buttonRotate);
            this.Controls.Add(this.buttonDecreaseSize);
            this.Controls.Add(this.buttonIncreaseSize);
            this.Controls.Add(this.buttonMoveRight);
            this.Controls.Add(this.checkBoxAxisY);
            this.Controls.Add(this.checkBoxAxisX);
            this.Controls.Add(this.buttonMoveLeft);
            this.Controls.Add(this.checkedListBoxWithElements);
            this.Controls.Add(this.pictureBoxWithPicture);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Капібара рухається онлайн без смс та реєстрації";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWithPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMoveLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMoveRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIncrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDecrease)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxWithPicture;
        private System.Windows.Forms.CheckedListBox checkedListBoxWithElements;
        private System.Windows.Forms.Button buttonMoveLeft;
        private System.Windows.Forms.CheckBox checkBoxAxisX;
        private System.Windows.Forms.CheckBox checkBoxAxisY;
        private System.Windows.Forms.Button buttonMoveRight;
        private System.Windows.Forms.Button buttonIncreaseSize;
        private System.Windows.Forms.Button buttonDecreaseSize;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.TrackBar trackBarMoveLeft;
        private System.Windows.Forms.TrackBar trackBarMoveRight;
        private System.Windows.Forms.TrackBar trackBarRotate;
        private System.Windows.Forms.TrackBar trackBarIncrease;
        private System.Windows.Forms.TrackBar trackBarDecrease;
    }
}

