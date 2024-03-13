using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class GivingBook : Form
    {
        public static String username = Login.username;
        public GivingBook()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=Ismail\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True;Pooling=False");

        private void GivingBook_Load(object sender, EventArgs e)
        {
            
            this.givenBooksTableAdapter1.Fill(this.libraryManagementDataSet2.GivenBooks);
            
            this.givenBooksTableAdapter.Fill(this.libraryManagementDataSet1.GivenBooks);
           
            this.libraryBooksTableAdapter.Fill(this.libraryManagementDataSet.LibraryBooks);

        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            checkDatabase(BookID);
            deleteDatabase(BookID);
            LoadData();
        }
        public void LoadData()
        {
            DataTable dt = new DataTable("GivenBooks");
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From GivenBooks where Username=@username", conn);
            adapter.SelectCommand.Parameters.AddWithValue("@username", username);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        public void updateDatabase(String bookId)
        {
            String querry = "UPDATE LibraryBooks SET BookStock = BookStock + 1 Where BookID=@bookid";
            SqlCommand cmd = new SqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@bookid", bookId);
            
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void insertDatabase(String bookId, String bookName, String authorName, byte[] image)
        {
            String querry = "INSERT INTO LibraryBooks (BookID, BookName, BookAuthor, BookStock, BookImage) Values (@bookid, @bookname, @bookauthor, @bookstock, @bookimage)";
            SqlCommand cmd = new SqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@bookid", bookId);
            cmd.Parameters.AddWithValue("@bookname", bookName);
            cmd.Parameters.AddWithValue("@bookauthor", authorName);
            cmd.Parameters.AddWithValue("@bookstock", 1);
            cmd.Parameters.AddWithValue("@bookimage", image);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void deleteDatabase(String bookId) // kullanıcının  kütüphaneye verdiği kitabın, KENDİNDEN silinmesi için
        {
            conn.Open();
            String querry = "DELETE FROM GivenBooks WHERE BookID = @bookid AND Username=@username";
            SqlCommand cmd = new SqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@bookid", bookId);
            cmd.Parameters.AddWithValue("@username", username); // admin yerine kullanıcı adı gelecek
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void checkDatabase(String bookId)
        {
            // check username and bookID colm in GivenBooks database, if it doesnt match then update the LibraryBooks database and insert
            String querry = "Select * From LibraryBooks Where BookID=@bookid";
            SqlCommand cmd = new SqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@bookid", bookId);
            conn.Open();
            SqlCommand check_Data = new SqlCommand("SELECT COUNT(*) FROM [LibraryBooks] WHERE ([BookID] = @bookid)", conn);
            check_Data.Parameters.AddWithValue("@bookid", bookId);
            int UserExist = (int)check_Data.ExecuteScalar();
            if (UserExist > 0)
            {
                updateDatabase(BookID);

            }
            else
            {
                insertDatabase(BookID, BookName, BookAuthor, toBytes);

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BookID = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            BookName = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            BookAuthor = dataGridView1.CurrentRow.Cells[3].Value.ToString();
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
                    bookNameLabel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    authorNameLabel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                }
            }
        }
    }
}
