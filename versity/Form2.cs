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
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\SHAIK SAURAB\DOCUMENTS\DB\VERSITY.MDF;Integrated Security=True;Connect Timeout=30");
        public Form2()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;

            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from STUDENT", conn);
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                dataGridView1.DataSource = bsource;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from TEACHER", conn);
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                dataGridView1.DataSource = bsource;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sc = new SqlCommand("insert into LOG_IN values('" + textBox6.Text + "','" + textBox7.Text + "') ", conn);
            sc.ExecuteNonQuery();
            MessageBox.Show("Thank You " + textBox1.Text + " ");
            conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from LOG_IN", conn);
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                dataGridView1.DataSource = bsource;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            conn.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
