namespace finalProjectWindowsForm.Forms
{
    partial class Book
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblPrice = new System.Windows.Forms.Label();
            this.LblAuthor = new System.Windows.Forms.Label();
            this.LblBookName = new System.Windows.Forms.Label();
            this.LblBookID = new System.Windows.Forms.Label();
            this.LblCount = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookName,
            this.PublisherName,
            this.BookGenre,
            this.BookPrice,
            this.Count});
            this.dataGridView1.Location = new System.Drawing.Point(396, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(685, 553);
            this.dataGridView1.TabIndex = 29;
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(17, 262);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(53, 24);
            this.LblPrice.TabIndex = 28;
            this.LblPrice.Text = "Price";
            // 
            // LblAuthor
            // 
            this.LblAuthor.AutoSize = true;
            this.LblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAuthor.Location = new System.Drawing.Point(17, 207);
            this.LblAuthor.Name = "LblAuthor";
            this.LblAuthor.Size = new System.Drawing.Size(66, 24);
            this.LblAuthor.TabIndex = 27;
            this.LblAuthor.Text = "Author";
            // 
            // LblBookName
            // 
            this.LblBookName.AutoSize = true;
            this.LblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookName.Location = new System.Drawing.Point(17, 161);
            this.LblBookName.Name = "LblBookName";
            this.LblBookName.Size = new System.Drawing.Size(61, 24);
            this.LblBookName.TabIndex = 26;
            this.LblBookName.Text = "Name";
            // 
            // LblBookID
            // 
            this.LblBookID.AutoSize = true;
            this.LblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookID.Location = new System.Drawing.Point(17, 113);
            this.LblBookID.Name = "LblBookID";
            this.LblBookID.Size = new System.Drawing.Size(70, 24);
            this.LblBookID.TabIndex = 25;
            this.LblBookID.Text = "BookID";
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCount.Location = new System.Drawing.Point(17, 312);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(60, 24);
            this.LblCount.TabIndex = 24;
            this.LblCount.Text = "Count";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(110, 153);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(271, 39);
            this.textBox6.TabIndex = 23;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(110, 198);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(271, 42);
            this.textBox5.TabIndex = 22;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(110, 246);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(271, 40);
            this.textBox4.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 292);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(271, 44);
            this.textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 103);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 44);
            this.textBox1.TabIndex = 19;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(269, 361);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(112, 47);
            this.BtnDelete.TabIndex = 18;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(21, 361);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(114, 47);
            this.BtnUpdate.TabIndex = 17;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(141, 361);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(118, 47);
            this.BtnAdd.TabIndex = 16;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // BookName
            // 
            this.BookName.HeaderText = "Name";
            this.BookName.MinimumWidth = 6;
            this.BookName.Name = "BookName";
            this.BookName.Width = 125;
            // 
            // PublisherName
            // 
            this.PublisherName.HeaderText = "Author";
            this.PublisherName.MinimumWidth = 6;
            this.PublisherName.Name = "PublisherName";
            this.PublisherName.Width = 125;
            // 
            // BookGenre
            // 
            this.BookGenre.DataPropertyName = "BookGenre";
            this.BookGenre.HeaderText = "Genre";
            this.BookGenre.MinimumWidth = 6;
            this.BookGenre.Name = "BookGenre";
            this.BookGenre.Width = 125;
            // 
            // BookPrice
            // 
            this.BookPrice.HeaderText = "Price";
            this.BookPrice.MinimumWidth = 6;
            this.BookPrice.Name = "BookPrice";
            this.BookPrice.Width = 125;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            this.Count.Width = 125;
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 618);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.LblAuthor);
            this.Controls.Add(this.LblBookName);
            this.Controls.Add(this.LblBookID);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Book";
            this.Text = "Book";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblAuthor;
        private System.Windows.Forms.Label LblBookName;
        private System.Windows.Forms.Label LblBookID;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}