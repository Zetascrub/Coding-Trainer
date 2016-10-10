using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Timers;
using System.Runtime.InteropServices;

namespace Coding_Trainer
{
    public partial class Form1 : Form
    {
        BackgroundWorker process_watcher = new BackgroundWorker();
        BackgroundWorker block_timer = new BackgroundWorker();
        int counter = 1;
        int credits = 0;

        public Form1()
        {
            InitializeComponent();
            process_watcher.DoWork += Process_watcher_DoWork;
            process_watcher.WorkerSupportsCancellation = true;
            block_timer.DoWork += Block_timer_DoWork;
            block_timer.WorkerSupportsCancellation = true;
        }

        private void Block_timer_DoWork(object sender, DoWorkEventArgs e)
        {
            // Starts the timer to monitor how much time has passed.
            System.Timers.Timer t;
            t = new System.Timers.Timer();
            t.Elapsed += timerElapsed;
            t.Interval = 1000;
            t.Start();
        }

        private void timerElapsed(object sender, ElapsedEventArgs e)
        {
            if (counter < 10)
            {
                // Increment counter and leave method
                counter++;
                return;
            }
            else
            {
                // Increase the credit
                credits++;
                //pass the result
                this.Invoke((MethodInvoker)delegate { lbl_credits.Text = string.Format("You currently have {0} Programming credit(s)", credits); });
                // reset minutes counter
                counter = 1;
            }
        }




        private void Process_watcher_DoWork(object sender, DoWorkEventArgs e)
        {
            // Monitor the processes currently running
            MessageBox.Show("Started");
            while (true)
            {
                if (process_watcher.CancellationPending)
                {
                    // Allows cancelation of thread
                    e.Cancel = true;
                    MessageBox.Show("Stopped");
                    return;
                }
                Thread.Sleep(1000);
                Process[] processlist = Process.GetProcesses();
                foreach (Process theprocess in processlist)
                {
                    foreach(string item in lb_BlockedProcess.Items)
                    {
                        if(item == theprocess.ProcessName)
                        {
                            theprocess.Kill();
                        }
                    }
                }
            }
        }

        private void about_click(object sender, EventArgs e)
        {
            // Loads "About" form
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void on_load(object sender, EventArgs e)
        {
            processRefresh();
            Thread T = new Thread(new ThreadStart(check_top_process));
            T.Start();
            this.Invoke((MethodInvoker)delegate { lbl_credits.Text = string.Format("You currently have {0} Programming credit(s)", credits); });
        }

        private void Process_loader_DoWork(object sender, DoWorkEventArgs e)
        {
            // Gets all current running processes and adds it to the listbox
            Process[] processlist = Process.GetProcesses();
            List<string> processes = new List<string>();
            foreach(Process process in processlist)
            {
                processes.Add(process.ProcessName);
                 
            }
            List<string> nodupes = processes.Distinct().ToList();
            foreach (string theprocess in nodupes)
            {
                if (!lb_BlockedProcess.Items.Contains(theprocess))
                {
                    this.Invoke((MethodInvoker)delegate { lb_ProcessList.Items.Add(theprocess); });
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            // Adds to Blocked list
            if(lb_ProcessList.SelectedIndex != -1)
            {
                lb_BlockedProcess.Items.Add(lb_ProcessList.Items[lb_ProcessList.SelectedIndex]);
                lb_ProcessList.Items.RemoveAt(lb_ProcessList.SelectedIndex);
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            // Removes from Blocked list
            if (lb_BlockedProcess.SelectedIndex != -1)
            {
                lb_ProcessList.Items.Add(lb_BlockedProcess.Items[lb_BlockedProcess.SelectedIndex]);
                lb_BlockedProcess.Items.RemoveAt(lb_BlockedProcess.SelectedIndex);
            }
        }

        private void btn_ProcessRefresh_Click(object sender, EventArgs e)
        {
            processRefresh();
        }

        void processRefresh()
        {
            // Refresh the process list
            this.Invoke((MethodInvoker)delegate { lb_ProcessList.Items.Clear(); });
            BackgroundWorker process_loader = new BackgroundWorker();
            process_loader.DoWork += Process_loader_DoWork;
            process_loader.RunWorkerAsync();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            // Starts the threads
            if(lb_BlockedProcess.Items.Count != 0)
            {
                process_watcher.RunWorkerAsync();
                block_timer.RunWorkerAsync();

            }
            else
            {
                MessageBox.Show("You need to block at least 1 program");
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            // Stops the threads
            process_watcher.CancelAsync();
            block_timer.CancelAsync();
        }

        private void btn_ignore_Click(object sender, EventArgs e)
        {
            // TODO: Create a list of processes to ignore. such as System processes
            Properties.Settings.Default.ignore_list = "test";
            Properties.Settings.Default.Save();
        }

        void check_top_process()
        {
            while (true)
            {
                try
                {
                    var currentproc = Process.GetCurrentProcess();
                    string name = currentproc.ProcessName;
                    MessageBox.Show(name);
                    Thread.Sleep(10000);
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
