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
namespace SRoom
{
    public partial class checkout : Form
    {
        int Rent;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ELDHOS AJI\source\repos\SRoom\SRoom\db.mdf"";Integrated Security=True");

        public checkout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql3 = "SELECT * FROM [user] WHERE id='" + int.Parse(id.Text) + "'";
            con.Open();
            SqlCommand cmd3 = new SqlCommand(sql3, con);
            using (SqlDataReader r = cmd3.ExecuteReader())
            {
                while (r.Read())
                {
                    l1.Text = "Name : " + r["name"].ToString();
                    l2.Text = "Room No: " + r["room_no"].ToString();
                    l3.Text = "Rent : " + r["rent"].ToString();
                    Rent = int.Parse(r["rent"].ToString());
                }
            }
            con.Close();
            int k = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [user] WHERE Id='" + int.Parse(id.Text) + "'", con);
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    k++;
                }
            }
            con.Close();
            if (k > 0)
            {
                gb.Show();

            }
            else
                MessageBox.Show("ID not found");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string theDate = da.Value.ToString("yyyy-MM-dd");
            string sql = "DELETE FROM [user] WHERE id='"+id.Text+"'";
            con.Open();
            SqlCommand cmd1 = new SqlCommand(sql, con);
            cmd1.ExecuteNonQuery();
            con.Close();
           
            this.Close();
        }

        private void checkout_Load(object sender, EventArgs e)
        {
            gb.Hide();
        }
    }
}
