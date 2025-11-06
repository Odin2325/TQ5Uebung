namespace BenutzerListe
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
            textBenutzername = new TextBox();
            labelBenutzername = new Label();
            labelPasswort = new Label();
            textPasswort = new TextBox();
            loginKnopf = new Button();
            SuspendLayout();
            // 
            // textBenutzername
            // 
            textBenutzername.BackColor = Color.Black;
            textBenutzername.Font = new Font("Consolas", 9F);
            textBenutzername.ForeColor = Color.LawnGreen;
            textBenutzername.Location = new Point(332, 141);
            textBenutzername.Name = "textBenutzername";
            textBenutzername.Size = new Size(100, 22);
            textBenutzername.TabIndex = 0;
            // 
            // labelBenutzername
            // 
            labelBenutzername.AutoSize = true;
            labelBenutzername.BackColor = Color.Black;
            labelBenutzername.Font = new Font("Consolas", 9F);
            labelBenutzername.ForeColor = Color.LawnGreen;
            labelBenutzername.Location = new Point(217, 141);
            labelBenutzername.Name = "labelBenutzername";
            labelBenutzername.Size = new Size(91, 14);
            labelBenutzername.TabIndex = 1;
            labelBenutzername.Text = "Benutzername";
            // 
            // labelPasswort
            // 
            labelPasswort.AutoSize = true;
            labelPasswort.BackColor = Color.Black;
            labelPasswort.Font = new Font("Consolas", 9F);
            labelPasswort.ForeColor = Color.LawnGreen;
            labelPasswort.Location = new Point(217, 197);
            labelPasswort.Name = "labelPasswort";
            labelPasswort.Size = new Size(63, 14);
            labelPasswort.TabIndex = 3;
            labelPasswort.Text = "Passwort";
            // 
            // textPasswort
            // 
            textPasswort.BackColor = Color.Black;
            textPasswort.Font = new Font("Consolas", 9F);
            textPasswort.ForeColor = Color.LawnGreen;
            textPasswort.Location = new Point(332, 194);
            textPasswort.Name = "textPasswort";
            textPasswort.PasswordChar = '*';
            textPasswort.Size = new Size(100, 22);
            textPasswort.TabIndex = 2;
            // 
            // loginKnopf
            // 
            loginKnopf.Font = new Font("Consolas", 9F);
            loginKnopf.Location = new Point(332, 239);
            loginKnopf.Name = "loginKnopf";
            loginKnopf.Size = new Size(100, 32);
            loginKnopf.TabIndex = 5;
            loginKnopf.Text = "Werte Eingeben";
            loginKnopf.UseVisualStyleBackColor = true;
            loginKnopf.Click += loginKnopf_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(loginKnopf);
            Controls.Add(labelPasswort);
            Controls.Add(textPasswort);
            Controls.Add(labelBenutzername);
            Controls.Add(textBenutzername);
            Name = "Form1";
            Text = "Login Fenster";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBenutzername;
        private Label labelBenutzername;
        private Label labelPasswort;
        private TextBox textPasswort;
        private Button loginKnopf;
    }
}
