﻿namespace GUI
{
    partial class SpecificRecipe
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
            label1 = new Label();
            Back = new Button();
            nameInput = new TextBox();
            textBox = new TextBox();
            recipeLabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bodoni MT", 14F);
            label1.Location = new Point(217, 47);
            label1.Name = "label1";
            label1.Size = new Size(185, 29);
            label1.TabIndex = 0;
            label1.Text = "Name of the dish";
            label1.Click += label1_Click;
            // 
            // Back
            // 
            Back.Font = new Font("Bodoni MT", 14F);
            Back.Location = new Point(55, 47);
            Back.Margin = new Padding(3, 4, 3, 4);
            Back.Name = "Back";
            Back.Size = new Size(114, 41);
            Back.TabIndex = 1;
            Back.Text = "BACK";
            Back.UseVisualStyleBackColor = true;
            Back.Click += back_Click;
            // 
            // nameInput
            // 
            nameInput.Location = new Point(217, 96);
            nameInput.Margin = new Padding(3, 4, 3, 4);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(164, 27);
            nameInput.TabIndex = 2;
            nameInput.TextChanged += nameInput_TextChanged;
            // 
            // textBox
            // 
            textBox.Location = new Point(55, 208);
            textBox.Margin = new Padding(3, 4, 3, 4);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(457, 432);
            textBox.TabIndex = 3;
            textBox.TextChanged += textBox1_TextChanged;
            // 
            // recipeLabel
            // 
            recipeLabel.AutoSize = true;
            recipeLabel.Font = new Font("Bodoni MT", 14F);
            recipeLabel.Location = new Point(55, 161);
            recipeLabel.Name = "recipeLabel";
            recipeLabel.Size = new Size(81, 29);
            recipeLabel.TabIndex = 4;
            recipeLabel.Text = "Recipe";
            // 
            // button1
            // 
            button1.Font = new Font("Bodoni MT", 14F);
            button1.Location = new Point(55, 96);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(114, 41);
            button1.TabIndex = 5;
            button1.Text = "CHECK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SpecificRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 681);
            Controls.Add(button1);
            Controls.Add(recipeLabel);
            Controls.Add(textBox);
            Controls.Add(nameInput);
            Controls.Add(Back);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SpecificRecipe";
            Text = "SpecificRecipe";
            Load += SpecificRecipe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Back;
        private TextBox nameInput;
        private TextBox textBox;
        private Label recipeLabel;
        private Button button1;
    }
}