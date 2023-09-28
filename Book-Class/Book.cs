using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Class
{
    public class Book
    {
        string Title, Author, Publisher;

        public Book(string a, string b, string c)
        {
            Title = a;
            Author = b;
            Publisher = c;

        }
        public void display()
        {
            MessageBox.Show("The title of the book is " + Title + " " + "it was written by " + Author + " " + "and published by " + Publisher);
        }

    }
   
}
