namespace GUI
{
    partial class AllMealsInCategory
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
            label2 = new Label();
            textBox = new TextBox();
            label3 = new Label();
            button1 = new Button();
            comboBoxCategory = new ComboBox();
            comboBoxMeal = new ComboBox();
            SuspendLayout();
            // 
            // Back
            // 
            Back.Font = new Font("Bodoni MT", 14F);
            Back.Location = new Point(41, 31);
            Back.Name = "Back";
            Back.Size = new Size(85, 31);
            Back.TabIndex = 2;
            Back.Text = "BACK";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bodoni MT", 14F);
            label1.Location = new Point(201, 22);
            label1.Name = "label1";
            label1.Size = new Size(81, 23);
            label1.TabIndex = 4;
            label1.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bodoni MT", 14F);
            label2.Location = new Point(201, 87);
            label2.Name = "label2";
            label2.Size = new Size(48, 23);
            label2.TabIndex = 5;
            label2.Text = "Meal";
            // 
            // textBox
            // 
            textBox.Location = new Point(41, 198);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(410, 283);
            textBox.TabIndex = 7;
            textBox.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bodoni MT", 14F);
            label3.Location = new Point(41, 162);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 8;
            label3.Text = "Recipe";
            // 
            // button1
            // 
            button1.Font = new Font("Bodoni MT", 14F);
            button1.Location = new Point(41, 68);
            button1.Name = "button1";
            button1.Size = new Size(85, 31);
            button1.TabIndex = 9;
            button1.Text = "CHECK";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(201, 48);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(150, 23);
            comboBoxCategory.TabIndex = 10;
            comboBoxCategory.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // comboBoxMeal
            // 
            comboBoxMeal.FormattingEnabled = true;
            comboBoxMeal.Location = new Point(201, 113);
            comboBoxMeal.Name = "comboBoxMeal";
            comboBoxMeal.Size = new Size(150, 23);
            comboBoxMeal.TabIndex = 11;
            comboBoxMeal.SelectedIndexChanged += comboBoxMeal_SelectedIndexChanged;
            // 
            // AllMealsInCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 511);
            Controls.Add(comboBoxMeal);
            Controls.Add(comboBoxCategory);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Back);
            Name = "AllMealsInCategory";
            Text = "AllMealsInCategory";
            Load += AllMealsInCategory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Label label1;
        private Label label2;
        private TextBox textBox;
        private Label label3;
        private Button button1;
        private ComboBox comboBoxCategory;
        private ComboBox comboBoxMeal;
    }
}