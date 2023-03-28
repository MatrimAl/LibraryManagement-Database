using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagement
{
    public partial class TakingBook : Form
    {
        Login login = new Login();
        public static String username = Login.username;
        public TakingBook() 
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            DataTable dt = new DataTable("LibraryBooks");
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From LibraryBooks", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void ListBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagementDataSet.LibraryBooks' table. You can move, or remove it, as needed.
            this.libraryBooksTableAdapter.Fill(this.libraryManagementDataSet.LibraryBooks);

        }
        SqlConnection conn = new SqlConnection(@"Data Source=Ismail\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True;Pooling=False");
      
        public void insertDatabase(String bookID, String bookName, String bookAuthor, byte[] image)
        {
            //insert to GivenBooks table
            conn.Open();

            String querry = "INSERT INTO GivenBooks (Username, BookID, BookName, BookAuthor, BookImage) Values (@username, @bookid, @bookname, @bookauthor, @bookimage)";
            SqlCommand cmd = new SqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@bookid", bookID);
            cmd.Parameters.AddWithValue("@bookname", bookName);
            cmd.Parameters.AddWithValue("@bookauthor", bookAuthor);
            cmd.Parameters.AddWithValue("@bookimage", image);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.ExecuteNonQuery();
            conn.Close();


        }

        public void updateDatabase(String bookID)
        {
            conn.Open();

            String querry2 = "UPDATE LibraryBooks SET BookStock = BookStock - 1 Where BookID=@bookid";
            SqlCommand cmd2 = new SqlCommand(querry2, conn);
            cmd2.Parameters.AddWithValue("@bookid", bookID);
            cmd2.ExecuteNonQuery();
            conn.Close();
        }
        public void checkDatabase(String bookId) 
        {
            // if username and bookid is not match, insert to database selected book
            // if username and bookid is match, update database selected book
            String querry = "Select * From GivenBooks Where BookID=@bookid and Username=@username";
            SqlCommand cmd = new SqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@bookid", bookId);
            cmd.Parameters.AddWithValue("@username", username);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("You have already this book.");
                conn.Close();


            }
            else
            {
                conn.Close();
                insertDatabase(BookID, BookName, BookAuthor, toBytes);
                updateDatabase(BookID);
                LoadData();
            }
           


        }
        public Image ConvertByteArrayToImage(byte[] data)
        {
            System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
            Image img = (Image)converter.ConvertFrom(data);
            return img;
        }
        String BookID;
        String BookName;
        String BookAuthor;
        byte[] toBytes;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BookID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            BookName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            BookAuthor = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if ((byte[])dataGridView1.CurrentRow.Cells[4].Value == null)
            {
                toBytes = null;
            }
            else
            {
                toBytes = (byte[])dataGridView1.CurrentRow.Cells[4].Value;
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null || row.Cells[4].Value != DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[4].Value.ToString()))   //Check for null reference doesn't work
                {
                    byte[] toBytes = (byte[])dataGridView1.CurrentRow.Cells[4].Value;
                    pictureBox1.Image = ConvertByteArrayToImage(toBytes);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    bookLabel.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    authorLabel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                }
            }
            
        }

        private void takeBook_Click(object sender, EventArgs e)
        {
            checkDatabase(BookID);
        }
    }
}
