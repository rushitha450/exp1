using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRoom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void ad_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkout c = new checkout();
            c.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminssion a = new adminssion();
            a.ShowDialog();
        }

        private void rentPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rent r = new rent();
            r.ShowDialog();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkout c = new checkout();
            c.ShowDialog();
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
