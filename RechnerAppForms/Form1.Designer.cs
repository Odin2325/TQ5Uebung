namespace RechnerAppForms
{
    partial class FormRechner
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
            txtEntry = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn0 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMultiply = new Button();
            btnPunkt = new Button();
            btnDiv = new Button();
            btnClear = new Button();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // txtEntry
            // 
            txtEntry.BackColor = SystemColors.ControlLight;
            txtEntry.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEntry.Location = new Point(3, 4);
            txtEntry.Margin = new Padding(3, 4, 3, 4);
            txtEntry.Multiline = true;
            txtEntry.Name = "txtEntry";
            txtEntry.ReadOnly = true;
            txtEntry.RightToLeft = RightToLeft.Yes;
            txtEntry.Size = new Size(289, 44);
            txtEntry.TabIndex = 0;
            txtEntry.Text = "0";
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ActiveCaption;
            btn1.FlatAppearance.BorderColor = Color.Black;
            btn1.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(8, 63);
            btn1.Margin = new Padding(3, 4, 3, 4);
            btn1.Name = "btn1";
            btn1.Size = new Size(67, 45);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ActiveCaption;
            btn2.FlatAppearance.BorderColor = Color.Black;
            btn2.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(73, 63);
            btn2.Margin = new Padding(3, 4, 3, 4);
            btn2.Name = "btn2";
            btn2.Size = new Size(67, 45);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ActiveCaption;
            btn4.FlatAppearance.BorderColor = Color.Black;
            btn4.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(8, 121);
            btn4.Margin = new Padding(3, 4, 3, 4);
            btn4.Name = "btn4";
            btn4.Size = new Size(67, 45);
            btn4.TabIndex = 1;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ActiveCaption;
            btn5.FlatAppearance.BorderColor = Color.Black;
            btn5.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(73, 121);
            btn5.Margin = new Padding(3, 4, 3, 4);
            btn5.Name = "btn5";
            btn5.Size = new Size(67, 45);
            btn5.TabIndex = 1;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ActiveCaption;
            btn7.FlatAppearance.BorderColor = Color.Black;
            btn7.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(8, 177);
            btn7.Margin = new Padding(3, 4, 3, 4);
            btn7.Name = "btn7";
            btn7.Size = new Size(67, 45);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ActiveCaption;
            btn8.FlatAppearance.BorderColor = Color.Black;
            btn8.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(73, 177);
            btn8.Margin = new Padding(3, 4, 3, 4);
            btn8.Name = "btn8";
            btn8.Size = new Size(67, 45);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ActiveCaption;
            btn0.FlatAppearance.BorderColor = Color.Black;
            btn0.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(73, 231);
            btn0.Margin = new Padding(3, 4, 3, 4);
            btn0.Name = "btn0";
            btn0.Size = new Size(67, 45);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ActiveCaption;
            btn3.FlatAppearance.BorderColor = Color.Black;
            btn3.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(138, 63);
            btn3.Margin = new Padding(3, 4, 3, 4);
            btn3.Name = "btn3";
            btn3.Size = new Size(67, 45);
            btn3.TabIndex = 1;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ActiveCaption;
            btn6.FlatAppearance.BorderColor = Color.Black;
            btn6.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(138, 121);
            btn6.Margin = new Padding(3, 4, 3, 4);
            btn6.Name = "btn6";
            btn6.Size = new Size(67, 45);
            btn6.TabIndex = 1;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ActiveCaption;
            btn9.FlatAppearance.BorderColor = Color.Black;
            btn9.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(138, 177);
            btn9.Margin = new Padding(3, 4, 3, 4);
            btn9.Name = "btn9";
            btn9.Size = new Size(67, 45);
            btn9.TabIndex = 1;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.ActiveCaption;
            btnPlus.FlatAppearance.BorderColor = Color.Black;
            btnPlus.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(213, 65);
            btnPlus.Margin = new Padding(3, 4, 3, 4);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(67, 45);
            btnPlus.TabIndex = 1;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = SystemColors.ActiveCaption;
            btnMinus.FlatAppearance.BorderColor = Color.Black;
            btnMinus.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(213, 121);
            btnMinus.Margin = new Padding(3, 4, 3, 4);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(67, 45);
            btnMinus.TabIndex = 1;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = SystemColors.ActiveCaption;
            btnMultiply.FlatAppearance.BorderColor = Color.Black;
            btnMultiply.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(213, 177);
            btnMultiply.Margin = new Padding(3, 4, 3, 4);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(67, 45);
            btnMultiply.TabIndex = 1;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnPunkt
            // 
            btnPunkt.BackColor = SystemColors.ActiveCaption;
            btnPunkt.FlatAppearance.BorderColor = Color.Black;
            btnPunkt.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPunkt.Location = new Point(3, 231);
            btnPunkt.Margin = new Padding(3, 4, 3, 4);
            btnPunkt.Name = "btnPunkt";
            btnPunkt.Size = new Size(67, 45);
            btnPunkt.TabIndex = 1;
            btnPunkt.Text = ".";
            btnPunkt.UseVisualStyleBackColor = false;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = SystemColors.ActiveCaption;
            btnDiv.FlatAppearance.BorderColor = Color.Black;
            btnDiv.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiv.Location = new Point(213, 231);
            btnDiv.Margin = new Padding(3, 4, 3, 4);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(67, 45);
            btnDiv.TabIndex = 1;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveCaption;
            btnClear.FlatAppearance.BorderColor = Color.Black;
            btnClear.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(138, 231);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(67, 45);
            btnClear.TabIndex = 1;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = SystemColors.ActiveCaption;
            btnEqual.FlatAppearance.BorderColor = Color.Black;
            btnEqual.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(96, 297);
            btnEqual.Margin = new Padding(3, 4, 3, 4);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(110, 45);
            btnEqual.TabIndex = 1;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // FormRechner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(297, 384);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn5);
            Controls.Add(btn2);
            Controls.Add(btn6);
            Controls.Add(btnEqual);
            Controls.Add(btnClear);
            Controls.Add(btnDiv);
            Controls.Add(btnPunkt);
            Controls.Add(btnMultiply);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btn3);
            Controls.Add(btn0);
            Controls.Add(btn7);
            Controls.Add(btn4);
            Controls.Add(btn1);
            Controls.Add(txtEntry);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormRechner";
            RightToLeftLayout = true;
            Text = "Rechner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEntry;
        private Button btn1;
        private Button btn2;
        private Button btn4;
        private Button btn5;
        private Button btn7;
        private Button btn8;
        private Button btn0;
        private Button btn3;
        private Button btn6;
        private Button btn9;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMultiply;
        private Button btnPunkt;
        private Button btnDiv;
        private Button btnClear;
        private Button btnEqual;
    }
}
