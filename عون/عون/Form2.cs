using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace عون
{
    public partial class Form2 : Form
    {

        //public SqlConnection con = new SqlConnection(@"Data Source = SWS\SQLEXPRESS; Initial Catalog = help; Integrated Security = true");

        Form1 f1 = new Form1();

        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                try
                {
                    f1.con.Open();

                    SqlCommand cmd = new SqlCommand("insert into req( namee, des, phone, email, type, area) " +
                                                    "values( @namee, @des, @phone, @email,@type, @area )", f1.con);


                    cmd.Parameters.AddWithValue("@namee", textBox1.Text);
                    cmd.Parameters.AddWithValue("@des", richTextBox11.Text);
                    // cmd.Parameters.AddWithValue("@picture", pictureBox1.Image);
                    cmd.Parameters.AddWithValue("@phone", String.Format("{0:0000000000}", Convert.ToInt32(textBox2.Text)).ToString());
                    cmd.Parameters.AddWithValue("@email", textBox3.Text);
                    cmd.Parameters.AddWithValue("@type", comboBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@area", textBox4.Text);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show(" نسأل الله أن تحصل على المساعدة في اقرب وقت. بياناتك الشخصية لن تظهر لاحد",
                            "تمت تعبئة طلبك",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading,
                            false
                            ) ;
                        
                    }
                    else
                        MessageBox.Show("خطأ في البيانات");


                    f1.con.Close();
                }

                catch (SqlException E)
                {
                    MessageBox.Show("موجود سابقا");
                }

                finally
                {
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("الرجاء ادخال رقم هاتفك");
            }
        }

        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"c:\";

            openFileDialog1.Filter = "JPG FILES | *.jpg | png | *.png";

            openFileDialog1.FilterIndex = 2;

            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }


        }
    }
}