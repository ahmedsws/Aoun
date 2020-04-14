using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace عون
{
    public partial class Form1 : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source = SWS\SQLEXPRESS; Initial Catalog = help; Integrated Security = true");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.Text = "مرحبا بك في برنامج عون";
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(30);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //panel2.Top = button2.Bottom;
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            save s = new save();
            s.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            about a = new about();
            a.Show();
        }

        private void home1_Load(object sender, EventArgs e)
        {
        }

        private void request1_Load(object sender, EventArgs e)
        {
        }

        private void request1_Load_1(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void helpInfo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            tools t = new tools();
            t.Show();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}