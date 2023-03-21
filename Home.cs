using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBooks_Click(object sender, EventArgs e)
        {
            ListBooks listBooks = new ListBooks();
            listBooks.ShowDialog();
        }

        private void profilButton_Click(object sender, EventArgs e)
        {
            ChangePass changePass = new ChangePass();
            changePass.ShowDialog();
        }
    }
}
