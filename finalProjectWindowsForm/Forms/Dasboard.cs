using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProjectWindowsForm.Forms
{
    public partial class Dasboard : Form
    {
       
        public Dasboard()
        {
            InitializeComponent();
        }

        private void Ext_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void BtnPerson_Click(object sender, EventArgs e)
        {
            Kecid.Controls.Clear();
            PersonForm person = new PersonForm();
            person.TopLevel = false;
            Kecid.Controls.Add(person);
            person.Show();
        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            Kecid.Controls.Clear();
            BooksForm book = new BooksForm();
            book.TopLevel = false;
            Kecid.Controls.Add(book);
            book.Show();
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            Kecid.Controls.Clear();
            Order order = new Order();
            order.TopLevel = false;
            Kecid.Controls.Add(order);
            order.Show();
        }
    }
}
