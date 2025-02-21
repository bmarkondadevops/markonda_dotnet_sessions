using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAsynchronousApp.Services;

namespace WinFormsAsynchronousApp
{
    public partial class MyForm : Form
    {
        private PrintService _printService;
        public MyForm()
        {
            _printService = new PrintService();
            InitializeComponent();
        }

        private void MyForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calling username");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            // Get input values from text boxes
            string username = textBox1.Text;
            //MessageBox.Show(username);
            string password = textBox2.Text;
            //MessageBox.Show(password);

            // Simple authentication logic (replace with actual authentication mechanism)
            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hide this form and show another form or perform some action
                this.Hide();
                new MyForm().Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Replace this with your actual authentication logic
            // For example:
            return username == "markonda" && password == "password";
        }


        private void btnPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("calling password");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
