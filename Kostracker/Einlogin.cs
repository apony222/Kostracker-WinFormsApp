using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kostracker
{

    public partial class Einlogin : Form
    {
        public static string benutzerName = "";
        public static string istAdmin = "False";

        public Einlogin()
        {
            InitializeComponent();
        }

        private void anzeigenCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (anzeigenCheckbox.Checked)
                kennwortTxt.UseSystemPasswordChar = false;
            else
                kennwortTxt.UseSystemPasswordChar = true;
        }

        private void anmeldenBtn_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-K8KU634\SQLEXPRESS;Initial Catalog=KOSTENTRACKER;Integrated Security=True");
            string quiry = "SELECT * FROM Users WHERE username = '" + benuzterTxt.Text + "' AND userpassword = '" + kennwortTxt.Text + "';";
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(quiry, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count != 0)
            {
                benutzerName = benuzterTxt.Text;
                istAdmin = dataTable.Rows[0].ItemArray[2].ToString();
                // new Splash().Show();
                new Home().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("falsches Passwort/Benutzer-Name", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                kennwortTxt.Clear();
                kennwortTxt.Select();
            }
        }

        private void abbrechenBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
