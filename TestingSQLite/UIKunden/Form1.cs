namespace UIKunden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_LoadNextForm(object sender, EventArgs e)
        {
            Form2 nextForm = new Form2(this);

            nextForm.Show();

            this.Hide();
        }
    }
}
