using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace versity
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\SHAIK SAURAB\DOCUMENTS\DB\VERSITY.MDF;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sc = new SqlCommand("insert into STUDENT (STUDENT_NAME,STUDENT_ID,MOBILE_NO,STUDENT_ADDRESS) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "') ", conn);
            sc.ExecuteNonQuery();
            MessageBox.Show("Thank You " + textBox1.Text + " ");
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sc = new SqlCommand("insert into TEACHER (TCH_NAME,ID_NO,MOBILE_NO,TCH_ADDRESS) values('" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "') ", conn);
            sc.ExecuteNonQuery();
            MessageBox.Show("Thank You ");
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sc = new SqlCommand("select USER_,PASS from LOG_IN where USER_='" + textBox9.Text + "'and PASS='" + textBox10.Text + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucessfull ");
                Form2 fm = new Form2();
                fm.Show();

            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            conn.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
