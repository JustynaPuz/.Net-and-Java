namespace GUI
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
            label1 = new Label();
            ThreadstextBox = new TextBox();
            label2 = new Label();
            Seed1textBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            Mat1RowstextBox = new TextBox();
            Mat1ColtextBox = new TextBox();
            Mat2RowstextBox = new TextBox();
            Mat2ColtextBox = new TextBox();
            Matrix1Button = new Button();
            Matrix2Button = new Button();
            ResultButton = new Button();
            radioButtonThreads = new RadioButton();
            radioButtonParallel = new RadioButton();
            CalculateButton = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label9 = new Label();
            Seed2textBox = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(54, 77);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 0;
            label1.Text = "Threads";
            // 
            // ThreadstextBox
            // 
            ThreadstextBox.Location = new Point(190, 72);
            ThreadstextBox.Margin = new Padding(3, 4, 3, 4);
            ThreadstextBox.Name = "ThreadstextBox";
            ThreadstextBox.Size = new Size(114, 27);
            ThreadstextBox.TabIndex = 1;
            ThreadstextBox.TextChanged += ThreadstextBox_TextChanged;
            ThreadstextBox.KeyPress += ThreadstextBox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDark;
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(54, 131);
            label2.Name = "label2";
            label2.Size = new Size(71, 24);
            label2.TabIndex = 2;
            label2.Text = "Seed 1";
            // 
            // Seed1textBox
            // 
            Seed1textBox.Location = new Point(190, 125);
            Seed1textBox.Margin = new Padding(3, 4, 3, 4);
            Seed1textBox.Name = "Seed1textBox";
            Seed1textBox.Size = new Size(114, 27);
            Seed1textBox.TabIndex = 3;
            Seed1textBox.KeyPress += Seed1textBox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14F);
            label3.Location = new Point(54, 229);
            label3.Name = "label3";
            label3.Size = new Size(100, 29);
            label3.TabIndex = 4;
            label3.Text = "Matrix 1";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlDark;
            label4.Font = new Font("Tahoma", 12F);
            label4.Location = new Point(54, 289);
            label4.Name = "label4";
            label4.Size = new Size(57, 24);
            label4.TabIndex = 5;
            label4.Text = "Rows";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlDark;
            label5.Font = new Font("Tahoma", 12F);
            label5.Location = new Point(54, 335);
            label5.Name = "label5";
            label5.Size = new Size(86, 24);
            label5.TabIndex = 6;
            label5.Text = "Columns";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 14F);
            label6.Location = new Point(54, 403);
            label6.Name = "label6";
            label6.Size = new Size(100, 29);
            label6.TabIndex = 7;
            label6.Text = "Matrix 2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlDark;
            label7.Font = new Font("Tahoma", 12F);
            label7.Location = new Point(54, 456);
            label7.Name = "label7";
            label7.Size = new Size(57, 24);
            label7.TabIndex = 8;
            label7.Text = "Rows";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ControlDark;
            label8.Font = new Font("Tahoma", 12F);
            label8.Location = new Point(54, 504);
            label8.Name = "label8";
            label8.Size = new Size(86, 24);
            label8.TabIndex = 9;
            label8.Text = "Columns";
            // 
            // Mat1RowstextBox
            // 
            Mat1RowstextBox.Location = new Point(190, 284);
            Mat1RowstextBox.Margin = new Padding(3, 4, 3, 4);
            Mat1RowstextBox.Name = "Mat1RowstextBox";
            Mat1RowstextBox.Size = new Size(114, 27);
            Mat1RowstextBox.TabIndex = 10;
            Mat1RowstextBox.KeyPress += Mat1RowstextBox_KeyPress;
            // 
            // Mat1ColtextBox
            // 
            Mat1ColtextBox.Location = new Point(190, 329);
            Mat1ColtextBox.Margin = new Padding(3, 4, 3, 4);
            Mat1ColtextBox.Name = "Mat1ColtextBox";
            Mat1ColtextBox.Size = new Size(114, 27);
            Mat1ColtextBox.TabIndex = 11;
            Mat1ColtextBox.KeyPress += Mat1ColtextBox_KeyPress;
            // 
            // Mat2RowstextBox
            // 
            Mat2RowstextBox.Location = new Point(190, 451);
            Mat2RowstextBox.Margin = new Padding(3, 4, 3, 4);
            Mat2RowstextBox.Name = "Mat2RowstextBox";
            Mat2RowstextBox.Size = new Size(114, 27);
            Mat2RowstextBox.TabIndex = 12;
            Mat2RowstextBox.KeyPress += Mat2RowstextBox_KeyPress;
            // 
            // Mat2ColtextBox
            // 
            Mat2ColtextBox.Location = new Point(190, 499);
            Mat2ColtextBox.Margin = new Padding(3, 4, 3, 4);
            Mat2ColtextBox.Name = "Mat2ColtextBox";
            Mat2ColtextBox.Size = new Size(114, 27);
            Mat2ColtextBox.TabIndex = 13;
            Mat2ColtextBox.KeyPress += Mat2ColtextBox_KeyPress;
            // 
            // Matrix1Button
            // 
            Matrix1Button.BackColor = Color.White;
            Matrix1Button.Font = new Font("Tahoma", 12F);
            Matrix1Button.Location = new Point(421, 163);
            Matrix1Button.Margin = new Padding(3, 4, 3, 4);
            Matrix1Button.Name = "Matrix1Button";
            Matrix1Button.Size = new Size(135, 97);
            Matrix1Button.TabIndex = 14;
            Matrix1Button.Text = "Show matrix 1";
            Matrix1Button.UseVisualStyleBackColor = false;
            Matrix1Button.Click += Matrix1Button_Click;
            // 
            // Matrix2Button
            // 
            Matrix2Button.BackColor = Color.White;
            Matrix2Button.Font = new Font("Tahoma", 12F);
            Matrix2Button.Location = new Point(421, 289);
            Matrix2Button.Margin = new Padding(3, 4, 3, 4);
            Matrix2Button.Name = "Matrix2Button";
            Matrix2Button.Size = new Size(135, 97);
            Matrix2Button.TabIndex = 15;
            Matrix2Button.Text = "Show matrix 2";
            Matrix2Button.UseVisualStyleBackColor = false;
            Matrix2Button.Click += Matrix2Button_Click;
            // 
            // ResultButton
            // 
            ResultButton.BackColor = Color.White;
            ResultButton.Font = new Font("Tahoma", 12F);
            ResultButton.Location = new Point(421, 415);
            ResultButton.Margin = new Padding(3, 4, 3, 4);
            ResultButton.Name = "ResultButton";
            ResultButton.Size = new Size(135, 97);
            ResultButton.TabIndex = 16;
            ResultButton.Text = "Show result";
            ResultButton.UseVisualStyleBackColor = false;
            ResultButton.Click += ResultButton_Click;
            // 
            // radioButtonThreads
            // 
            radioButtonThreads.AutoSize = true;
            radioButtonThreads.Font = new Font("Tahoma", 12F);
            radioButtonThreads.Location = new Point(15, 25);
            radioButtonThreads.Margin = new Padding(3, 4, 3, 4);
            radioButtonThreads.Name = "radioButtonThreads";
            radioButtonThreads.Size = new Size(103, 28);
            radioButtonThreads.TabIndex = 17;
            radioButtonThreads.TabStop = true;
            radioButtonThreads.Text = "Threads";
            radioButtonThreads.UseVisualStyleBackColor = true;
            // 
            // radioButtonParallel
            // 
            radioButtonParallel.AutoSize = true;
            radioButtonParallel.Font = new Font("Tahoma", 12F);
            radioButtonParallel.Location = new Point(171, 25);
            radioButtonParallel.Margin = new Padding(3, 4, 3, 4);
            radioButtonParallel.Name = "radioButtonParallel";
            radioButtonParallel.Size = new Size(97, 28);
            radioButtonParallel.TabIndex = 18;
            radioButtonParallel.TabStop = true;
            radioButtonParallel.Text = "Parallel";
            radioButtonParallel.UseVisualStyleBackColor = true;
            radioButtonParallel.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // CalculateButton
            // 
            CalculateButton.BackColor = Color.White;
            CalculateButton.FlatStyle = FlatStyle.Flat;
            CalculateButton.Font = new Font("Tahoma", 12F);
            CalculateButton.Location = new Point(421, 36);
            CalculateButton.Margin = new Padding(3, 4, 3, 4);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(135, 97);
            CalculateButton.TabIndex = 19;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = false;
            CalculateButton.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(radioButtonParallel);
            groupBox1.Controls.Add(radioButtonThreads);
            groupBox1.Location = new Point(54, 556);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(274, 71);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Tahoma", 12F);
            button1.Location = new Point(421, 531);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(135, 97);
            button1.TabIndex = 21;
            button1.Text = "Comparison";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ControlDark;
            label9.Font = new Font("Tahoma", 12F);
            label9.Location = new Point(54, 183);
            label9.Name = "label9";
            label9.Size = new Size(71, 24);
            label9.TabIndex = 22;
            label9.Text = "Seed 2";
            // 
            // Seed2textBox
            // 
            Seed2textBox.Location = new Point(190, 177);
            Seed2textBox.Margin = new Padding(3, 4, 3, 4);
            Seed2textBox.Name = "Seed2textBox";
            Seed2textBox.Size = new Size(114, 27);
            Seed2textBox.TabIndex = 23;
            Seed2textBox.KeyPress += Seed2textBox_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 657);
            Controls.Add(Seed2textBox);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(CalculateButton);
            Controls.Add(ResultButton);
            Controls.Add(Matrix2Button);
            Controls.Add(Matrix1Button);
            Controls.Add(Mat2ColtextBox);
            Controls.Add(Mat2RowstextBox);
            Controls.Add(Mat1ColtextBox);
            Controls.Add(Mat1RowstextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Seed1textBox);
            Controls.Add(label2);
            Controls.Add(ThreadstextBox);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ThreadstextBox;
        private Label label2;
        private TextBox Seed1textBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox Mat1RowstextBox;
        private TextBox Mat1ColtextBox;
        private TextBox Mat2RowstextBox;
        private TextBox Mat2ColtextBox;
        private Button Matrix1Button;
        private Button Matrix2Button;
        private Button ResultButton;
        private RadioButton radioButtonThreads;
        private RadioButton radioButtonParallel;
        private Button CalculateButton;
        private GroupBox groupBox1;
        private Button button1;
        private Label label9;
        private TextBox Seed2textBox;
    }
}
