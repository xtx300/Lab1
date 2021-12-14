using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        Point lastPoint;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {

            if(textBox_Login.Text == "Yevheniy" && textBox_Password.Text == "Z")
            {
                MessageBox.Show("Hello, User");
                label_OK.BackColor = Color.Green;
            }
            else if(textBox_Login.Text == "" || textBox_Login.Text == "Enter Login")
            {
                MessageBox.Show("Enter Login");
                label_OK.BackColor = Color.Red;
            }
            else if (textBox_Password.Text == "" || textBox_Password.Text == "Enter Password")
            {
                MessageBox.Show("Enter password");
                label_OK.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Login or password are incorect");
                label_OK.BackColor = Color.Red;
                textBox_Login.Text = "";
                textBox_Password.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
