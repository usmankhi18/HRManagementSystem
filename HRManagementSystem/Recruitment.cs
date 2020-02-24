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

namespace HRManagementSystem
{
    public partial class Recruitment : Form
    {
        public Recruitment()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Recruitment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hrmanageDataSet.recruitment' table. You can move, or remove it, as needed.
            this.recruitmentTableAdapter.Fill(this.hrmanageDataSet.recruitment);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\documents\visual studio 2015\Projects\HRManagementSystem\HRManagementSystem\hrmanage.mdf;Integrated Security=True");
            con.Open();
            string xyz = string.Empty;
            if (radioButton1.Checked)
            {
                xyz = "Freshers";
            }
            else if (radioButton2.Checked)
            {
                xyz = "Experienced";
            }
            try
            {
                String str = "Insert into recruitment(r_through,year_of,inter_date,inter_time,student,type_test,s_select,post,pay,p_charge,f_e) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text  + "','" + textBox6.Text + "','" + comboBox2.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + xyz + "');";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                String str1 = "select max(ID) from recruitment;";
                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Inserted Recruitment Detail SuccessFully..");
                    using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\documents\visual studio 2015\Projects\HRManagementSystem\HRManagementSystem\hrmanage.mdf;Integrated Security=True"))
                    {
                        String str2 = "Select * from recruitment";
                        SqlCommand cmd2 = new SqlCommand(str2, con1);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = new BindingSource(dt, null);
                    }
                    textBox2.Text = "";
                    textBox1.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\documents\visual studio 2015\Projects\HRManagementSystem\HRManagementSystem\hrmanage.mdf;Integrated Security=True");
            con.Open();
            try
            {
                string getcust = "Select r_through,year_of,inter_date,inter_time,student,type_test,s_select,post,pay,p_charge,f_e from recruitment where id='" + Convert.ToInt32(textBox9.Text) + "';";
                SqlCommand cmd = new SqlCommand(getcust, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox1.Text = dr.GetValue(0).ToString();
                    textBox2.Text = dr.GetValue(1).ToString();
                    textBox3.Text = dr.GetValue(2).ToString();
                    textBox4.Text = dr.GetValue(3).ToString();
                    textBox5.Text = dr.GetValue(4).ToString();
                    comboBox1.Text = dr.GetValue(5).ToString();
                    textBox6.Text = dr.GetValue(6).ToString();
                    comboBox2.Text = dr.GetValue(7).ToString();
                    textBox7.Text = dr.GetValue(8).ToString();
                    textBox8.Text = dr.GetValue(9).ToString();
                    if (dr["f_e"].ToString() == "Fresher")
                    {
                        radioButton1.Checked = true;
                    }
                    else
                    {
                        radioButton2.Checked = true;
                    }

                }
                else
                {
                    MessageBox.Show("Invalid Recruitment Id.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\documents\visual studio 2015\Projects\HRManagementSystem\HRManagementSystem\hrmanage.mdf;Integrated Security=True");
            con.Open();
            string job = string.Empty;
            if (radioButton1.Checked)
            {
                job = "Freshers";
            }
            else if (radioButton2.Checked)
            {
                job = "Expereinced";
            }
            try
            {
                string getcust = "update recruitment set r_through='" + textBox1.Text + "',year_of='" + textBox2.Text + "',inter_date='" + textBox3.Text + "',inter_time='" + textBox4.Text + "',student='" + textBox5.Text + "',type_test='" + comboBox1.Text + "',s_select='" + textBox6.Text + "',post='" + comboBox2.Text  + "',pay='" + textBox7.Text + "',p_charge='"+ textBox8.Text +"',f_e='"+ job +"' where id='" + textBox9.Text + "'; ";
                SqlCommand cmd = new SqlCommand(getcust, con);
                cmd.ExecuteNonQuery();
                string str1 = "select max(ID) from recruitment;";
                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Recruitment Data Updated Successfully.");
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    textBox1.Text = "";
                    using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\documents\visual studio 2015\Projects\HRManagementSystem\HRManagementSystem\hrmanage.mdf;Integrated Security=True"))
                    {
                        String str2 = "Select * from recruitment";
                        SqlCommand cmd2 = new SqlCommand(str2, con1);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = new BindingSource(dt, null);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid recruitment Id.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\documents\visual studio 2015\Projects\HRManagementSystem\HRManagementSystem\hrmanage.mdf;Integrated Security=True");
            con.Open();
            try
            {
                string str = "delete from recruitment where id='" + textBox9.Text + "';";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Recruitment Deleted Successfully.");
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                using (con)
                {
                    String str2 = "Select * from recruitment";
                    SqlCommand cmd2 = new SqlCommand(str2, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
