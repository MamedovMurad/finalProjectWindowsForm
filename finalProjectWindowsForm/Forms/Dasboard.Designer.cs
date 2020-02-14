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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.BtnBook = new System.Windows.Forms.Button();
            this.BtnPerson = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 68);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(924, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(149, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(853, 545);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.BtnOrder);
            this.panel2.Controls.Add(this.BtnBook);
            this.panel2.Controls.Add(this.BtnPerson);
            this.panel2.Location = new System.Drawing.Point(2, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 545);
            this.panel2.TabIndex = 0;
            // 
            // BtnOrder
            // 
            this.BtnOrder.Location = new System.Drawing.Point(0, 215);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(141, 44);
            this.BtnOrder.TabIndex = 3;
            this.BtnOrder.Text = "Order";
            this.BtnOrder.UseVisualStyleBackColor = true;
            // 
            // BtnBook
            // 
            this.BtnBook.Location = new System.Drawing.Point(0, 160);
            this.BtnBook.Name = "BtnBook";
            this.BtnBook.Size = new System.Drawing.Size(141, 49);
            this.BtnBook.TabIndex = 4;
            this.BtnBook.Text = "Book";
            this.BtnBook.UseVisualStyleBackColor = true;
            // 
            // BtnPerson
            // 
            this.BtnPerson.Location = new System.Drawing.Point(0, 105);
            this.BtnPerson.Name = "BtnPerson";
            this.BtnPerson.Size = new System.Drawing.Size(141, 49);
            this.BtnPerson.TabIndex = 5;
            this.BtnPerson.Text = "Person";
            this.BtnPerson.UseVisualStyleBackColor = true;
            this.BtnPerson.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Dasboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1004, 612);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dasboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dasboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.Button BtnBook;
        private System.Windows.Forms.Button BtnPerson;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}