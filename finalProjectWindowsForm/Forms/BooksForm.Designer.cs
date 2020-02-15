namespace finalProjectWindowsForm.Forms
{
    partial class BooksForm
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
            this.components = new System.ComponentModel.Container();
            this.DgvBookCrud = new System.Windows.Forms.DataGridView();
            this.LblPrice = new System.Windows.Forms.Label();
            this.LblAuthor = new System.Windows.Forms.Label();
            this.LblBookName = new System.Windows.Forms.Label();
            this.LblBookID = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.TbGenre = new System.Windows.Forms.TextBox();
            this.TbPrice = new System.Windows.Forms.TextBox();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet21 = new finalProjectWindowsForm.DataSet2();
            this.booksTableAdapter1 = new finalProjectWindowsForm.DataSet2TableAdapters.BooksTableAdapter();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TbPublisher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookCrud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvBookCrud
            // 
            this.DgvBookCrud.AllowUserToOrderColumns = true;
            this.DgvBookCrud.AutoGenerateColumns = false;
            this.DgvBookCrud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBookCrud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.publisherNameDataGridViewTextBoxColumn,
            this.bookGenreDataGridViewTextBoxColumn,
            this.bookPriceDataGridViewTextBoxColumn});
            this.DgvBookCrud.DataSource = this.bindingSource1;
            this.DgvBookCrud.Location = new System.Drawing.Point(475, 115);
            this.DgvBookCrud.Name = "DgvBookCrud";
            this.DgvBookCrud.RowHeadersWidth = 51;
            this.DgvBookCrud.RowTemplate.Height = 24;
            this.DgvBookCrud.Size = new System.Drawing.Size(692, 352);
            this.DgvBookCrud.TabIndex = 41;
            this.DgvBookCrud.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvBookCrud_RowHeaderMouseDoubleClick);
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(93, 274);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(53, 24);
            this.LblPrice.TabIndex = 40;
            this.LblPrice.Text = "Price";
            // 
            // LblAuthor
            // 
            this.LblAuthor.AutoSize = true;
            this.LblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAuthor.Location = new System.Drawing.Point(93, 219);
            this.LblAuthor.Name = "LblAuthor";
            this.LblAuthor.Size = new System.Drawing.Size(63, 24);
            this.LblAuthor.TabIndex = 39;
            this.LblAuthor.Text = "Genre";
            // 
            // LblBookName
            // 
            this.LblBookName.AutoSize = true;
            this.LblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookName.Location = new System.Drawing.Point(93, 173);
            this.LblBookName.Name = "LblBookName";
            this.LblBookName.Size = new System.Drawing.Size(61, 24);
            this.LblBookName.TabIndex = 38;
            this.LblBookName.Text = "Name";
            // 
            // LblBookID
            // 
            this.LblBookID.AutoSize = true;
            this.LblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookID.Location = new System.Drawing.Point(93, 125);
            this.LblBookID.Name = "LblBookID";
            this.LblBookID.Size = new System.Drawing.Size(70, 24);
            this.LblBookID.TabIndex = 37;
            this.LblBookID.Text = "BookID";
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(186, 165);
            this.TbName.Multiline = true;
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(271, 39);
            this.TbName.TabIndex = 36;
            // 
            // TbGenre
            // 
            this.TbGenre.Location = new System.Drawing.Point(186, 210);
            this.TbGenre.Multiline = true;
            this.TbGenre.Name = "TbGenre";
            this.TbGenre.Size = new System.Drawing.Size(271, 42);
            this.TbGenre.TabIndex = 35;
            // 
            // TbPrice
            // 
            this.TbPrice.Location = new System.Drawing.Point(186, 258);
            this.TbPrice.Multiline = true;
            this.TbPrice.Name = "TbPrice";
            this.TbPrice.Size = new System.Drawing.Size(271, 40);
            this.TbPrice.TabIndex = 34;
            // 
            // tbBookID
            // 
            this.tbBookID.Location = new System.Drawing.Point(186, 115);
            this.tbBookID.Multiline = true;
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.Size = new System.Drawing.Size(271, 44);
            this.tbBookID.TabIndex = 33;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(344, 420);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(112, 47);
            this.BtnDelete.TabIndex = 32;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(58, 420);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(114, 47);
            this.BtnUpdate.TabIndex = 31;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(206, 420);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(118, 47);
            this.BtnAdd.TabIndex = 30;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Books";
            this.bindingSource1.DataSource = this.dataSet21;
            // 
            // dataSet21
            // 
            this.dataSet21.DataSetName = "DataSet2";
            this.dataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksTableAdapter1
            // 
            this.booksTableAdapter1.ClearBeforeFill = true;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
            this.bookIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "BookName";
            this.bookNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // publisherNameDataGridViewTextBoxColumn
            // 
            this.publisherNameDataGridViewTextBoxColumn.DataPropertyName = "PublisherName";
            this.publisherNameDataGridViewTextBoxColumn.HeaderText = "PublisherName";
            this.publisherNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.publisherNameDataGridViewTextBoxColumn.Name = "publisherNameDataGridViewTextBoxColumn";
            this.publisherNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookGenreDataGridViewTextBoxColumn
            // 
            this.bookGenreDataGridViewTextBoxColumn.DataPropertyName = "BookGenre";
            this.bookGenreDataGridViewTextBoxColumn.HeaderText = "BookGenre";
            this.bookGenreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookGenreDataGridViewTextBoxColumn.Name = "bookGenreDataGridViewTextBoxColumn";
            this.bookGenreDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookPriceDataGridViewTextBoxColumn
            // 
            this.bookPriceDataGridViewTextBoxColumn.DataPropertyName = "BookPrice";
            this.bookPriceDataGridViewTextBoxColumn.HeaderText = "BookPrice";
            this.bookPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookPriceDataGridViewTextBoxColumn.Name = "bookPriceDataGridViewTextBoxColumn";
            this.bookPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // TbPublisher
            // 
            this.TbPublisher.Location = new System.Drawing.Point(186, 320);
            this.TbPublisher.Multiline = true;
            this.TbPublisher.Name = "TbPublisher";
            this.TbPublisher.Size = new System.Drawing.Size(271, 40);
            this.TbPublisher.TabIndex = 42;
            this.TbPublisher.TextChanged += new System.EventHandler(this.TbPublisher_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "Publisher";
            // 
            // bookBindingSource1
            // 
            this.bookBindingSource1.DataSource = typeof(finalProjectWindowsForm.Models.Book);
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbPublisher);
            this.Controls.Add(this.DgvBookCrud);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.LblAuthor);
            this.Controls.Add(this.LblBookName);
            this.Controls.Add(this.LblBookID);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.TbGenre);
            this.Controls.Add(this.TbPrice);
            this.Controls.Add(this.tbBookID);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Name = "BooksForm";
            this.Text = "BooksForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookCrud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvBookCrud;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblAuthor;
        private System.Windows.Forms.Label LblBookName;
        private System.Windows.Forms.Label LblBookID;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.TextBox TbGenre;
        private System.Windows.Forms.TextBox TbPrice;
        private System.Windows.Forms.TextBox tbBookID;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DataSet2 dataSet21;
        private DataSet2TableAdapters.BooksTableAdapter booksTableAdapter1;
        private System.Windows.Forms.BindingSource bookBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TbPublisher;
        private System.Windows.Forms.Label label1;
    }
}