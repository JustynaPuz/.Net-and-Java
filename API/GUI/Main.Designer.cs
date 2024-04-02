namespace GUI
{
    partial class Main
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
            button1 = new Button();
            allCategory_button = new Button();
            specificLetter_button = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 9.75F);
            button1.Location = new Point(146, 110);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(150, 80);
            button1.TabIndex = 2;
            button1.Text = "Get specific recipe";
            button1.UseVisualStyleBackColor = true;
            button1.Click += specificRecipe_Click;
            // 
            // allCategory_button
            // 
            allCategory_button.Font = new Font("Calibri", 9.75F);
            allCategory_button.Location = new Point(146, 236);
            allCategory_button.Margin = new Padding(3, 2, 3, 2);
            allCategory_button.Name = "allCategory_button";
            allCategory_button.Size = new Size(150, 80);
            allCategory_button.TabIndex = 3;
            allCategory_button.Text = "All recipes in a specific category";
            allCategory_button.UseVisualStyleBackColor = true;
            allCategory_button.Click += allCategory_Click;
            // 
            // specificLetter_button
            // 
            specificLetter_button.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            specificLetter_button.Location = new Point(146, 352);
            specificLetter_button.Margin = new Padding(3, 2, 3, 2);
            specificLetter_button.Name = "specificLetter_button";
            specificLetter_button.Size = new Size(150, 80);
            specificLetter_button.TabIndex = 4;
            specificLetter_button.Text = "All recipes that start with a specific letter";
            specificLetter_button.UseVisualStyleBackColor = true;
            specificLetter_button.Click += specificLetter_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bodoni MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 45);
            label1.Name = "label1";
            label1.Size = new Size(270, 29);
            label1.TabIndex = 5;
            label1.Text = "Help with kitchen recipes";
            label1.Click += label1_Click_1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 511);
            Controls.Add(label1);
            Controls.Add(specificLetter_button);
            Controls.Add(allCategory_button);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Main";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button allCategory_button;
        private Button specificLetter_button;
        private Label label1;
    }
}
