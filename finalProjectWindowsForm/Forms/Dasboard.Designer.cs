namespace finalProjectWindowsForm.Forms
{
    partial class Dasboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dasboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnBuy = new System.Windows.Forms.Button();
            this.BtnBook = new System.Windows.Forms.Button();
            this.BtnPerson = new System.Windows.Forms.Button();
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.BtnAdmin);
            this.panel1.Controls.Add(this.BtnBook);
            this.panel1.Controls.Add(this.BtnBuy);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BtnPerson);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 111);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(943, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 501);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(724, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // BtnBuy
            // 
            this.BtnBuy.Location = new System.Drawing.Point(380, 46);
            this.BtnBuy.Name = "BtnBuy";
            this.BtnBuy.Size = new System.Drawing.Size(137, 52);
            this.BtnBuy.TabIndex = 3;
            this.BtnBuy.Text = "Buy";
            this.BtnBuy.UseVisualStyleBackColor = true;
            // 
            // BtnBook
            // 
            this.BtnBook.Location = new System.Drawing.Point(228, 46);
            this.BtnBook.Name = "BtnBook";
            this.BtnBook.Size = new System.Drawing.Size(131, 52);
            this.BtnBook.TabIndex = 2;
            this.BtnBook.Text = "Book";
            this.BtnBook.UseVisualStyleBackColor = true;
            this.BtnBook.Click += new System.EventHandler(this.BtnBook_Click);
            // 
            // BtnPerson
            // 
            this.BtnPerson.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnPerson.FlatAppearance.BorderSize = 0;
            this.BtnPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPerson.Location = new System.Drawing.Point(540, 46);
            this.BtnPerson.Name = "BtnPerson";
            this.BtnPerson.Size = new System.Drawing.Size(140, 52);
            this.BtnPerson.TabIndex = 1;
            this.BtnPerson.Text = "Person";
            this.BtnPerson.UseVisualStyleBackColor = false;
            this.BtnPerson.Click += new System.EventHandler(this.BtnPerson_Click);
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.Location = new System.Drawing.Point(77, 46);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(132, 52);
            this.BtnAdmin.TabIndex = 4;
            this.BtnAdmin.Text = "Admin Dashboard";
            this.BtnAdmin.UseVisualStyleBackColor = true;
            // 
            // Dasboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 612);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dasboard";
            this.Text = "Dasboard";
            this.Load += new System.EventHandler(this.Dasboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnBuy;
        private System.Windows.Forms.Button BtnBook;
        private System.Windows.Forms.Button BtnPerson;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnAdmin;
    }
}