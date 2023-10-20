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
    public partial class Form1 : Form
    {


        public User user = new();
        public Form1()
        {
            InitializeComponent();

        }



        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (txtstdid.Text == "" || txtname.Text == "" || txtlastname.Text == "")
            {
                MessageBox.Show("Please complete your information!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {

                user.FirstName = txtname.Text;
                user.LastName = txtlastname.Text;
                user.StudentId = int.Parse(txtstdid.Text);

                f2.user = user;

                f2.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void txtname_TextChanged(object sender, EventArgs e)

        {


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter && txtname.ContainsFocus)
            {
                txtlastname.Focus();
                

            }
            else if (e.KeyCode == Keys.Enter && txtlastname.ContainsFocus)
            {
                txtstdid.Focus();
                
            }
            else if (e.KeyCode == Keys.Enter && txtstdid.ContainsFocus)
            {
                btnenter_Click(null, null);
                
            }
        }


        private void txtstdid_TextChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}