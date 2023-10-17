using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kostracker
{
    public partial class BenutzerListe : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-K8KU634\SQLEXPRESS;Initial Catalog=KOSTENTRACKER;Integrated Security=True");

        public BenutzerListe()
        {
            InitializeComponent();
        }

        private void BenutzerListe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kOSTENTRACKERDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.kOSTENTRACKERDataSet.Users);
            try
            {
                conn.Open();
                string q = "SELECT * FROM Users WHERE username='" + Einlogin.benutzerName + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Columns.Count != 0)
                {
                    if (Einlogin.istAdmin == "False")
                    {
                        this.Close();
                        MessageBox.Show("Nich Erlaubt", "Berechtigungen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
                else
                {
                    MessageBox.Show("Nich Erlaubt", "Nich gefunden", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch
            {
                MessageBox.Show("fehler Useres-database verbinden", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(dataGridView1.SelectedRows[0].Cells[0].Value + "Row Deleted");


            DialogResult result = MessageBox.Show("Benutzer Löschen?!", "Vorsicht", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string userName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    string qu = "DELETE FROM Users WHERE username='" + userName + "';";
                    SqlCommand command = new SqlCommand(qu, conn);
                    command.ExecuteNonQuery();
                    int r = command.ExecuteNonQuery();
                    if (r != 0)
                    {
                        MessageBox.Show("Nicht gelöscht", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Benutzer ist gelöscht", "Gelöscht", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);


                    }

                }
                catch
                {
                    MessageBox.Show("fehler Useres-database verbinden", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
