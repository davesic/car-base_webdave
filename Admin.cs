using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace car
{
    public partial class Admin : Form
    {
        Thread th;
        string path = @"C:\Users\webda\source\repos\car\car\cars.txt";
        public Admin()
        {
            InitializeComponent();

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    label1.Text += $"{line}\n";
                }
            }
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            Application.Exit();
            th = new Thread(home);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void home()
        {
            Application.Run(new Form1());
        }
    }
}
