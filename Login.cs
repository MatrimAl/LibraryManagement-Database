using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagement
{
    public partial class Login : Form
    {
        public string username;

        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=Ismail\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True;Pooling=False");

        private void loginButton_Click(object sender, EventArgs e)
        {
            username = usernameTextBox.Text;
            conn.Open();
            String querry = "SELECT * FROM LibraryUsers WHERE username = @username and password = @password ";
            SqlCommand cmd = new SqlCommand(querry, conn);
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = usernameTextBox.Text;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = passwordTextBox.Text;

            SqlDataReader reader = cmd.ExecuteReader();
            {
                if (username == "admin" && passwordTextBox.Text == "admin")
                {
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                    this.Hide();
                    conn.Close();
                }
                else if (reader.Read())
                {
                    
                    Home homePage = new Home();
                    homePage.Show();
                    conn.Close();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            conn.Close();
            registerForm.Show();
            this.Hide();    
        }
    }
}
