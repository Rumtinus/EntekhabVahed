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
using Entekhab_Vahed.Dto;

namespace Entekhab_Vahed
{

    public partial class Form4 : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public static Form4 resultform;
        public Form4()
        {
            InitializeComponent();
            resultform = this;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
        }

        private void btnback3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3.majorform.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Visual studio\\Samples\\Entekhab Vahed\\Database1.mdf\";Integrated Security=True";
            conn.Open();
            Fillgrid();
        }
        private void btnexit2_Click(object sender, EventArgs e)
        {

        }

        private void btnexit2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Fillgrid(string s = "Select * from Tblstd")
        {
            cmd.CommandText = s;
            cmd.Connection = conn;
            adapter.SelectCommand = cmd;
            adapter.Fill(ds, "T1");
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataBindings.Add("datasource", ds, "T1");


        }
    }
}
