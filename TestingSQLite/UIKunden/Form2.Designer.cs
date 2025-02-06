namespace UIKunden
{
    partial class Form2
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
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Hallo! Ich bin Form2!";
            // 
            // button1
            // 
            button1.Location = new Point(56, 368);
            button1.Name = "button1";
            button1.Size = new Size(129, 59);
            button1.TabIndex = 1;
            button1.Text = "HauptMenu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(423, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(482, 284);
            button2.Name = "button2";
            button2.Size = new Size(110, 23);
            button2.TabIndex = 3;
            button2.Text = "FullName Show";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_ClickShowFullNames;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 486);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
    }
}