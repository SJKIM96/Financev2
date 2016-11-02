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


namespace iFINANCE
{
    public partial class login_screen : Form
    {
        public login_screen()
        {
            InitializeComponent();
        }
        bool textbox1_first = false;
        bool textbox2_first = false;

       

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Password.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(Username.Text))
            {
                MessageBox.Show("Please enter your username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Username.Focus();
                return;
            }

            try
            {
                //Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\kim\Desktop\projects\Finance\database\data.mdf;Integrated Security=True;Connect Timeout=30
                using (dataEntities test = new dataEntities())
                {
                    var a1 = from o in test.Tables // Tables are variable name
                             where o.username == Username.Text && o.password == Password.Text
                             select o;
                    if (a1.SingleOrDefault() != null)
                    {
                        MessageBox.Show("login successful", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        iFINANCE screen = new iFINANCE();
                        screen.Show();
                    }
                    else
                        MessageBox.Show("login was unsuccessful", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception exc)
            {
                ShowDialog();
            }
        }

        private void Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                Password.Focus();
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                Login_button.PerformClick();
        }

       
        private void Username_MouseClick_1(object sender, MouseEventArgs e)
        {
            if(!textbox1_first)
            {
                Username.Text = null;
                textbox1_first = true;
            }
        }

        private void Password_MouseClick(object sender, MouseEventArgs e)
        {
            if(!textbox2_first)
            {
                Password.Text = null;
                textbox2_first = true;
            }
        }
    }
}
