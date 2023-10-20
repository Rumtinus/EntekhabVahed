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
    public partial class Form3 : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd;

        public static Form3 majorform;
        public User user;
        public Form3()
        {
            InitializeComponent();
            majorform = this;

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnback2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2.termform.Show();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (cmbmajor.Text == "" || cmblesson.Text == "")
            {
                MessageBox.Show("Please complete your Class info!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                user.Major = cmbmajor.Text;
                user.Lesson = cmblesson.Text;
                Fillgrid();
                this.Hide();
                Form4 f4 = new Form4();
                f4.Show();
            }

        }
        private void Fillgrid()
        {
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Visual studio\\Samples\\Entekhab Vahed\\Database1.mdf\";Integrated Security=True";
            conn.Open();

            SqlCommand delcmd = new SqlCommand(string.Format("Delete from tblstd where [Student ID]={0}", user.StudentId), conn);
            delcmd.ExecuteNonQuery();
            string q = String.Format("insert into tblstd ([Student ID],firstname,lastname,term,Major,lesson) values ({0},'{1}','{2}',{3},'{4}','{5}')", user.StudentId, user.FirstName, user.LastName, user.Term, user.Major, user.Lesson);
            cmd = new SqlCommand(q, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsave_Click(null, null);

            }
        }
    }
}
