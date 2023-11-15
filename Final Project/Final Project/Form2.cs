using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Txtusername.Text == "juan gamis" && (Txtpassword.Text == "12345" || password.Text == "12345"))
            {
                Form1 form1 = new Form1();
                form1.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("anda salah memasukkan username atau password");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ChShowPassword.Checked == true)
            {
                TxtTempPassword.Text = TxtPassword.Text;
                TxtTempPassword.Visible = true;
                TxtPassword.Visible = false;

            }
            else
            {
                TxtTempPassword.Visible = false;
                TxtPassword.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
