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
    public partial class Bilderanzeiger : Form
    {
        private Image originalImage;
        private float currentZoom = 1.0f;
        public Bilderanzeiger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Height--;
            pictureBox1.Width--;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Bilder|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    originalImage = Image.FromFile(openFileDialog.FileName);
                    currentZoom = 1.0f; // Zoom zurücksetzen

                }
            }
            try
            {
                pictureBox1.Image = originalImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Bild an die Größe der PictureBox anpassen
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Laden des Bildes: " + ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Height++;
            pictureBox1.Width++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AufgabeTracker aufgabe = new AufgabeTracker();
            aufgabe.Show();
        }
    }
}

