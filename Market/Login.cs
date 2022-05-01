using MarketEntity;
using System;
using System.Collections;
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
    public partial class Login : Form
    {
        SqlConnection connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=MarketApp;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Users WHERE Name = @Mail", connection);
            command.Parameters.AddWithValue("@Mail", LoginMail.Text);
            SqlDataReader reader = command.ExecuteReader();
            List<User> list = new List<User>();
            while (reader.Read())
            {
                User user = new User
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Mail = reader["Mail"].ToString(),
                    Password = reader["Password"].ToString(),
                };
                list.Add(user);
            }
            reader.Close();
            if(list.First().Password == EncryptData.MD5(LoginPassword.Text))
            {

            }
            connection.Close();
        }
    }
}
