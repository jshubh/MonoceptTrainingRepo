using Aspose.Pdf.Facades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form = System.Windows.Forms.Form;

namespace ConsoleWinFormCoreApp
{
    internal class WelcomeForm :Form
    {
        
        public WelcomeForm()
        {
            this.Text = "Shubh Form";
            this.Width = 500;
            this.Height = 500;
            Button btnHello = new Button();
            btnHello.Text = "Hello";
            btnHello.Click += GoodListner;
            btnHello.Click += DevilListener;
            this.Controls.Add(btnHello);

        }
        public void GoodListner(object sender,EventArgs e)
        {
            Console.WriteLine("God is Listeneing");
        }
        public void DevilListener(object sender,EventArgs e)
        {
            Console.WriteLine("Devil is listener");
        }
    }
}
