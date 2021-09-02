using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DELL-PC;Initial Catalog=employee;Integrated Security=True");
        SqlCommand cmd;

        DataTable dt = new DataTable();
        SqlDataReader dr;
        
        public Form1()
        {
      
            InitializeComponent();
            lood();
        }

        // اسم السرفر +اسم الداتا بيز +نوع الحمايه
        
        
     
 void lood(){
     dt.Clear();
     cmd = new SqlCommand("Select * from NEW", con); con.Open();
    dr = cmd.ExecuteReader();
    dt.Load(dr);
    dataGridView1.DataSource = dt;
    dataGridView1.Columns[0].HeaderText = "ID";
    //dataGridView1.Columns[0].Width = 50;
    con.Close();  
        
        
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            BindingContext[dt].Position = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into NEW (ID,employeename,employeephone,employeeaddress,employeeemail) values(" + (dt.Rows.Count + 1) + ",'" + textBox1.Text + "' ,'" + textBox2.Text + "','" + textBox3.Text + "' ,'" + textBox4.Text + "'  ) ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            lood();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("UPDATE NEW SET EMPLOYEENAME='" + textBox1.Text + "',EMPLOYEEPHONE='" + textBox2.Text + "',EMPLOYEEADDRESS='" + textBox3.Text + "',EMPLOYEEEMAIL='" + textBox4.Text + "' WHERE ID=" + dataGridView1.SelectedRows[0].Cells[0].Value + "", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            lood();

        }

        private void button1_Click(object sender, EventArgs e)
        {
                        //DialogResult dr;
                        cmd = new SqlCommand("DELETE FROM NEW WHERE id="+dataGridView1.SelectedRows[0].Cells[0].Value+"",con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        lood();
            //}}
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BindingContext[dt].Position = dt.Rows.Count - 1;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            BindingContext[dt].Position -=1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            BindingContext[dt].Position+= 1;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if(radioButton3.Checked==true){
                dt.Clear();
                cmd = new SqlCommand("select * from new where employeename like '%"+textBox5.Text+"%'",con);
                con.Open();
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                con.Close();

            }
else if(radioButton1.Checked==true){


    dt.Clear();
    cmd = new SqlCommand("select * from new where employeephone like '%" + textBox5.Text + "%'", con);
    con.Open();
    dr = cmd.ExecuteReader();
    dt.Load(dr);
    con.Close();





}

            else if (radioButton2.Checked==true)
            {


                dt.Clear();
                cmd = new SqlCommand("select * from new where employeeaddress like '%" + textBox5.Text + "%'", con);
                con.Open();
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                con.Close();





            }



            else if (radioButton4.Checked == true)
            {


                dt.Clear();
                cmd = new SqlCommand("select * from new where employeeemail like '%" + textBox5.Text + "%'", con);
                con.Open();
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                con.Close();





            }

            else {

                textBox5.Clear();
            
            
            }

        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

    }}

