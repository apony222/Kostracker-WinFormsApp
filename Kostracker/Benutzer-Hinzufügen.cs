using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Kostracker
{
    public partial class Benutzer_Hinzufügen : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-K8KU634\SQLEXPRESS;Initial Catalog=KOSTENTRACKER;Integrated Security=True");

        public Benutzer_Hinzufügen()
        {
            InitializeComponent();
        }

        private void benutzerTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string quiry = "SELECT * FROM Users WHERE username='" + benutzerTxt.Text + "';";
                SqlDataAdapter adapter = new SqlDataAdapter(quiry, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count != 0)
                {
                    msglab1.Visible = true;
                    msglab1.Text = "Benutzer name ist nicht verfügbar";
                    msglab1.ForeColor = Color.Red;
                }
                else
                {
                    msglab1.Visible = true;
                    msglab1.Text = "Gültig !";
                    msglab1.ForeColor = Color.Green;
                }
            }
            catch
            {
                MessageBox.Show("fehler database verbinden", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

        }

        private void BestätigunTxt_TextChanged(object sender, EventArgs e)
        {
            if (KennwortTxt.Text != BestätigunTxt.Text)
            {
                msglab2.Visible = true;
                msglab2.Text = "Kennwort unterschied !";
                msglab2.ForeColor = Color.Red;
            }
            else
            {
                msglab2.Visible = true;
                msglab2.ForeColor = Color.Green;
                msglab2.Text = "Passt !";
            }
        }

        private void kennwortAnzegenChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (kennwortAnzegenChkBox.Checked)
            {
                BestätigunTxt.UseSystemPasswordChar = false;
            }
            else
            {
                BestätigunTxt.UseSystemPasswordChar = true;
            }
        }

        private void hinzufügenbtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (msglab1.ForeColor != Color.Red && msglab2.ForeColor != Color.Red)
                {
                    string istadmin;
                    if (adminRdBtn.Checked == true)
                        istadmin = "True";
                    else
                        istadmin = "False";


                    string q = "INSERT INTO Users(username,userpassword,istadmin) VALUES ('" + benutzerTxt.Text + "','" + KennwortTxt.Text + "','" + istadmin + "');";
                    SqlCommand command = new SqlCommand(q, conn);
                    int r = command.ExecuteNonQuery();
                    if (r != 0)
                    {
                        MessageBox.Show("Erfölgreich", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("fehler database hinzufügen", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch
            {
                MessageBox.Show("fehler database verbinden", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void zurückSetzen_Click(object sender, EventArgs e)
        {
            benutzerTxt.Clear();
            KennwortTxt.Clear();
            BestätigunTxt.Clear();
            msglab1.Visible = false;
            msglab2.Visible = false;
            benutzerTxt.Select();
        }

        private void Benutzer_Hinzufügen_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string q = "SELECT * FROM Users WHERE username='" + Einlogin.benutzerName + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Columns.Count != 0)
                {
                    if (dt.Rows[0].ItemArray[2].ToString() == "False")
                    {
                        adminRdBtn.Enabled = false;
                    }


                }
                else
                {
                    MessageBox.Show("Not Found", "user", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
}
