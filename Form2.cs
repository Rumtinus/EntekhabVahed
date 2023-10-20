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
using System.Xml.Linq;

namespace Entekhab_Vahed
{

    public partial class Form2 : Form
    {
        public static Form2 termform;

        public User user;


        public Form2()
        {

            InitializeComponent();
            termform = this;


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblwell.Text = "Wellcome " + user.FirstName + " " + user.LastName + "!";

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();

            f2.Show();


        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (cmbterm.Text == "")
            {
                MessageBox.Show("Please select your Term!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                user.Term = int.Parse(cmbterm.Text);



                Form3 f3 = new Form3();
                f3.user = user;
                f3.Show();
                this.Hide();
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnnext_Click(null,null);

            }
        }
    }
}
