using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pg
{
    public partial class sr : Form
    {
        string food;
        int share;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\kranthi\source\repos\pg\pg\Database1.mdf;Integrated Security=True");
        public sr()
        {
            InitializeComponent();
        }

        private void sr_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if(op.ShowDialog()==DialogResult.OK)
            {
                imgAdr.Text = op.FileName;
                img.ImageLocation = imgAdr.Text;
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            con.Open();
            string com = "INSERT INTO studentR (name,address,share,mobile,gnumber,food,img,dob,room) VALUES('"+name.Text+"','"+address.Text+"')";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            share = 1;
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            share = 2;
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            share = 3;
        }

        private void veg_CheckedChanged(object sender, EventArgs e)
        {
            food = "veg";
        }

        private void nonveg_CheckedChanged(object sender, EventArgs e)
        {
            food = "Non-veg";
        }

        private void gph_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
