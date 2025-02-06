using System.Data;

namespace BenutzerListe
{
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
        }

        private void loginKnopf_Click(object sender, EventArgs e)
        {
            textBenutzername.Clear();
            textPasswort.Clear();
            textBenutzername.Text.Trim();

            MessageBox.Show("Login Erfolgreich","Login Status",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
