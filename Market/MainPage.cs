using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUpPage Check = new SignUpPage();
            Check.Show();
            Hide();
        }
        private void loginMain_Click(object sender, EventArgs e)
        {
            Login Check = new Login();
            Check.Show();
            Hide();
        }
    }
}
