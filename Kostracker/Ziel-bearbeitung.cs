using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kostracker
{
    public partial class Ziel_bearbeitung : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-K8KU634\SQLEXPRESS;Initial Catalog=KOSTENTRACKER;Integrated Security=True");

        public Ziel_bearbeitung()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                string delqtxt = "DELETE FROM categoriesSoll";
                string q = "INSERT INTO categoriesSoll (mietesoll, nebenKostensoll, lebensmittelsoll, gesundheitsoll, versicherungsoll, transportsoll, bekleidungsoll, unterhaltungsoll) VALUES ('" + mietSollTxt.Text + "','" + nebenkostenSollTxt.Text + "','" + lebensmittlSollTxt.Text + "','" + gesundheitSollTxt.Text + "','" + versicherungSollTxt.Text + "','" + transportSollTxt.Text + "','" + bekleidungSollTxt.Text + "','" + unterhaltungSollTxT.Text + "');";
                SqlCommand delq = new SqlCommand(delqtxt, conn);
                SqlCommand command = new SqlCommand(q, conn);
                delq.ExecuteNonQuery();
                int r = command.ExecuteNonQuery();
                if (r != 0)
                {
                    MessageBox.Show("Gespeichert", "Erfölgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }

            catch
            {
                MessageBox.Show("ERROR db");
                Application.Exit();

            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mietSollTxt.Clear();
            nebenkostenSollTxt.Clear();
            lebensmittlSollTxt.Clear();
            gesundheitSollTxt.Clear();
            versicherungSollTxt.Clear();
            transportSollTxt.Clear();
            bekleidungSollTxt.Clear();
            unterhaltungSollTxT.Clear();
            mietSollTxt.Select();
        }

        private void Ziel_bearbeitung_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string q = "SELECT * FROM categoriesSoll;";
                SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                string mieteSoll = "", nebenkostenSoll = "", lebensmittelSoll = "", gesundheitSoll = "", versicherungSoll = "", transportSoll = "", bekeidungSoll = "", unterhaltungSoll = "";
                if (dataTable.Rows.Count != 0)
                {
                    if (Einlogin.istAdmin == "False")
                    {
                        this.Close();
                        MessageBox.Show("Nich Erlaubt", "Berechtigungen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    int x;
                    float gesamt2 = 0;
                    for (x = 0; x < dataTable.Rows.Count; x++)
                    {

                        mieteSoll = dataTable.Rows[x].ItemArray[0].ToString();
                        nebenkostenSoll = dataTable.Rows[x].ItemArray[1].ToString();
                        lebensmittelSoll = dataTable.Rows[x].ItemArray[2].ToString();
                        gesundheitSoll = dataTable.Rows[x].ItemArray[3].ToString();
                        versicherungSoll = dataTable.Rows[x].ItemArray[4].ToString();
                        transportSoll = dataTable.Rows[x].ItemArray[5].ToString();
                        bekeidungSoll = dataTable.Rows[x].ItemArray[6].ToString();
                        unterhaltungSoll = dataTable.Rows[x].ItemArray[7].ToString();

                        gesamt2 = float.Parse(mieteSoll) + float.Parse(nebenkostenSoll) + float.Parse(lebensmittelSoll) + float.Parse(gesundheitSoll) + float.Parse(versicherungSoll) + float.Parse(transportSoll) + float.Parse(bekeidungSoll) + float.Parse(unterhaltungSoll);

                        mietSollTxt.Text = mieteSoll.ToString();
                        nebenkostenSollTxt.Text = nebenkostenSoll.ToString();
                        lebensmittlSollTxt.Text = lebensmittelSoll.ToString();
                        gesundheitSollTxt.Text = gesundheitSoll.ToString();
                        versicherungSollTxt.Text = versicherungSoll.ToString();
                        transportSollTxt.Text = transportSoll.ToString();
                        bekleidungSollTxt.Text = bekeidungSoll.ToString();
                        unterhaltungSollTxT.Text = unterhaltungSoll.ToString();


                    }
                }
                else
                {
                    MessageBox.Show("Keine Daten werden gefünden", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
