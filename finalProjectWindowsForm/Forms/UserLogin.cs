using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using finalProjectWindowsForm.Data;
using finalProjectWindowsForm.Forms;
using finalProjectWindowsForm.Models;

namespace finalProjectWindowsForm.Forms
{
    public partial class UserLogin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int left, int top, int right, int bottom, int width, int height);
       private readonly LibraryContext _context;
       

        public UserLogin()
        {
            _context = new LibraryContext();

            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LblUsername.Text))
            {
                MessageBox.Show("Username yazin");
                return;
            }

            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("Şifrə yazın");
                return;
            }

         User user = _context.User.FirstOrDefault(u => u.Username == TxtEmail.Text
                                                    && u.Password == TxtPassword.Text);

            if (user != null)
            {
                Dasboard dashboard = new Dasboard();
                dashboard.Show();


               
                return;
                
            }
            MessageBox.Show("E-poçt və ya şifrə yalnışdır");

            
        }
        

    }
}

