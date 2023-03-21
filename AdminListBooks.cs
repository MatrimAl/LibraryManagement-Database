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
        public void Insert(byte[] image)
        {
            conn.Open();
            String querry = "Insert INTO LibraryBooks (BookID, BookName, BookAuthor, BookStock, BookImage) values (@bookid, @bookname, @bookauthor, @bookstock, @bookimage)";
            SqlCommand cmd = new SqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@bookid", bookId.Text);
            cmd.Parameters.AddWithValue("@bookname", bookName.Text);
            cmd.Parameters.AddWithValue("@bookauthor", authorName.Text);
            cmd.Parameters.AddWithValue("@bookstock", bookStock.Text);
            cmd.Parameters.AddWithValue("@bookimage", image);
            cmd.ExecuteNonQuery();
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

        

        private void uploadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg)|*.jpg;*.jpeg", Multiselect = false })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    Insert(ConvertImageToBytes(pictureBox1.Image));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null || row.Cells[4].Value != DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[4].Value.ToString()))   //Check for null reference
                {
                    byte[] toBytes = (byte[])dataGridView1.CurrentRow.Cells[4].Value;
                    pictureBox1.Image = ConvertByteArrayToImage(toBytes);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                   

                }
            }
        }
    }
}
