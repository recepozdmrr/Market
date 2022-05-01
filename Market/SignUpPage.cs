using MarketEntity;
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
        //SqlConnection connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=MarketApp;Integrated Security=True");
        SqlConnection connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=MarketApp;Integrated Security=True");
        private void Login_click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Users WHERE Name = @Mail", connection);
            command.Parameters.AddWithValue("@Mail", Mail.Text);
            SqlDataReader reader = command.ExecuteReader();
            List<User> list = new List<User>();
            while (reader.Read())
            {
                User user = new User
                {
                    Mail = reader["Mail"].ToString(),
                };
                list.Add(user);
            }
            connection.Close();

            if (Password1.Text == Password2.Text && NameBox.Text != "" && LastName.Text != "" && Mail.Text != "" && Password1.Text != "" && list.Count() != 1)
            {
                connection.Open();
                SqlCommand add = new SqlCommand("insert into dbo.Users values(@Name,@LastName,@Mail,@Password)", connection);
                add.Parameters.AddWithValue("@Name", NameBox.Text);
                add.Parameters.AddWithValue("@LastName", LastName.Text);
                add.Parameters.AddWithValue("@Mail", Mail.Text);
                add.Parameters.AddWithValue("@Password", EncryptData.MD5(Password1.Text));

                add.ExecuteNonQuery();
                MessageBox.Show("User is added successfully");
                
                connection.Close();
                this.Close();
                MainPage Check = new MainPage();
                Check.Show();
            }
            else if(list.Count() == 1)
            {
                MessageBox.Show("Mail is already exist !");
            }
            else if(Password1.Text != Password2.Text)
            {
                MessageBox.Show("Passwords does not match !");
            }
            else
            {
                MessageBox.Show("Check all empty fields !");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}








