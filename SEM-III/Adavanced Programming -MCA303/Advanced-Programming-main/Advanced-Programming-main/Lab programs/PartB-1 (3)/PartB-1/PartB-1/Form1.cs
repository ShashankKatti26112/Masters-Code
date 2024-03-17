using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PartB_1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Admin\Documents\VSS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("insert into Servicedetails (ServiceId,Vehicleno,Servicedetails,IdVehicaltype,Servicecharges)values (" + sid.Text + ",'" + vno.Text + "','" + textBox3.Text + "'," + textBox4.Text + ","+textBox1.Text+")", con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
           MessageBox.Show("Details were added to the database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GetV()
        {
            con.Open();
            return con.Open();
        }

        private void button2_Click(object sender, EventArgs e, void v)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from Servicedetails", con); 
            DataTable dt = new DataTable();
            sda.Fill(dt); 
            dataGridView1.DataSource = dt; 
            con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            sid.Clear();
            vno.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Update_form uf = new Update_form();
            uf.Show();
            //Show.uf();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
