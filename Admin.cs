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

namespace car
{
    public partial class Admin : Form
    {
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
    }
}
