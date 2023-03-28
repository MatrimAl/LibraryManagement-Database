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
using static System.Drawing.Image;



namespace LibraryManagement
{
    public partial class AdminListBooks : Form
    {
        public AdminListBooks()
        {
            InitializeComponent();
           
        }
        SqlConnection conn = new SqlConnection(@"Data Source=Ismail\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True;Pooling=False");

        private void Form2_Load(object sender, EventArgs e)
        {
            this.libraryBooksTableAdapter.Fill(this.libraryManagementDataSet.LibraryBooks);

        }
        public void LoadData()
        {
            DataTable dt = new DataTable("LibraryBooks");
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From LibraryBooks", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;  

        }
        public void insertDatabase(String bookId, String bookName, String authorName,String bookStock,byte[] image)
        {
            conn.Open();
            String querry = "INSERT INTO LibraryBooks (BookID, BookName, BookAuthor, BookStock, BookImage) Values (@bookid, @bookname, @bookauthor, @bookstock, @bookimage)";
            SqlCommand cmd = new SqlCommand(querry, conn);
            SqlCommand check_Book_ID = new SqlCommand("SELECT COUNT(*) FROM [LibraryBooks] WHERE ([BookID] = @bookid)", conn);
            cmd.Parameters.AddWithValue("@bookid", bookId);
            cmd.Parameters.AddWithValue("@bookname", bookName);
            cmd.Parameters.AddWithValue("@bookauthor", authorName);
            cmd.Parameters.AddWithValue("@bookstock", bookStock);
            cmd.Parameters.AddWithValue("@bookimage", image);
            check_Book_ID.Parameters.AddWithValue("@bookid", bookId);
            int BookIdExit = (int)check_Book_ID.ExecuteScalar();
            if (BookIdExit > 0)
            {
                MessageBox.Show("This ID already exit.", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }
        public void deleteDatabase(String bookId)
        {
            conn.Open();
            String querry = "DELETE FROM LibraryBooks WHERE BookID = @bookid";
            SqlCommand cmd = new SqlCommand(querry, conn);
            SqlCommand check_Book_ID = new SqlCommand("SELECT COUNT(*) FROM [LibraryUsers] WHERE ([BookID] = @bookid)", conn);
            cmd.Parameters.AddWithValue("@bookid", bookId);
            check_Book_ID.Parameters.AddWithValue("@bookid", bookId);
            int BookIdExit = (int)check_Book_ID.ExecuteScalar();
            if (BookIdExit > 0)
            {
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("This ID does not exit.", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }
        public void updateDatabase(String bookId, String bookName, String authorName, String bookStock, byte[] image)
        {

            conn.Open();
            String querry = "UPDATE LibraryBooks SET BookName=@bookname,BookAuthor=@bookauthor,BookStock=@bookstock,BookImage=@bookimage Where BookID=@bookid";
            SqlCommand cmd = new SqlCommand(querry, conn);
            SqlCommand check_Book_ID = new SqlCommand("SELECT COUNT(*) FROM [LibraryUsers] WHERE ([BookID] = @bookid)", conn);
            cmd.Parameters.AddWithValue("@bookid", bookId);
            cmd.Parameters.AddWithValue("@bookname", bookName);
            cmd.Parameters.AddWithValue("@bookauthor", authorName);
            cmd.Parameters.AddWithValue("@bookstock", bookStock);
            cmd.Parameters.AddWithValue("@bookimage", image);
            
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        byte[] ConvertImageToBytes(Image img) 
        {
            if (img == null) return null;
            else
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }

            }
            
        }
        public System.Drawing.Image ConvertByteArrayToImage(byte[] data)
        {
            System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
            Image img = (Image)converter.ConvertFrom(data);
            return img;
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg)|*.jpg;*.jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            insertDatabase(idBook.Text, nameBook.Text, authorBook.Text, stockBook.Text, ConvertImageToBytes(pictureBox1.Image));
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            updateDatabase(BookID, BookName, BookAuthor, BookStock, toBytes);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        String BookID;
        String BookName;
        String BookAuthor;
        String BookStock;
        byte[] toBytes;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BookID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            BookName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            BookAuthor = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            BookStock = dataGridView1.CurrentRow.Cells[3].Value.ToString();
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
                pictureBox1.Image = ConvertByteArrayToImage(toBytes);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                if (dataGridView1.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
                {
                    
                    using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg)|*.jpg;*.jpeg", Multiselect = false })
                    {
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            pictureBox1.Image = Image.FromFile(ofd.FileName);
                          //  InsertImage(ConvertImageToBytes(pictureBox1.Image), BookID);
                        }
                    }
                }
            }

                
        }

       
    }
}
