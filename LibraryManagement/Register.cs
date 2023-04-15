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

namespace LibraryManagement
{
    public partial class Register : Form
    {
        public Register()
        {
            
            InitializeComponent();
        }

        private void registerButtonReg_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=Ismail\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True;Pooling=False");
            conn.Open();
            String querry = "INSERT INTO LibraryUsers (username, password) values (@username, @password)";
            SqlCommand cmd = new SqlCommand(querry, conn);
            DataTable tbl = new DataTable();  
            String usernameSearch = usernameTextReg.Text;
            if (passwordAgainTextReg.Text == "" || passwordTextReg.Text == "" || usernameTextReg.Text == "")
            {
                MessageBox.Show("Please fill all field.", null, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (passwordTextReg.Text == passwordAgainTextReg.Text)
            {
                SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM [LibraryUsers] WHERE ([username] = @username)", conn);
                check_User_Name.Parameters.AddWithValue("@username", usernameTextReg.Text);
                int UserExist = (int)check_User_Name.ExecuteScalar();
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = usernameTextReg.Text;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = passwordTextReg.Text;

                if (UserExist > 0)
                {
                    MessageBox.Show("failed", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("correct", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("The passwords do not match.", null, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void loginButtonReg_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();

            loginForm.Show();
            this.Hide();
        }

        private void usernameTextReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
