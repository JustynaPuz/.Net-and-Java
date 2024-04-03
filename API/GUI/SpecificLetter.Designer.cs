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
            Back.Location = new Point(51, 33);
            Back.Margin = new Padding(3, 4, 3, 4);
            Back.Name = "Back";
            Back.Size = new Size(114, 41);
            Back.TabIndex = 3;
            Back.Text = "BACK";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bodoni MT", 14F);
            label1.Location = new Point(222, 33);
            label1.Name = "label1";
            label1.Size = new Size(76, 29);
            label1.TabIndex = 4;
            label1.Text = "Letter";
            label1.Click += label1_Click;
            // 
            // letterInput
            // 
            letterInput.Location = new Point(222, 68);
            letterInput.Margin = new Padding(3, 4, 3, 4);
            letterInput.Name = "letterInput";
            letterInput.Size = new Size(114, 27);
            letterInput.TabIndex = 5;
            letterInput.TextChanged += letterInput_TextChanged;
            // 
            // textBox
            // 
            textBox.Location = new Point(51, 183);
            textBox.Margin = new Padding(3, 4, 3, 4);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(462, 455);
            textBox.TabIndex = 6;
            textBox.TextChanged += textBox_TextChanged;
            // 
            // recipeLabel
            // 
            recipeLabel.AutoSize = true;
            recipeLabel.Font = new Font("Bodoni MT", 14F);
            recipeLabel.Location = new Point(51, 148);
            recipeLabel.Name = "recipeLabel";
            recipeLabel.Size = new Size(81, 29);
            recipeLabel.TabIndex = 8;
            recipeLabel.Text = "Recipe";
            // 
            // button1
            // 
            button1.Font = new Font("Bodoni MT", 14F);
            button1.Location = new Point(51, 83);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(114, 41);
            button1.TabIndex = 9;
            button1.Text = "CHECK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SpecificLetter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 681);
            Controls.Add(button1);
            Controls.Add(recipeLabel);
            Controls.Add(textBox);
            Controls.Add(letterInput);
            Controls.Add(label1);
            Controls.Add(Back);
            Margin = new Padding(3, 4, 3, 4);
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