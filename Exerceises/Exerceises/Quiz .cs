using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exerceises
{
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                label2.Text = "falshe Antwort";
            }

            if (radioButton2.Checked)
            {
                label2.Text = "falshe Antwort";
            }
            if(radioButton3.Checked)
            {
                label2.Text = "richtige Antwort";
            }
        }
    }
}
