using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace Components {
    public partial class Sixth : Form {
        public Sixth() {
            InitializeComponent();

            startThreadButton.Click += StartThreadButton_Click;
            messageBoxButton.Click += MessageBoxButton_Click;

            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            MessageBox.Show("Finished!");
            startThreadButton.Enabled = true;
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            this.Text = e.ProgressPercentage.ToString();
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e) {
            for (int i = 0; i < 100; ++i) {
                backgroundWorker.ReportProgress(i);
                Thread.Sleep(millisecondsTimeout: 100);
            }
        }

        private void MessageBoxButton_Click(object sender, EventArgs e) {
            MessageBox.Show("Just message!");
        }

        private void StartThreadButton_Click(object sender, EventArgs e) {
            startThreadButton.Enabled = false;

            if (!backgroundWorker.IsBusy) {
                backgroundWorker.RunWorkerAsync();
            }
        }
    }
}
