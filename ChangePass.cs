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
    public partial class ChangePass : Form
    {
        public static String username = Login.username;
        public ChangePass()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=Ismail\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True;Pooling=False");
        private void sumbitButton_Click(object sender, EventArgs e)
        {
            

            String querry = "UPDATE LibraryUsers SET password = @password Where username = @username";
            SqlCommand cmd = new SqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", newPassword.Text);
            if (newPassword.Text == newPasswordAgain.Text)
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else {
                MessageBox.Show("The passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
           
        }
    }
}
