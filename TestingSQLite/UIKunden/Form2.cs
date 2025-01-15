using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace UIKunden
{
    public partial class Form2 : Form
    {

        private Form _previousForm;

        public Form2(Form previousForm)
        {
            InitializeComponent();
            _previousForm = previousForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_ClickShowFullNames(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=C:\Users\MYTQ-Trainer\Documents\GitHub\TQ5Uebung\TestingSQLite\DatenbankErstellen\bin\Debug\net8.0\Clients.db;Version=3;";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    //Query ist ein Befehl wodurch wir bestimmte Daten bekommen.
                    string query = "SELECT FirstName, LastName FROM Clients";

                    DataTable dt = new DataTable();

                    using(SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        adapter.Fill(dt);
                    }

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
    }
}
