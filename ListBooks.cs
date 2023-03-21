using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagement
{
    public partial class ListBooks : Form
    {
        public ListBooks() 
        {
            InitializeComponent();
        }

        private void ListBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagementDataSet.LibraryBooks' table. You can move, or remove it, as needed.
            this.libraryBooksTableAdapter.Fill(this.libraryManagementDataSet.LibraryBooks);

        }
        public Image ConvertByteArrayToImage(byte[] data)
        {
            System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
            Image img = (Image)converter.ConvertFrom(data);
            return img;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
    }
}
