using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace Coding_Trainer
{
    public partial class Form1 : Form
    {
        private BackgroundWorker process_watcher = new BackgroundWorker();
        private BackgroundWorker block_timer = new BackgroundWorker();
        private int counter = 1;
        private int credits = 0;

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

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
            try
            {
                if (counter == 60000)
                {
                    if (GetActiveWindowTitle().Contains("Microsoft Visual Studio"))
                    {
                        // Increment counter and leave method

                        credits++;
                        return;
                    }
                    if (!GetActiveWindowTitle().Contains("Microsoft Visual Studio") && (credits >= 0))
                    {
                        // Increase the credit
                        if (credits == 0)
                        {
                            //Do Nothing
                        }
                        else
                        {
                            credits--;
                        }
                    }
                }
            }
            catch
            {
            }
            finally
            {
                //Report Active Window
                report_active();
                //pass the result
                this.Invoke((MethodInvoker)delegate { lbl_credits.Text = string.Format("You currently have {0} Programming credit(s)", credits); });
            }
        }

        private void report_active()
        {
            active_window(GetActiveWindowTitle());
        }

        private void active_window(string window)
        {
            lbl_Active.Invoke((MethodInvoker)delegate { lbl_Active.Text = "Active Window: " + window; });
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
                    foreach (string item in lb_BlockedProcess.Items)
                    {
                        if ((item == theprocess.ProcessName) && (!Properties.Settings.Default.IgnoreList.Contains(item)))
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
            Thread T = new Thread(new ThreadStart(report_active));
            T.Start();
            this.Invoke((MethodInvoker)delegate { lbl_credits.Text = string.Format("You currently have {0} Programming credit(s)", credits); });
        }

        private void Process_loader_DoWork(object sender, DoWorkEventArgs e)
        {
            // Gets all current running processes and adds it to the listbox
            Process[] processlist = Process.GetProcesses();
            List<string> processes = new List<string>();
            foreach (Process process in processlist)
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
            if (lb_ProcessList.SelectedIndex != -1)
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

        private void processRefresh()
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
            if (lb_BlockedProcess.Items.Count != 0)
            {
                //Start the Background workers
                process_watcher.RunWorkerAsync();
                block_timer.RunWorkerAsync();

                //Disable the controls
                Form1 f1 = new Form1();
                foreach (Control c in Controls)
                {
                    if ((c.Text != "Stop") || (c.Name.Contains("FileStop")) || (c.Name.Contains("Menu")))
                    {
                        c.Enabled = false;
                    }
                }
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
            Form1 f1 = new Form1();
            foreach (Control c in f1.Controls)
            {
                if ((c).Text != "Stop")
                {
                    c.Enabled = false;
                }
            }
        }

        private void btn_ignore_Click(object sender, EventArgs e)
        {
            // TODO: Create a list of processes to ignore. such as System processes
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            MessageBox.Show(Properties.Settings.Default.IgnoreList);
            Properties.Settings.Default.Upgrade();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}