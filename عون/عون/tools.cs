using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace عون
{
    public partial class tools : Form
    {
        Process proc = new Process();
        Form1 f1 = new Form1();
        public tools()
        {
            InitializeComponent();
            this.BackColor = Color.Brown;

            TabPage tab = new TabPage
            {
                Name = "tab",
                Text = "tablet"
            };


            tabControl1.TabPages.Add(tab);
            
            
            /*textBox1.ReadOnly = false;
            textBox1.Cursor = Cursors.Cross;
            textBox1.Enabled = true;
            textBox1.Width = 100;
            textBox1.Height = 100;
            textBox1.PasswordChar = 'h';
            textBox1.Multiline = true;
            //textBox1.MaxLength = 1;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.WordWrap = true;

            button1.FlatStyle = FlatStyle.Popup;
            button1.TextAlign = ContentAlignment.BottomLeft;

            groupBox1.Text = "hey";

            checkBox1.Appearance = Appearance.Normal;
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.TextAlign = ContentAlignment.BottomLeft;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Indeterminate;

            radioButton1.Appearance = Appearance.Button;
            radioButton1.CheckAlign = ContentAlignment.BottomRight;
            radioButton1.TextAlign = ContentAlignment.BottomLeft;


            comboBox2.Items.Add("hello");
            comboBox2.Items.Add("hey");

            comboBox2.Items.Remove("hello");
            comboBox2.Items.AddRange(new string[] {"one","two","three"});
            comboBox2.SelectedItem = "one";
            comboBox2.SelectedIndex = 2;*/
            listBox1.Items.AddRange(new string[] { "محمد", "احمد", "علي" });
            listBox1.SelectionMode = SelectionMode.MultiExtended;

            //  listBox1.Anchor = AnchorStyles.Bottom;


            

           /* button1.FlatStyle = FlatStyle.Flat;
            button1.TextAlign = ContentAlignment.BottomLeft;*/

            richTextBox1.Text = "first";
            richTextBox1.WordWrap = true;
            //richTextBox1.Lines = null;
            richTextBox1.Select(3, 3);
            richTextBox1.SelectionColor = Color.Teal;
            richTextBox1.DetectUrls = true;
            richTextBox1.ShortcutsEnabled = true;
            richTextBox1.EnableAutoDragDrop = true;
            //richTextBox1.ZoomFactor = Single.MaxValue;
            richTextBox1.SelectedText = "rs";
            richTextBox1.SelectionFont = new Font("arial", 10);
            int i = richTextBox1.Lines.Count();

            treeView1.CheckBoxes = true;
            treeView1.ImageList = imageList1;
            treeView1.ItemHeight = 10;
            treeView1.ShowPlusMinus = true;
            treeView1.ShowRootLines = true;

            treeView1.Nodes.Add("n1", "visual studio", 0, 1);
            treeView1.Nodes[0].Nodes.Add("n11", "java", 0, 2);
        }

        private void tools_Load(object sender, EventArgs e)
        {
            
            listBox1.SelectedItem = "احمد";
            notifyIcon1.Icon = SystemIcons.Warning;
            notifyIcon1.Text = "warn";
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(100);

            progressBar1.Maximum = 90;
            progressBar1.Minimum = 10;
            progressBar1.Value = 20;
            progressBar1.Step = 5;

            while (progressBar1.Value < 90)
            {
                progressBar1.Value = progressBar1.Value + progressBar1.Step;
            }

            SqlDataAdapter da = new SqlDataAdapter("select area from req", f1.con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            comboBox3.DataSource = ds.Tables[0];

            comboBox3.DisplayMember = "area";
            comboBox3.ValueMember = "area";

            dataGridView1.DataSource = ds.Tables[0];
            dateTimePicker1.MaxDate = DateTime.Now.AddYears(4);
            dateTimePicker1.Format = DateTimePickerFormat.Long;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";

            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.ShowCheckBox = true;
            /*
             * open
             * sql command
             * datatable 
             * dt.load(exereader);
             * close
             * datasource=dt
             */

        }
       

        Process pros = new Process();
        
        private void button4_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SaveFile("C:\\mk\\hey.txt");
            notifyIcon1.ShowBalloonTip(5);
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            //dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Value = DateTime.Today;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            //Process.Start(e.LinkText);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //richTextBox1.LoadFile("C:\\mk\\hello.txt");
            //proc = Process.Start("firefox.exe");


            /* */
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //richTextBox1.SaveFile("c:\\mk\\hello.txt");
            Process[] pros = Process.GetProcesses();

            string o = "";
            foreach (Process pross in pros)
            {
                //o = o + pross.ProcessName;

                if (pross.ProcessName == "firefox")
                {
                    pross.Kill();
                }
            }

            //MessageBox.Show(o);

            // Form2 f = new Form2();
            // f.Show();
        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("C:\\mk\\dd");
        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

            toolTip1.ToolTipTitle = "اهلا";

            toolTip1.IsBalloon = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pros = Process.Start("firefox.exe");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(folderBrowserDialog1.SelectedPath + "C:\\mk\\hey.txt");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void search_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select namee from req where phone = @phone", f1.con);
            da.SelectCommand.Parameters.AddWithValue("@phone", textBox1.Text);
            DataSet ds = new DataSet();
            da.Fill(ds);
            
            if (ds.Tables[0].Rows.Count > 0)
            {
                textBox2.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            else
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("update req set namee = @namee where phone = @phone", f1.con);
            //da.SelectCommand.Parameters.AddWithValue("@phone", textBox1.Text);
           
            DataSet ds = new DataSet();
            da.Fill(ds);



            /*try {
                f1.con.Open();
                SqlCommand cmd = new SqlCommand("update req set namee = @namee where phone = @phone", f1.con);
                cmd.Parameters.AddWithValue("@namee", textBox2.Text);
                cmd.Parameters.AddWithValue("@phone", textBox1.Text);


                if (cmd.ExecuteNonQuery() == 1) 
                { }
                f1.con.Close();
            }
            catch(SqlException E)
            {
                MessageBox.Show(E.Message);
            }*/

            }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = SWS\SQLEXPRESS; Initial Catalog = help; Integrated Security = true");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into req(phone) values (@phone)", con);
                cmd.Parameters.AddWithValue("@phone", textBox1.Text);
                if (cmd.ExecuteNonQuery() == 1)
                {

                }
                con.Close();
            }
            catch(Exception E)
            {
                Console.WriteLine(E.Message);
            }

            /*SqlConnection con = new SqlConnection(@"Data Source = SWS\SQLEXPRESS; Initial Catalog = help; Integrated Security = true");


             SqlDataAdapter da = new SqlDataAdapter("select namee from req where phone = @phone",con);
             da.SelectCommand.Parameters.AddWithValue("@phone", textBox1.Text);

             DataSet ds = new DataSet();
             da.Fill(ds);

             if(ds.Tables[0].Rows.Count == 0)
             {

             }
             else
             {
                 textBox2.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
             }*/

            /*
             * with connection
             * con.Open();
            SqlCommand cmd = new SqlCommand("select namee from req where phone = @phone ", con);
            cmd.Parameters.AddWithValue("@phone", textBox1.Text);
            SqlDataReader sdr = cmd.ExecuteReader();


            if (sdr.Read())
                textBox2.Text = sdr["namee"].ToString();

            con.Close();
            */

            
           


        }
    }
}
