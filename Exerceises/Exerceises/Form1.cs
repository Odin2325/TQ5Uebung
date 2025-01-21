namespace Exerceises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int erstnummer = int.Parse(textBox1.Text);
                int zweitnummer = int.Parse(textBox2.Text);

                if (string.IsNullOrWhiteSpace(erstnummer.ToString()) || string.IsNullOrWhiteSpace(zweitnummer.ToString()))
                {
                    throw new ArgumentException("Bitte beide Felder ausfüllen.");
                }
                int ergibniss = erstnummer + zweitnummer;

                label4.Text = ergibniss.ToString();

            }

            catch (FormatException)
            {
                // Ungültige Eingabe (z. B. Buchstaben statt Zahlen)
                MessageBox.Show("Bitte geben Sie gültige Zahlen ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            
        }
    }
}
