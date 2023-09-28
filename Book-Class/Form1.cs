using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            string Title = txtTitle.Text;
            string Author = txt_Author.Text;
            string Publisher = txt_Publisher.Text;

            Book obj = new Book(Title, Author, Publisher);
            obj.display();
        }
    }
}
