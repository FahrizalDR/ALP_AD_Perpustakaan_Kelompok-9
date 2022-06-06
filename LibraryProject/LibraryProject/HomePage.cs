using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            HomeDisplay homeDisplay = new HomeDisplay();
            homeDisplay.MdiParent = this;
            homeDisplay.Show();           
        }   

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            AddBook addBook = new AddBook();
            addBook.MdiParent = this;
            addBook.Show();
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGenre addGenre = new AddGenre();
            addGenre.MdiParent = this;
            addGenre.Show();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMember addMember = new AddMember();
            addMember.MdiParent = this;
            addMember.Show();
        }        

        private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowBook borrowBook = new BorrowBook();
            borrowBook.MdiParent = this;
            borrowBook.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            returnBook.MdiParent = this;
            returnBook.Show();
        }

        private void removeBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveBook removeBook = new RemoveBook();
            removeBook.MdiParent = this;
            removeBook.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeDisplay homeDisplay = new HomeDisplay();
            homeDisplay.MdiParent = this;
            homeDisplay.Show();
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAuthor addAuthor = new AddAuthor();
            addAuthor.MdiParent = this;
            addAuthor.Show();
        }

        private void publisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPublisher addPublisher = new AddPublisher();
            addPublisher.MdiParent = this;
            addPublisher.Show();            
        }
    }
}
