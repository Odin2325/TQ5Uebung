namespace FormLernen
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
            txtbenutzerName = new TextBox();
            labelUser = new Label();
            labelPass = new Label();
            txtPass = new TextBox();
            btnOK = new Button();
            SuspendLayout();
            // 
            // txtbenutzerName
            // 
            txtbenutzerName.Location = new Point(197, 69);
            txtbenutzerName.Name = "txtbenutzerName";
            txtbenutzerName.Size = new Size(100, 23);
            txtbenutzerName.TabIndex = 0;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.BackColor = SystemColors.ControlText;
            labelUser.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUser.ForeColor = SystemColors.ButtonShadow;
            labelUser.Location = new Point(92, 73);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(98, 14);
            labelUser.TabIndex = 1;
            labelUser.Text = "Benutzer Name";
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.BackColor = SystemColors.ControlText;
            labelPass.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPass.ForeColor = SystemColors.ControlDark;
            labelPass.Location = new Point(123, 111);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(63, 14);
            labelPass.TabIndex = 3;
            labelPass.Text = "Passwort";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(198, 108);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 2;
            // 
            // btnOK
            // 
            btnOK.FlatStyle = FlatStyle.Popup;
            btnOK.Location = new Point(150, 192);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 4;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(397, 298);
            Controls.Add(btnOK);
            Controls.Add(labelPass);
            Controls.Add(txtPass);
            Controls.Add(labelUser);
            Controls.Add(txtbenutzerName);
            Name = "Form1";
            Text = "Login Fenster";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbenutzerName;
        private Label labelUser;
        private Label labelPass;
        private TextBox txtPass;
        private Button btnOK;
    }
}
