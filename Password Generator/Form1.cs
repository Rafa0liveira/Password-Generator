using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Password Generator", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtvisor.Text = "";
            txtChar.Text = "";
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            int q = 0;
            
            string PossibleCharacters = "ABCDEFGHIJKLMNOPRSTUVWXYZ" +
                  "ABCDEFGHIJKLMNOPRSTUVWXYZ".ToLower() + "0123456789" + "!#%&/@";
            
            Random random = new Random();
            int picked = 0;
            StringBuilder password = new StringBuilder();

            if(txtChar.Text == "")
            {
                MessageBox.Show("Please enter the number of characters.", "Password Generator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
                q = int.Parse(txtChar.Text);
            for (int i = 0; i < q; i++)
            {
                picked = random.Next(0, PossibleCharacters.Length -1);
                password.Append(PossibleCharacters[picked]);
            }
            txtvisor.Text = password.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtChar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

