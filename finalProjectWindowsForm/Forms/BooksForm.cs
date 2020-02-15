using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using finalProjectWindowsForm.Data;
using finalProjectWindowsForm.Models;

namespace finalProjectWindowsForm.Forms
{
    public partial class BooksForm : Form
    {
        private LibraryContext _libraryContext;
        private Book _selectedBook;
        public BooksForm()
        {

            InitializeComponent();
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            tbBookID.Enabled = false;

            _libraryContext = new LibraryContext();
        }
        private void BookForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagement01DataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter1.Fill(this.dataSet21.Books);

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Book newBook = new Book()
            {
                BookName = TbName.Text,
                BookPrice = Convert.ToSingle(TbPrice.Text),
                BookGenre = TbGenre.Text,
                PublisherName =TbPublisher.Text
        };

            _libraryContext.Book.Add(newBook);
            _libraryContext.SaveChanges();

            this.booksTableAdapter1.Fill(this.dataSet21.Books);


        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _selectedBook.BookName = TbName.Text;
            _selectedBook.BookGenre = TbGenre.Text;
            _selectedBook.PublisherName = TbPublisher.Text;
            _selectedBook.BookPrice = Convert.ToSingle(TbPrice.Text);

            _libraryContext.SaveChanges();

            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            this.booksTableAdapter1.Fill(this.dataSet21.Books);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            _libraryContext.Book.Remove(_selectedBook);
            _libraryContext.SaveChanges();

            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            this.booksTableAdapter1.Fill(this.dataSet21.Books);
        }

        private void DgvBookCrud_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _selectedBook = _libraryContext.Book.Find(DgvBookCrud.Rows[e.RowIndex].Cells[0].Value);

            tbBookID.Text = _selectedBook.BookID.ToString();
            TbName.Text = _selectedBook.BookName;
            TbGenre.Text = _selectedBook.BookGenre;
            TbPublisher.Text = _selectedBook.PublisherName;
            TbPrice.Text = _selectedBook.BookPrice.ToString();

            BtnUpdate.Enabled = true;
            BtnDelete.Enabled = true;
        }

        private void TbPublisher_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
