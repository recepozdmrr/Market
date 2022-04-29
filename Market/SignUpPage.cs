using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
            
        }
        //Connection between Form and database
        SqlConnection connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=MarketApp;Integrated Security=True");
        private void Login_click(object sender, EventArgs e)
        {
                connection.Open();
                SqlCommand add = new SqlCommand("insert into dbo.Users values(@Name,@LastName,@Mail,@Password)", connection);
                add.Parameters.AddWithValue("@Name", NameBox.Text);
                add.Parameters.AddWithValue("@LastName", LastName.Text);
                add.Parameters.AddWithValue("@Mail", Mail.Text);
                add.Parameters.AddWithValue("@Password", Password.Text);
                
                add.ExecuteNonQuery();
                MessageBox.Show("User is added successfully");
                connection.Close();
        }
    }

}








