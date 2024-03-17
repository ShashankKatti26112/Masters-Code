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
    public partial class Total : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Admin\Documents\VSS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public Total()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sc1;
            SqlDataReader rd;
            string sql = "select * from Servicedetails where Vehicleno ='" + comboBox1.Text + "'";
        }

    con.Open();
    sc1 = new SqlCommand(sql, con); 
        rd = sc1.ExecuteReader();
    while (rd.Read())
    {
    textBox1.Text = rd.GetValue(2).ToString();
    }
    sc1.Dispose(); 
        con.Close();
    }
    catch (Exception ex)
    {
    MessageBox.Show(ex.ToString());
    }
  
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
        }

        private void Total_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }


        }
    
