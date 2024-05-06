namespace Pictures
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loadButton = new Button();
            processButton = new Button();
            negativePictureBox = new PictureBox();
            edgeDetectPictureBox = new PictureBox();
            tresholdingPictureBox = new PictureBox();
            grayPictureBox = new PictureBox();
            mainImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)negativePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edgeDetectPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tresholdingPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grayPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainImage).BeginInit();
            SuspendLayout();
            // 
            // loadButton
            // 
            loadButton.BackColor = SystemColors.ControlDarkDark;
            loadButton.FlatStyle = FlatStyle.Flat;
            loadButton.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            loadButton.ForeColor = SystemColors.ControlLightLight;
            loadButton.Location = new Point(585, 205);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(124, 79);
            loadButton.TabIndex = 0;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += loadButton_Click;
            // 
            // processButton
            // 
            processButton.BackColor = SystemColors.ControlDarkDark;
            processButton.FlatStyle = FlatStyle.Flat;
            processButton.Font = new Font("Trebuchet MS", 15.75F);
            processButton.ForeColor = SystemColors.ControlLightLight;
            processButton.Location = new Point(585, 325);
            processButton.Name = "processButton";
            processButton.Size = new Size(124, 79);
            processButton.TabIndex = 1;
            processButton.Text = "Process";
            processButton.UseVisualStyleBackColor = false;
            processButton.Click += processButton_Click;
            // 
            // negativePictureBox
            // 
            negativePictureBox.BackColor = SystemColors.ActiveCaptionText;
            negativePictureBox.BorderStyle = BorderStyle.FixedSingle;
            negativePictureBox.Location = new Point(1020, 99);
            negativePictureBox.Name = "negativePictureBox";
            negativePictureBox.Size = new Size(290, 234);
            negativePictureBox.TabIndex = 3;
            negativePictureBox.TabStop = false;
            // 
            // edgeDetectPictureBox
            // 
            edgeDetectPictureBox.BackColor = SystemColors.ActiveCaptionText;
            edgeDetectPictureBox.BorderStyle = BorderStyle.FixedSingle;
            edgeDetectPictureBox.Location = new Point(724, 99);
            edgeDetectPictureBox.Name = "edgeDetectPictureBox";
            edgeDetectPictureBox.Size = new Size(290, 234);
            edgeDetectPictureBox.TabIndex = 4;
            edgeDetectPictureBox.TabStop = false;
            // 
            // tresholdingPictureBox
            // 
            tresholdingPictureBox.BackColor = SystemColors.ActiveCaptionText;
            tresholdingPictureBox.BorderStyle = BorderStyle.FixedSingle;
            tresholdingPictureBox.Location = new Point(1020, 355);
            tresholdingPictureBox.Name = "tresholdingPictureBox";
            tresholdingPictureBox.Size = new Size(290, 234);
            tresholdingPictureBox.TabIndex = 5;
            tresholdingPictureBox.TabStop = false;
            // 
            // grayPictureBox
            // 
            grayPictureBox.BackColor = SystemColors.ActiveCaptionText;
            grayPictureBox.BorderStyle = BorderStyle.FixedSingle;
            grayPictureBox.Location = new Point(724, 355);
            grayPictureBox.Name = "grayPictureBox";
            grayPictureBox.Size = new Size(290, 234);
            grayPictureBox.TabIndex = 6;
            grayPictureBox.TabStop = false;
            // 
            // mainImage
            // 
            mainImage.BackColor = SystemColors.ActiveCaptionText;
            mainImage.BorderStyle = BorderStyle.FixedSingle;
            mainImage.Location = new Point(53, 99);
            mainImage.Name = "mainImage";
            mainImage.Size = new Size(514, 490);
            mainImage.TabIndex = 2;
            mainImage.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 667);
            Controls.Add(mainImage);
            Controls.Add(grayPictureBox);
            Controls.Add(tresholdingPictureBox);
            Controls.Add(edgeDetectPictureBox);
            Controls.Add(negativePictureBox);
            Controls.Add(processButton);
            Controls.Add(loadButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)negativePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)edgeDetectPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)tresholdingPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)grayPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button loadButton;
        private Button processButton;
        private PictureBox negativePictureBox;
        private PictureBox edgeDetectPictureBox;
        private PictureBox tresholdingPictureBox;
        private PictureBox grayPictureBox;
        private PictureBox mainImage;
    }
}
