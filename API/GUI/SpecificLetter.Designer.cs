namespace GUI
{
    partial class SpecificLetter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Back = new Button();
            label1 = new Label();
            letterInput = new TextBox();
            textBox = new TextBox();
            recipeLabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Back
            // 
            Back.Font = new Font("Bodoni MT", 14F);
            Back.Location = new Point(45, 25);
            Back.Name = "Back";
            Back.Size = new Size(85, 31);
            Back.TabIndex = 3;
            Back.Text = "BACK";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bodoni MT", 14F);
            label1.Location = new Point(194, 25);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 4;
            label1.Text = "Letter";
            label1.Click += label1_Click;
            // 
            // letterInput
            // 
            letterInput.Location = new Point(194, 51);
            letterInput.Name = "letterInput";
            letterInput.Size = new Size(100, 23);
            letterInput.TabIndex = 5;
            letterInput.TextChanged += letterInput_TextChanged;
            // 
            // textBox
            // 
            textBox.Location = new Point(45, 137);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(405, 342);
            textBox.TabIndex = 6;
            textBox.TextChanged += textBox_TextChanged;
            // 
            // recipeLabel
            // 
            recipeLabel.AutoSize = true;
            recipeLabel.Font = new Font("Bodoni MT", 14F);
            recipeLabel.Location = new Point(45, 111);
            recipeLabel.Name = "recipeLabel";
            recipeLabel.Size = new Size(63, 23);
            recipeLabel.TabIndex = 8;
            recipeLabel.Text = "Recipe";
            // 
            // button1
            // 
            button1.Font = new Font("Bodoni MT", 14F);
            button1.Location = new Point(45, 62);
            button1.Name = "button1";
            button1.Size = new Size(85, 31);
            button1.TabIndex = 9;
            button1.Text = "CHECK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SpecificLetter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 511);
            Controls.Add(button1);
            Controls.Add(recipeLabel);
            Controls.Add(textBox);
            Controls.Add(letterInput);
            Controls.Add(label1);
            Controls.Add(Back);
            Name = "SpecificLetter";
            Text = "SpecificLetter";
            Load += SpecificLetter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Label label1;
        private TextBox letterInput;
        private TextBox textBox;
        private Label recipeLabel;
        private Button button1;
    }
}