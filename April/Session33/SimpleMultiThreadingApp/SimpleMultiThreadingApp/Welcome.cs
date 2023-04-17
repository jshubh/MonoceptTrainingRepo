
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMultiThreadingApp
{
    internal class WelcomeForm : Form
    {

        public WelcomeForm()
        {
            this.Text = "Shubh Form";
            this.Width = 500;
            this.Height = 500;
            Button btnHello = new Button();
            btnHello.Text = "Hello";
            btnHello.Click += ((sender, eventArg) =>
            {
                MessageBox.Show("Hello There");

            }
            );
            Button btnPrint = new Button();
            btnPrint.Text = "PrintInfinit";
            btnPrint.Location = new Point(250, 0);
            btnPrint.Click += (sender, eventArg) =>
            {
                PrintInfinit();
              //  DateTime startTime = DateTime.Now;
              //  TimeSpan future = TimeSpan.FromMinutes(.15);
               // while (true)
              //  {
              //      Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
                //}
            };
            Button btnPrintWithThread = new Button();
            btnPrintWithThread.Text = "Non Blocking/Async";
            btnPrintWithThread.Location = new Point(350, 0);
            btnPrintWithThread.Click+=(sender,eventArg)=>
                {
                    Thread t = new Thread(PrintInfinit);
                    t.Start();

            };

            this.Controls.Add(btnHello);
            this.Controls.Add(btnPrint);
            this.Controls.Add(btnPrintWithThread)
;           
            
        }
        void PrintInfinit()
        {
            while(true)
            {
                Console.WriteLine(DateTime.Now.ToString("hh::mm::ss"));
            }
        }
    }
}
