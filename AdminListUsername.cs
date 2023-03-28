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
    public partial class AdminListUsername : Form
    {
        public AdminListUsername()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=Ismail\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True;Pooling=False");
        public void LoadData()
        {
            DataTable dt = new DataTable("GivenBooks");
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From GivenBooks", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void AdminListUsername_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagementDataSet2.GivenBooks' table. You can move, or remove it, as needed.
            this.givenBooksTableAdapter.Fill(this.libraryManagementDataSet2.GivenBooks);

        }
    }
}
