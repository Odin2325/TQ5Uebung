namespace FormLernen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
          
            string benutzName = txtbenutzerName.Text.Trim(); 
            string Passwort = txtPass.Text.Trim();

            MessageBox.Show("Sie sind eingeloggt", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtbenutzerName.Clear();
            txtPass.Clear();
        }

        
    }
}
