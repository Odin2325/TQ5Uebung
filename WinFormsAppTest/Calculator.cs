using System.Data;

namespace WinFormsAppTest
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (curNumText.Text == "0" && curNumText.Text != null)
                curNumText.Text = "1";
            else
                curNumText.Text = curNumText.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (curNumText.Text == "0" && curNumText.Text != null)
                curNumText.Text = "2";
            else
                curNumText.Text = curNumText.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (curNumText.Text == "0" && curNumText.Text != null)
                curNumText.Text = "3";
            else
                curNumText.Text = curNumText.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (curNumText.Text == "0" && curNumText.Text != null)
                curNumText.Text = "4";
            else
                curNumText.Text = curNumText.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (curNumText.Text == "0" && curNumText.Text != null)
                curNumText.Text = "5";
            else
                curNumText.Text = curNumText.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (curNumText.Text == "0" && curNumText.Text != null)
                curNumText.Text = "6";
            else
                curNumText.Text = curNumText.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (curNumText.Text == "0" && curNumText.Text != null)
                curNumText.Text = "7";
            else
                curNumText.Text = curNumText.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (curNumText.Text == "0" && curNumText.Text != null)
                curNumText.Text = "8";
            else
                curNumText.Text = curNumText.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (curNumText.Text == "0" && curNumText.Text != null)
                curNumText.Text = "9";
            else
                curNumText.Text = curNumText.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            curNumText.Text = curNumText.Text + "0";
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            curNumText.Text = curNumText.Text + ".";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (solutionText.Text == "0" && curNumText.Text == "0")
                return;
            else if (solutionText.Text == "0" || solutionText.Text.Contains('='))
                solutionText.Text = curNumText.Text + "+";
            else
                solutionText.Text = solutionText.Text + curNumText.Text + "+";
            curNumText.Text = "0";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (solutionText.Text == "0" && curNumText.Text == "0")
                return;
            else if (solutionText.Text == "0" || solutionText.Text.Contains('='))
                solutionText.Text = curNumText.Text + "-";
            else
                solutionText.Text = solutionText.Text + curNumText.Text + "-";
            curNumText.Text = "0";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
            //needs divideBy0 protection
        {
            if (solutionText.Text == "0" && curNumText.Text == "0")
                return;
            else if (solutionText.Text == "0" || solutionText.Text.Contains('='))
                solutionText.Text = curNumText.Text + "/";
            else
                solutionText.Text = solutionText.Text + curNumText.Text + "/";
            curNumText.Text = "0";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (solutionText.Text == "0" && curNumText.Text == "0")
                return;
            else if (solutionText.Text == "0" || solutionText.Text.Contains('='))
                solutionText.Text = curNumText.Text + "*";
            else
                solutionText.Text = solutionText.Text + curNumText.Text + "*" ;
            curNumText.Text = "0";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
            // needs rounding
            //calculations with curNum from equal-operation causes error
        {
            if (solutionText.Text == "0")
                return;
            if (!int.TryParse(Char.ToString(solutionText.Text[solutionText.Text.Length - 1]), out _))
            {
                solutionText.Text = solutionText.Text + curNumText.Text;
                //solutionText.Text = solutionText.Text.Substring(0, solutionText.Text.Length-1);
                var result = new DataTable().Compute(solutionText.Text, null);
                if (result != null)
                    curNumText.Text = result.ToString();
                solutionText.Text = solutionText.Text + " = " + result;
            }

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            curNumText.Text = "0";
            solutionText.Text = "";
        }

        private void buttonNegative_Click(object sender, EventArgs e)
        {
            if (curNumText.Text.StartsWith('-'))
                //curNumText.Text = curNumText.Text.Substring(1, curNumText.Text.Length-1);
                return;
            curNumText.Text = "-" + curNumText.Text;
        }
    }
}
