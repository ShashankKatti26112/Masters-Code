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
    public partial class Update_form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Admin\Documents\VSS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public Update_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
           SqlCommand cmd = new SqlCommand("UPDATE serviceDetails SET servicecharges=@a1 where ServiceID=@a2", con);
            cmd.Parameters.Add("a1", textBox2.Text); 
            cmd.Parameters.Add("a2", textBox1.Text); 
            cmd.ExecuteNonQuery(); con.Close();
            MessageBox.Show("Details were added to the database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from serviceDetails", con); DataTable dt = new DataTable();
            sda.Fill(dt); dataGridView1.DataSource = dt; con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Total t = new Total();
            t.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
