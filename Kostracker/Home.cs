using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kostracker
{

    public partial class Home : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-K8KU634\SQLEXPRESS;Initial Catalog=KOSTENTRACKER;Integrated Security=True");
        private string mieteSoll, nebenkostenSoll, lebensmittelSoll, gesundheitSoll, versicherungSoll, transportSoll, bekeidungSoll, unterhaltungSoll;
        private float miete = 0, nebenkosten = 0, lebensmittel = 0, gesundheit = 0, versicherung = 0, transport = 0, bekeidung = 0, unterhaltung = 0;
        private float mieteGh = 0, nebenkostenGh = 0, lebensmittelGh = 0, gesundheitGh = 0, versicherungGh = 0, transportGh = 0, bekleidungGh = 0, unterhaltungGh = 0;
        public Home()
        {
            InitializeComponent();
        }
        public int load;
        private void Home_Load(object sender, EventArgs e)
        {

            /*   this.WindowState = FormWindowState.Minimized;
              if(Splash==100)
               {
                   this.WindowState = FormWindowState.Maximized;

               }*/


            // TODO: This line of code loads data into the 'kOSTENTRACKERDataSet.CategoriesName' table. You can move, or remove it, as needed.
            this.categoriesNameTableAdapter.Fill(this.kOSTENTRACKERDataSet.CategoriesName);

            label1.Text = DateTime.Now.ToString("hh:mm:ss");
            comboBox1.Text = "--Kategorie wählen--";
            listView1.Clear();



            TxtSollDataLoad();





            ListviewDataLoad();


            //Guthaben Textboes Auffüllen.
            CalGuthaben();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Filling Tagesliste Listview with the current Date Data
            ListviewDataLoadCurrent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SaveData();
            ListviewDataLoadCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextboxClear();
            TxtSollDataLoad();
            ListviewDataLoad();
            CalGuthaben();
        }

        private void zielBearbetenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Ziel_bearbeitung().Show();

        }

        private void benutzerHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Benutzer_Hinzufügen().Show();
        }

        private void kennwortÄndarnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new KennwortÄndren().Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");


        }

        private void schließenBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Möchten Sie die App schließen und sich abmelden?!", "Vorsicht", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void abmeldenBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new Einlogin().Show();
        }

        private void bnutzerListeBearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BenutzerListe().Show();
        }

        private void wertTxt_TextChanged(object sender, EventArgs e)
        {
            string s = wertTxt.Text.ToString();
            for (int i = 0; i < s.Length; i++)
                if (char.IsDigit(s[i]) == false && s[i] != '.')
                {
                    MessageBox.Show(s[i] + " wert fehler");
                }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }








        public void TxtSollDataLoad()
        {

            try
            {
                conn.Open();
                string q = "SELECT * FROM categoriesSoll;";
                SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count != 0)
                {
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
                        gesamt2Txt.Text = gesamt2.ToString(".0" + " €");


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




        public void ListviewDataLoadCurrent()
        {
            listView1.GridLines = true;
            listView1.Clear();
            try
            {
                string day, month, year;
                day = dateTimePicker1.Value.Day.ToString();
                month = dateTimePicker1.Value.Month.ToString();
                year = dateTimePicker1.Value.Year.ToString();
                conn.Open();
                string quiry = "SELECT * FROM kosten WHERE day='" + day + "' and month='" + month + "' and year='" + year + "';";
                SqlDataAdapter adapter = new SqlDataAdapter(quiry, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                listView1.View = View.Details;
                listView1.GridLines = true;
                listView1.Columns.Add("Kosten", 100, HorizontalAlignment.Center);
                listView1.Columns.Add("Wert", 50, HorizontalAlignment.Center);
                listView1.Columns.Add("Notiz", 165, HorizontalAlignment.Center);

                if (dataTable.Rows.Count > 0)
                {

                    float gesamt = 0;
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        //Add Item to ListView.
                        if (dataTable.Rows[i].ItemArray[2].ToString() == dateTimePicker1.Value.Day.ToString() && dataTable.Rows[i].ItemArray[3].ToString() == dateTimePicker1.Value.Month.ToString() && dataTable.Rows[i].ItemArray[4].ToString() == dateTimePicker1.Value.Year.ToString())
                        {
                            ListViewItem item = new ListViewItem(dataTable.Rows[i].ItemArray[0].ToString());
                            item.SubItems.Add(dataTable.Rows[i].ItemArray[1].ToString());
                            item.SubItems.Add(dataTable.Rows[i].ItemArray[6].ToString());
                            listView1.Items.Add(item);
                            gesamt = gesamt + float.Parse(dataTable.Rows[i].ItemArray[1].ToString());
                            gesamt1Txt.Text = gesamt.ToString();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Keine daten gefünden", "Keine Daten !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            catch
            {
                MessageBox.Show("Error Kosten Database");
            }
            finally
            {
                conn.Close();
            }
        }




        public void ListviewDataLoad()
        {
            try
            {
                listView1.Clear();
                string day = dateTimePicker1.Value.Day.ToString();
                string month = dateTimePicker1.Value.Month.ToString();
                string year = dateTimePicker1.Value.Year.ToString();
                conn.Open();
                string quiry = "SELECT * FROM kosten;";
                SqlDataAdapter adapter = new SqlDataAdapter(quiry, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);


                if (dataTable.Rows.Count > 0)
                {
                    listView1.View = View.Details;
                    listView1.GridLines = true;
                    listView1.Columns.Add("Kosten", 100, HorizontalAlignment.Center);
                    listView1.Columns.Add("Wert", 50, HorizontalAlignment.Center);
                    listView1.Columns.Add("Notiz", 165, HorizontalAlignment.Center);
                    float gesamt = 0;
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        //Add Item to ListView.
                        if (dataTable.Rows[i].ItemArray[2].ToString() == dateTimePicker1.Value.Day.ToString() && dataTable.Rows[i].ItemArray[3].ToString() == dateTimePicker1.Value.Month.ToString() && dataTable.Rows[i].ItemArray[4].ToString() == dateTimePicker1.Value.Year.ToString())
                        {
                            ListViewItem item = new ListViewItem(dataTable.Rows[i].ItemArray[0].ToString());
                            item.SubItems.Add(dataTable.Rows[i].ItemArray[1].ToString());
                            item.SubItems.Add(dataTable.Rows[i].ItemArray[6].ToString());
                            listView1.Items.Add(item);
                            gesamt = gesamt + float.Parse(dataTable.Rows[i].ItemArray[1].ToString());
                            gesamt1Txt.Text = gesamt.ToString();
                        }
                    }

                    gesamt = 0;
                    //Add Item to ListView this month kosten to the show textboxes and getting the total for user expenses Field.
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {

                        if (dataTable.Rows[i].ItemArray[3].ToString() == dateTimePicker1.Value.Month.ToString() && dataTable.Rows[i].ItemArray[4].ToString() == dateTimePicker1.Value.Year.ToString())
                        {
                            if (dataTable.Rows[i].ItemArray[0].ToString() == "Miete")
                            {
                                miete = miete + float.Parse(dataTable.Rows[i].ItemArray[1].ToString());
                                gesamt = gesamt + miete;
                                gesamt3Txt.Text = gesamt.ToString();
                                continue;
                            }
                            if (dataTable.Rows[i].ItemArray[0].ToString() == "NebenKosten")
                            {
                                nebenkosten = nebenkosten + float.Parse(dataTable.Rows[i].ItemArray[1].ToString());
                                gesamt = gesamt + nebenkosten;
                                gesamt3Txt.Text = gesamt.ToString();
                                continue;
                            }
                            if (dataTable.Rows[i].ItemArray[0].ToString() == "Lebensmittel")
                            {
                                lebensmittel = lebensmittel + float.Parse(dataTable.Rows[i].ItemArray[1].ToString());
                                gesamt = gesamt + lebensmittel;
                                gesamt3Txt.Text = gesamt.ToString();
                                continue;
                            }
                            if (dataTable.Rows[i].ItemArray[0].ToString() == "Gesundheit")
                            {
                                gesundheit = gesundheit + float.Parse(dataTable.Rows[i].ItemArray[1].ToString());
                                gesamt = gesamt + gesundheit;
                                gesamt3Txt.Text = gesamt.ToString();
                                continue;
                            }
                            if (dataTable.Rows[i].ItemArray[0].ToString() == "Versicherung")
                            {
                                versicherung = versicherung + float.Parse(dataTable.Rows[i].ItemArray[1].ToString());
                                gesamt = gesamt + versicherung;
                                gesamt3Txt.Text = gesamt.ToString();
                                continue;
                            }
                            if (dataTable.Rows[i].ItemArray[0].ToString() == "Transport")
                            {
                                transport = transport + float.Parse(dataTable.Rows[i].ItemArray[1].ToString());
                                gesamt = gesamt + transport;
                                gesamt3Txt.Text = gesamt.ToString();
                                continue;
                            }
                            if (dataTable.Rows[i].ItemArray[0].ToString() == "Bekleidung")
                            {
                                bekeidung = bekeidung + float.Parse(dataTable.Rows[i].ItemArray[1].ToString());
                                gesamt = gesamt + bekeidung;
                                gesamt3Txt.Text = gesamt.ToString();
                                continue;
                            }
                            if (dataTable.Rows[i].ItemArray[0].ToString() == "Unterhaltung")
                            {
                                unterhaltung = unterhaltung + float.Parse(dataTable.Rows[i].ItemArray[1].ToString());
                                gesamt = gesamt + unterhaltung;
                                gesamt3Txt.Text = gesamt.ToString();
                                continue;
                            }
                        }
                        gesamt3Txt.Text = gesamt.ToString();
                    }

                    mieteText.Text = miete.ToString();
                    nebenKostenTxt.Text = nebenkosten.ToString();
                    lebensmittelTxt.Text = lebensmittel.ToString();
                    gesundheitTxt.Text = gesundheit.ToString();
                    versicherungTxt.Text = versicherung.ToString();
                    transportTxt.Text = transport.ToString();
                    bekleidungTxt.Text = bekeidung.ToString();
                    unterhaltungTxT.Text = unterhaltung.ToString();
                }
                else
                {

                    MessageBox.Show("Keine Daten gefunden", "FEHLER", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch
            {
                MessageBox.Show("Catch MonateKostenTextBox", "FEHLER", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void CalGuthaben()
        {
            mieteGh = float.Parse(mieteSoll) - miete;
            nebenkostenGh = float.Parse(nebenkostenSoll) - nebenkosten;
            lebensmittelGh = float.Parse(lebensmittelSoll) - lebensmittel;
            gesundheitGh = float.Parse(gesundheitSoll) - gesundheit;
            versicherungGh = float.Parse(versicherungSoll) - versicherung;
            transportGh = float.Parse(transportSoll) - transport;
            bekleidungGh = float.Parse(bekeidungSoll) - bekeidung;
            unterhaltungGh = float.Parse(unterhaltungSoll) - unterhaltung;

            mieteGHtxt.Text = mieteGh.ToString();
            nebenkostenGHtxt.Text = nebenkostenGh.ToString();
            lebensmittelGHtxt.Text = lebensmittelGh.ToString();
            gesundheitGHtxt.Text = gesundheitGh.ToString();
            versicherungGHtxt.Text = versicherungGh.ToString();
            transportGHtxt.Text = transportGh.ToString();
            bekleidungGHtxt.Text = bekleidungGh.ToString();
            unterhaltungGHtxt.Text = unterhaltungGh.ToString();
            gesamtGHtxt.Text = (mieteGh + nebenkostenGh + lebensmittelGh + gesundheitGh + versicherungGh + transportGh + bekleidungGh + unterhaltungGh).ToString();
        }

        public void SaveData()
        {
            if (comboBox1.Text != "--Kategorie wählen--" && comboBox1.Text != "")
            {
                if (comboBox1.Text == "Miete" || comboBox1.Text == "NebenKosten" || comboBox1.Text == "Lebensmittel" || comboBox1.Text == "Gesundheit" || comboBox1.Text == "Versicherung" || comboBox1.Text == "Transport" || comboBox1.Text == "Bekleidung" || comboBox1.Text == "Unterhaltung")
                {
                    try
                    {



                        conn.Open();

                        SqlCommand cmd = new SqlCommand("insert into kosten(kostenName,wert,day,month,year,benutzer,notiz) values ('" + comboBox1.Text.ToString() + "','" + wertTxt.Text.ToString() + "','" + dateTimePicker2.Value.Day.ToString() + "','" + dateTimePicker2.Value.Month.ToString() + "','" + dateTimePicker2.Value.Year.ToString() + "','" + Einlogin.benutzerName.ToString() + "','" + textBox2.Text.ToString() + "');", conn);
                        int i = cmd.ExecuteNonQuery();
                        if (i != 0)
                        {
                            MessageBox.Show("Erfolgreich gespeichert", "Gespeichert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("nicht gespeichert");
                            comboBox1.Text = "--Kategorie wählen--";
                            textBox2.Clear();
                            wertTxt.Clear();
                            comboBox1.Select();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("beim Einfügen in Kosten-TB", "FEHLER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Kategorie wählen !", "FEHLER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(comboBox1.Text.ToString() + " Ist keine Kategorie !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void TextboxClear()
        {

            mieteSoll = "";
            nebenkostenSoll = "";
            lebensmittelSoll = "";
            gesundheitSoll = "";
            versicherungSoll = "";
            transportSoll = "";
            bekeidungSoll = "";
            unterhaltungSoll = "";

            miete = 0;
            nebenkosten = 0;
            lebensmittel = 0;
            gesundheit = 0;
            versicherung = 0;
            transport = 0;
            bekeidung = 0;
            unterhaltung = 0;

            mieteGh = 0;
            nebenkostenGh = 0;
            lebensmittelGh = 0;
            gesundheitGh = 0;
            versicherungGh = 0;
            transportGh = 0;
            bekleidungGh = 0;
            unterhaltungGh = 0;


            mietSollTxt.Clear();
            nebenkostenSollTxt.Clear();
            lebensmittlSollTxt.Clear();
            gesundheitSollTxt.Clear();
            versicherungSollTxt.Clear();
            transportSollTxt.Clear();
            bekleidungSollTxt.Clear();
            unterhaltungSollTxT.Clear();
            gesamt2Txt.Clear();



            mieteText.Clear();
            nebenKostenTxt.Clear();
            lebensmittelTxt.Clear();
            gesundheitTxt.Clear();
            versicherungTxt.Clear();
            transportTxt.Clear();
            bekleidungTxt.Clear();
            unterhaltungTxT.Clear();
            gesamt1Txt.Clear();
            gesamt3Txt.Clear();


            mieteGHtxt.Clear();
            nebenkostenGHtxt.Clear();
            lebensmittelGHtxt.Clear();
            gesundheitGHtxt.Clear();
            versicherungGHtxt.Clear();
            transportGHtxt.Clear();
            bekleidungGHtxt.Clear();
            unterhaltungGHtxt.Clear();
            gesamtGHtxt.Clear();
        }
    }


}

