using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Kostracker
{
    public partial class Splash : Form
    {

        public Splash()
        {
            InitializeComponent();
            Shown += new EventHandler(Form1_Shown);

            // To report progress from the background worker we need to set this property
            backgroundWorker1.WorkerReportsProgress = true;
            // This event will be raised on the worker thread when the worker starts
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            // This event will be raised when we call ReportProgress
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
        }
        void Form1_Shown(object sender, EventArgs e)
        {
            // Start the background worker
            backgroundWorker1.RunWorkerAsync();


        }
        private void Splash_Load(object sender, EventArgs e)
        {


            //timer1.Start();
            //timer1.Interval = 10;

        }
        public int timeleft;
        private void timer1_Tick(object sender, EventArgs e)
        {
            /*  new Home().Show();
              if(timeleft>=0)
              {
                  new Home().Show();

                  timer1.Start();
                  timeleft = timeleft - 1;
                  progressBar1.Increment(2);

              }
              else
              {
                  timer1.Stop();
                  this.Close();
                  new Home().Show();

              }*/
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            for (int i = 0; i <= 100; i++)
            {
                // Report progress to 'UI' thread
                backgroundWorker1.ReportProgress(i);
                // Simulate long task

            }



        }
        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // The progress percentage is a property of e
            progressBar1.Value = e.ProgressPercentage;
        }
    }
}
