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
        public void Insert(String bookId, String bookName, String authorName,String bookStock)
        {
            conn.Open();
            String querry = "UPDATE LibraryBooks SET BookID = @bookid , BookName =  @bookname, BookAuthor = @bookauthor, BookStock = @bookstock Where BookID = @bookid , BookName =  @bookname, BookAuthor = @bookauthor, BookStock = @bookstock ";
            SqlCommand cmd = new SqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@bookid", bookId);
            cmd.Parameters.AddWithValue("@bookname", bookName);
            cmd.Parameters.AddWithValue("@bookauthor", authorName);
            cmd.Parameters.AddWithValue("@bookstock", bookStock);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void InsertImage(byte[] image, String BookID)
        {
            conn.Open();
            String querry = "UPDATE LibraryBooks SET BookImage = @bookimage Where BookID = @bookid";
            SqlCommand cmd = new SqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@bookid", BookID);
            cmd.Parameters.AddWithValue("@bookimage", image);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public Image ConvertByteArrayToImage(byte[] data)
        {
            System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
            Image img = (Image)converter.ConvertFrom(data);
            return img;
        }

        

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg)|*.jpg;*.jpeg", Multiselect = false })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    //InsertImage(ConvertImageToBytes(pictureBox1.Image));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Insert();
            LoadData();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String BookID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String BookName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            String BookAuthor = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            String BookStock = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            String BookImage = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Insert(BookID, BookName, BookAuthor, BookStock);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (dataGridView1.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
                {
                    using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg)|*.jpg;*.jpeg", Multiselect = false })
                    {
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            pictureBox1.Image = Image.FromFile(ofd.FileName);
                            InsertImage(ConvertImageToBytes(pictureBox1.Image), BookID);
                        }
                    }
                }
            }

                
        }

        
    }
}
