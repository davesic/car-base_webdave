using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace car
{
    public partial class Password : Form
    {
        Thread th;
        public Password()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "password1")
            {
                this.Close();
                Application.Exit();
                th = new Thread(admin);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            } else label2.Text = "Error. Incorrect password";
        }
        private void admin()
        {
            Application.Run(new Admin());
        }
    }
}
