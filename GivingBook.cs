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
        public GivingBook()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=Ismail\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True;Pooling=False");

        private void GivingBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagementDataSet1.GivenBooks' table. You can move, or remove it, as needed.
            this.givenBooksTableAdapter.Fill(this.libraryManagementDataSet1.GivenBooks);
            // TODO: This line of code loads data into the 'libraryManagementDataSet.LibraryBooks' table. You can move, or remove it, as needed.
            this.libraryBooksTableAdapter.Fill(this.libraryManagementDataSet.LibraryBooks);

        }
        public void LoadData()
        {
            DataTable dt = new DataTable("LibraryBooks");
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From LibraryBooks", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        public void updateDatabase(String bookId)
        {
            String querry = "UPDATE TableName SET TableField = TableField + 1 Where BookID=@bookid";
            SqlCommand cmd = new SqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@bookid", bookId);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void insertDatabase(String bookId, String bookName, String authorName, String bookStock, byte[] image)
        {

        }


        public void checkDatabase(String bookId)
        {

            conn.Open();
            SqlCommand check_Book_ID = new SqlCommand("SELECT COUNT(*) FROM [LibraryUsers] WHERE ([BookID] = @bookid)", conn);
            check_Book_ID.Parameters.AddWithValue("@bookid", bookId);
            int BookIdExit = (int)check_Book_ID.ExecuteScalar();
            if (BookIdExit > 0)
            {
                 //update
            }
            else { 
                //insert
            }
            conn.Close();
        }
        public Image ConvertByteArrayToImage(byte[] data)
        {
            System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
            Image img = (Image)converter.ConvertFrom(data);
            return img;
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
                if (row.Cells[4].Value != null || row.Cells[4].Value != DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[4].Value.ToString()))   //Check for null reference doesn't work
                {
                    byte[] toBytes = (byte[])dataGridView1.CurrentRow.Cells[4].Value;
                    pictureBox1.Image = ConvertByteArrayToImage(toBytes);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    bookNameLabel.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    authorNameLabel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                }
            }

        }
    }
}
