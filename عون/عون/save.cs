using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace عون
{
    public partial class save : Form
    {
        public save()
        {
            InitializeComponent();
        }
        Form1 f1 = new Form1();
        DataTable dt;
        private void save_Load(object sender, EventArgs e)
        {
            f1.con.Open();

            SqlCommand cmd = new SqlCommand("select  phone'الرقم', type'نوع الطلب', area'المنطقة' from saved", f1.con);

            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            f1.con.Close();

            dataGridView1.DataSource = dt;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                f1.con.Open();
                if (dataGridView1.CurrentCell.RowIndex > -1)
                {
                    SqlCommand cmd = new SqlCommand("select phone, email, des, type from saved where phone = @phone ", f1.con);
                    cmd.Parameters.AddWithValue("@phone", dt.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[0].ToString());
                    SqlDataReader sdr = cmd.ExecuteReader();

                    if (sdr.Read())
                    {
                        textBox2.Text = sdr["phone"].ToString();
                        textBox1.Text = sdr["email"].ToString();
                        textBox3.Text = sdr["type"].ToString();
                        richTextBox11.Text = sdr["des"].ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                String.Format(" {0} هل انت متاكد من حذف صاحب الرقم ",dt.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[0].ToString()),
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign ,
                false
                );

            if (result == DialogResult.Yes)
            {
                try
                {
                    f1.con.Open();

                    SqlCommand cmd = new SqlCommand("delete from saved where phone = @phone", f1.con);

                    cmd.Parameters.AddWithValue("@phone", dt.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[0].ToString());
                    if (cmd.ExecuteNonQuery() == 1)
                        MessageBox.Show("تم الحذف");
                    else
                        MessageBox.Show("خطأ في الحذف");
                    f1.con.Close();
                }
                catch (SqlException E)
                {
                    MessageBox.Show(E.Message);
                }
            }
          //  if(result == DialogResult.No)

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
