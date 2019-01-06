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
    public partial class adminssion : Form
    {
        int rent;
        int f_prince;
        int r_price;
        int n;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ELDHOS AJI\source\repos\SRoom\SRoom\db.mdf"";Integrated Security=True");
        public adminssion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string theDate = DOB.Value.ToString("yyyy-MM-dd");
            char s=' ';
            if (m.Checked == true&&F.Checked==false)
                s = 'm';
            if (F.Checked == true && m.Checked == false)
                s = 'f';
            string sql1 = "SELECT bed_left FROM door WHERE room_no='" + no.Text + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql1, con);
            using (SqlDataReader r = cmd.ExecuteReader())
            {
                while (r.Read())
                {
                    n = Convert.ToInt16(r["bed_left"]);
                }
            }

            con.Close();
            int nm=0;
            
            con.Close();
            int f = rent + f_prince;
            string sql = "INSERT INTO [user](name,mobile,address,gender,g_name,g_number,food_t,room_t,room_no,rent,DOD,up) VALUES('"+name.Text+"','"+int.Parse(mob.Text)+ "','"+add.Text+ "','"+s+"','"+gname.Text+"','"+gmob.Text+"','"+food.Text+"','"+type.Text+"','"+no.Text+"','"+f+"','"+theDate+"','"+cn.Text+"')";
            
            con.Open();
            SqlCommand cmd1 = new SqlCommand(sql,con);
            cmd1.ExecuteNonQuery();
            n--;
            sql = "UPDATE door SET bed_left='"+n+"' WHERE room_no='"+no.Text+"'";
            SqlCommand cmd2 = new SqlCommand(sql, con);
            cmd2.ExecuteNonQuery();
            con.Close();
            string sql3 = "SELECT id FROM [user] WHERE name='" + name.Text + "'";
            con.Open();
            SqlCommand cmd3 = new SqlCommand(sql3, con);
            using (SqlDataReader r = cmd3.ExecuteReader())
            {
                while (r.Read())
                {
                    nm = int.Parse(r["id"].ToString());
                }
            }
            con.Close();
            MessageBox.Show("ID : "+nm+"\nName : "+name.Text+"\n"+"User ID : '"+no.Text+"\n"+"Rent"+f);

        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
           string sql = "SELECT room_no,rent FROM door WHERE room_type='"+type.Text+"' AND no_bed>0";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            using (SqlDataReader r = cmd.ExecuteReader())
            {
                while(r.Read())
                {
                    no.Items.Add(r["room_no"].ToString());
                    rent = int.Parse(r["rent"].ToString());
                }
            }    
            con.Close();
            string m;
            if (food.Text == "Non-veg")
                m = "non";
            else
                m = "veg";
            sql = "SELECT "+food.Text+" FROM food";
            con.Open();
            SqlCommand cmd1 = new SqlCommand(sql, con);
            using (SqlDataReader r = cmd1.ExecuteReader())
            {
                while (r.Read())
                { 
                    f_prince = int.Parse(r[""+food.Text+""].ToString());
                }
            }
            con.Close();
        }

        private void adminssion_Load(object sender, EventArgs e)
        {

        }
    }
}
