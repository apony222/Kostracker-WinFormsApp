using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kostracker
{
    public partial class KennwortÄndren : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-K8KU634\SQLEXPRESS;Initial Catalog=KOSTENTRACKER;Integrated Security=True");

        public KennwortÄndren()
        {
            InitializeComponent();
        }

        private void anziegenChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (anziegenChkBox.Checked)
            {
                allteKennwort.UseSystemPasswordChar = false;
                neueKennwortTxt.UseSystemPasswordChar = false;
                neubestätigung.UseSystemPasswordChar = false;
            }

            else
            {
                allteKennwort.UseSystemPasswordChar = true;
                neueKennwortTxt.UseSystemPasswordChar = true;
                neubestätigung.UseSystemPasswordChar = true;
            }
        }

        private void hinzufügenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string q = "SELECT * FROM Users WHERE username='" + Einlogin.benutzerName + "';";
                SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (allteKennwort.Text == dataTable.Rows[0].ItemArray[1].ToString())
                {
                    if (dataTable.Rows.Count != 0)
                    {
                        if (neueKennwortTxt.Text == neubestätigung.Text)
                        {
                            benutzerTxt.Text = dataTable.Rows[0].ItemArray[0].ToString();

                            string qupdate = "UPDATE Users SET userpassword='" + neueKennwortTxt.Text + "' WHERE username='" + Einlogin.benutzerName + "';";
                            SqlDataAdapter adapter2 = new SqlDataAdapter(qupdate, conn);
                            DataTable dataTable2 = new DataTable();
                            adapter2.Fill(dataTable2);
                            MessageBox.Show("Updated");
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Kennworte sind unterschiedlich");
                            neubestätigung.Clear();
                            neubestätigung.Select();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Keine Daten werden gefünden", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    allteKennwort.Clear();
                    allteKennwort.Select();
                    MessageBox.Show("Alte Kenntwort ist falsch", "Felher", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }

        private void KennwortÄndren_Load(object sender, EventArgs e)
        {
            benutzerTxt.Text = Einlogin.benutzerName;
        }

        private void abbrechenBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
