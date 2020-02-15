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
            this.Ext = new System.Windows.Forms.PictureBox();
            this.Kecid = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.BtnBook = new System.Windows.Forms.Button();
            this.BtnPerson = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ext)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Ext);
            this.panel1.Location = new System.Drawing.Point(2, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1480, 65);
            this.panel1.TabIndex = 1;
            // 
            // Ext
            // 
            this.Ext.BackColor = System.Drawing.Color.Transparent;
            this.Ext.Image = ((System.Drawing.Image)(resources.GetObject("Ext.Image")));
            this.Ext.Location = new System.Drawing.Point(1407, 3);
            this.Ext.Name = "Ext";
            this.Ext.Size = new System.Drawing.Size(73, 56);
            this.Ext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ext.TabIndex = 0;
            this.Ext.TabStop = false;
            this.Ext.Click += new System.EventHandler(this.Ext_Click);
            // 
            // Kecid
            // 
            this.Kecid.Location = new System.Drawing.Point(149, 68);
            this.Kecid.Name = "Kecid";
            this.Kecid.Size = new System.Drawing.Size(1333, 691);
            this.Kecid.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.BtnOrder);
            this.panel2.Controls.Add(this.BtnBook);
            this.panel2.Controls.Add(this.BtnPerson);
            this.panel2.Location = new System.Drawing.Point(2, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 691);
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
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // BtnBook
            // 
            this.BtnBook.Location = new System.Drawing.Point(0, 160);
            this.BtnBook.Name = "BtnBook";
            this.BtnBook.Size = new System.Drawing.Size(141, 49);
            this.BtnBook.TabIndex = 4;
            this.BtnBook.Text = "Book";
            this.BtnBook.UseVisualStyleBackColor = true;
            this.BtnBook.Click += new System.EventHandler(this.BtnBook_Click);
            // 
            // BtnPerson
            // 
            this.BtnPerson.Location = new System.Drawing.Point(0, 105);
            this.BtnPerson.Name = "BtnPerson";
            this.BtnPerson.Size = new System.Drawing.Size(141, 49);
            this.BtnPerson.TabIndex = 5;
            this.BtnPerson.Text = "Person";
            this.BtnPerson.UseVisualStyleBackColor = true;
            this.BtnPerson.Click += new System.EventHandler(this.BtnPerson_Click);
            // 
            // Dasboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1494, 764);
            this.Controls.Add(this.Kecid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dasboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dasboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ext)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Ext;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.Button BtnBook;
        private System.Windows.Forms.Button BtnPerson;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Kecid;
    }
}