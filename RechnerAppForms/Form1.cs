using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Formats.Tar;

namespace RechnerAppForms
{
    public partial class FormRechner : Form
    {

        /*
          * Taschenrechner aufgabe:
          * Hier soll es einen knopf fuer jeden zeichen geben.
          * Wenn man bspw: auf den knopf 1 drueckt, dann soll die 1 gespeichert werden.
          * Am ende nehmen wir alle werte die eingegeben worden sind und fuehren das prozess aus.
          * 
          * Ausgabe in einen TextBox Ausgeben.
          * 
          * Klassenvariable: string aktuelleBerechnung = "";
          * 
          * Loesung DataTables => berechnung
          * aktuelleBerechnung += "1";
          * var resultat = new DataTable().Compute("12+523-5",null);
        */

        private string aktuelleBerechnung = "";

        public FormRechner()
        {
            InitializeComponent();
        }

        private void ZahlOderOperatorHinzuf�gen(string wert)
        {

            aktuelleBerechnung += wert;
            txtEntry.Text = aktuelleBerechnung;
        }


        private void BerechnungAusf�hren()
        {

            txtEntry.Clear();
            try
            {
                var resultat = new DataTable().Compute(aktuelleBerechnung, null);
                txtEntry.Text = resultat.ToString();
                aktuelleBerechnung = resultat.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                aktuelleBerechnung = "";
                txtEntry.Clear();

            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ZahlOderOperatorHinzuf�gen("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ZahlOderOperatorHinzuf�gen("2");
            //if (txtEntry.Text == "0" && txtEntry.Text != null)
            //{
            //    txtEntry.Text = "2";
            //}
            //else
            //{
            //    txtEntry.Text = txtEntry.Text + "2";
            //}
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ZahlOderOperatorHinzuf�gen("3");
            //if (txtEntry.Text == "0" && txtEntry.Text != null)
            //{
            //    txtEntry.Text = "3";
            //}
            //else
            //{
            //    txtEntry.Text = txtEntry.Text + "3";
            //}
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ZahlOderOperatorHinzuf�gen("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ZahlOderOperatorHinzuf�gen("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ZahlOderOperatorHinzuf�gen("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ZahlOderOperatorHinzuf�gen("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ZahlOderOperatorHinzuf�gen("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ZahlOderOperatorHinzuf�gen("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            ZahlOderOperatorHinzuf�gen("0");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            ZahlOderOperatorHinzuf�gen("+");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            ZahlOderOperatorHinzuf�gen("-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            ZahlOderOperatorHinzuf�gen("*");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            ZahlOderOperatorHinzuf�gen("/");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            aktuelleBerechnung = "";
            txtEntry.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            BerechnungAusf�hren();
        }

    }
}
