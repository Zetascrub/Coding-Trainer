using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProcessMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Programming Trainer";
            Console.SetWindowSize(50, 10);
            Console.SetBufferSize(50, 10);
            Program temp = new Program();
            temp.checkprogress();
        }

        void checkprogress()
        {

            while (true)
            {
                Process[] processlist = Process.GetProcesses();
                foreach (Process theprocess in processlist)
                {
                    if (theprocess.ProcessName == "notepad")
                    {
                        Console.Write("Found Open Game\n");
                        Console.Write("Force closing Game\n");
                        Thread.Sleep(2000);
                        theprocess.Kill();
                        Console.Write("You need to program some more to allow game time\n");
                        Console.Write("Coding time remaining: " + time_programming().ToString() + " Hours");
                    }
                }
                Thread.Sleep(3000);
            }
        }

        int time_programming()
        {
            return 4;
        }
    }
}
