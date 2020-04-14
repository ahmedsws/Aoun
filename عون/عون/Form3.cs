using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;
namespace عون
{
    public partial class Form3 : Form
    {
        Form1 f1 = new Form1();
        
        public Form3()
        {
            InitializeComponent();
      
        }
        DataTable dt;
        private void Form3_Load(object sender, EventArgs e)
        {
            f1.con.Open();

            SqlCommand cmd = new SqlCommand("select  phone'الرقم', type'نوع الطلب', area'المنطقة' from req", f1.con);
            
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            f1.con.Close();

            dataGridView1.DataSource = dt;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* f1.con.Open();
           
            SqlCommand cmd = new SqlCommand("select des from req where area = @area ", f1.con);
            cmd.Parameters.AddWithValue("@area",textBox1.Text);
            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {
                RichTextBox r = new RichTextBox();
                r.Text = sdr["des"].ToString();
                r.Location = new System.Drawing.Point(0, y);
                x = x + x;
                y = y + y;
                r.Size = new System.Drawing.Size(691, 75);
                this.Controls.Add(r);
                
            }
            else
            {
                MessageBox.Show("الطالب غير موجود");
            }

            f1.con.Close();*/
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                f1.con.Open();
                if (dataGridView1.CurrentCell.RowIndex > -1)
                {
                    SqlCommand cmd = new SqlCommand("select des, phone, email, type from req where phone = @phone ", f1.con);
                    cmd.Parameters.AddWithValue("@phone", dt.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[0].ToString());
                    SqlDataReader sdr = cmd.ExecuteReader();

                    if (sdr.Read())
                    {
                       ;
                        textBox2.Text = sdr["phone"].ToString();
                        textBox1.Text = sdr["email"].ToString();
                        textBox3.Text = sdr["type"].ToString();
                        richTextBox11.Text = sdr["des"].ToString();


                        /* RichTextBox r = new RichTextBox();
                         r.Text = sdr["des"].ToString();
                         r.Location = new System.Drawing.Point(0, y);
                         x = x + x;
                         y = y + y;
                         r.Size = new System.Drawing.Size(691, 75);
                         this.Controls.Add(r);*/
                    }
                    else
                    {
                        MessageBox.Show("المحتاج غير موجود");
                    }
                }
                f1.con.Close();
            }
            catch(SqlException E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                f1.con.Open();

                SqlCommand cmd = new SqlCommand("insert into saved(phone, email, type, des, area) values(@phone,@email, @type,  @des, @area)", f1.con);

                cmd.Parameters.AddWithValue("@phone", textBox2.Text);
                cmd.Parameters.AddWithValue("@email", textBox1.Text);
                cmd.Parameters.AddWithValue("@type", textBox3.Text);
                cmd.Parameters.AddWithValue("@des", richTextBox11.Text);            
                cmd.Parameters.AddWithValue("@area", dt.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[2].ToString());


                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("تمت الاضافة");
                else
                    MessageBox.Show("خطأ في البيانات");


                f1.con.Close();
            }

            catch (SqlException E)
            {
                MessageBox.Show("موجود  سابقا");
            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    f1.con.Open();

                    SqlCommand cmd = new SqlCommand("delete from req where phone = @phone", f1.con);

                    cmd.Parameters.AddWithValue("@phone", dt.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[0].ToString());
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("في ميزان حسناتك");
                        f1.con.Close();

                        f1.con.Open();

                        SqlCommand cmd2 = new SqlCommand("delete from saved where phone = @phone", f1.con);

                        cmd2.Parameters.AddWithValue("@phone", dt.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[0].ToString());
                        if (cmd2.ExecuteNonQuery() == 1)
                            f1.con.Close();
                    }
                    else
                        MessageBox.Show("تم التكفل بالحالة");

                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("يجب عليك ان تتعهد بكفالة الحالة");
                }
            }
            catch(SqlException E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void richTextBox11_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void richTextBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}