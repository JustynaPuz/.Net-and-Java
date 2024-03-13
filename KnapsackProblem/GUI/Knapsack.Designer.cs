namespace GUI
{
    partial class Knapsack
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
            Solve_button = new Button();
            Items_textbox = new TextBox();
            NumberOfItems_label = new Label();
            Capacity_label = new Label();
            Seed_label = new Label();
            Seed_textbox = new TextBox();
            Capacity_textbox = new TextBox();
            Instance_listbox = new ListBox();
            Instance_label = new Label();
            Result_label = new Label();
            Result_textbox = new TextBox();
            Title_label = new Label();
            SuspendLayout();
            // 
            // Solve_button
            // 
            Solve_button.BackColor = Color.PowderBlue;
            Solve_button.BackgroundImageLayout = ImageLayout.None;
            Solve_button.Font = new Font("Yu Gothic", 12F);
            Solve_button.Location = new Point(362, 82);
            Solve_button.Name = "Solve_button";
            Solve_button.Size = new Size(93, 49);
            Solve_button.TabIndex = 0;
            Solve_button.Text = "SOLVE";
            Solve_button.UseVisualStyleBackColor = false;
            Solve_button.Click += Solve_button_Click;
            // 
            // Items_textbox
            // 
            Items_textbox.BackColor = Color.PowderBlue;
            Items_textbox.BorderStyle = BorderStyle.FixedSingle;
            Items_textbox.Location = new Point(211, 82);
            Items_textbox.Name = "Items_textbox";
            Items_textbox.Size = new Size(84, 23);
            Items_textbox.TabIndex = 1;
            Items_textbox.TextChanged += Items_textbox_TextChanged;
            // 
            // NumberOfItems_label
            // 
            NumberOfItems_label.AutoSize = true;
            NumberOfItems_label.Font = new Font("Yu Gothic", 12F);
            NumberOfItems_label.Location = new Point(50, 84);
            NumberOfItems_label.Name = "NumberOfItems_label";
            NumberOfItems_label.Size = new Size(135, 21);
            NumberOfItems_label.TabIndex = 5;
            NumberOfItems_label.Text = "Number of items";
            NumberOfItems_label.Click += NumberOfItems_label_Click;
            // 
            // Capacity_label
            // 
            Capacity_label.AutoSize = true;
            Capacity_label.Font = new Font("Yu Gothic", 12F);
            Capacity_label.Location = new Point(50, 126);
            Capacity_label.Name = "Capacity_label";
            Capacity_label.Size = new Size(74, 21);
            Capacity_label.TabIndex = 7;
            Capacity_label.Text = "Capacity";
            // 
            // Seed_label
            // 
            Seed_label.AutoSize = true;
            Seed_label.Font = new Font("Yu Gothic", 12F);
            Seed_label.Location = new Point(50, 168);
            Seed_label.Name = "Seed_label";
            Seed_label.Size = new Size(47, 21);
            Seed_label.TabIndex = 8;
            Seed_label.Text = "Seed";
            // 
            // Seed_textbox
            // 
            Seed_textbox.BackColor = Color.PowderBlue;
            Seed_textbox.BorderStyle = BorderStyle.FixedSingle;
            Seed_textbox.Location = new Point(211, 166);
            Seed_textbox.Name = "Seed_textbox";
            Seed_textbox.Size = new Size(84, 23);
            Seed_textbox.TabIndex = 9;
            Seed_textbox.TextChanged += Seed_textbox_TextChanged;
            // 
            // Capacity_textbox
            // 
            Capacity_textbox.BackColor = Color.PowderBlue;
            Capacity_textbox.BorderStyle = BorderStyle.FixedSingle;
            Capacity_textbox.Location = new Point(211, 124);
            Capacity_textbox.Name = "Capacity_textbox";
            Capacity_textbox.Size = new Size(84, 23);
            Capacity_textbox.TabIndex = 10;
            Capacity_textbox.TextChanged += Capacity_textbox_TextChanged;
            // 
            // Instance_listbox
            // 
            Instance_listbox.BackColor = Color.PowderBlue;
            Instance_listbox.BorderStyle = BorderStyle.FixedSingle;
            Instance_listbox.FormattingEnabled = true;
            Instance_listbox.ItemHeight = 15;
            Instance_listbox.Location = new Point(515, 46);
            Instance_listbox.Name = "Instance_listbox";
            Instance_listbox.Size = new Size(235, 332);
            Instance_listbox.TabIndex = 11;
            Instance_listbox.SelectedIndexChanged += Instance_listbox_SelectedIndexChanged;
            // 
            // Instance_label
            // 
            Instance_label.AutoSize = true;
            Instance_label.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Instance_label.Location = new Point(515, 22);
            Instance_label.Name = "Instance_label";
            Instance_label.Size = new Size(73, 21);
            Instance_label.TabIndex = 13;
            Instance_label.Text = "Instance";
            // 
            // Result_label
            // 
            Result_label.AutoSize = true;
            Result_label.Font = new Font("Yu Gothic", 12F);
            Result_label.ImageAlign = ContentAlignment.TopLeft;
            Result_label.Location = new Point(50, 233);
            Result_label.Name = "Result_label";
            Result_label.Size = new Size(57, 21);
            Result_label.TabIndex = 14;
            Result_label.Text = "Result";
            // 
            // Result_textbox
            // 
            Result_textbox.BackColor = Color.PowderBlue;
            Result_textbox.BorderStyle = BorderStyle.FixedSingle;
            Result_textbox.Location = new Point(50, 257);
            Result_textbox.Multiline = true;
            Result_textbox.Name = "Result_textbox";
            Result_textbox.Size = new Size(340, 121);
            Result_textbox.TabIndex = 15;
            Result_textbox.TextChanged += Result_textbox_TextChanged;
            // 
            // Title_label
            // 
            Title_label.AutoSize = true;
            Title_label.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Title_label.ForeColor = Color.Black;
            Title_label.Location = new Point(50, 33);
            Title_label.Name = "Title_label";
            Title_label.Size = new Size(201, 27);
            Title_label.TabIndex = 16;
            Title_label.Text = "Knapsack problem";
            // 
            // Knapsack
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(Title_label);
            Controls.Add(Result_textbox);
            Controls.Add(Result_label);
            Controls.Add(Instance_label);
            Controls.Add(Instance_listbox);
            Controls.Add(Capacity_textbox);
            Controls.Add(Seed_textbox);
            Controls.Add(Seed_label);
            Controls.Add(Capacity_label);
            Controls.Add(NumberOfItems_label);
            Controls.Add(Items_textbox);
            Controls.Add(Solve_button);
            Name = "Knapsack";
            Text = "Form1";
            Load += Knapsack_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Solve_button;
        private TextBox Items_textbox;
        private Label NumberOfItems_label;
        private Label Capacity_label;
        private Label Seed_label;
        private TextBox Seed_textbox;
        private TextBox Capacity_textbox;
        private ListBox Instance_listbox;
        private Label Instance_label;
        private Label Result_label;
        private TextBox Result_textbox;
        private Label Title_label;
    }
}
