namespace LibraryManagement
{
    partial class AdminListBooks
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
            this.libraryBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementDataSet = new LibraryManagement.LibraryManagementDataSet();
            this.libraryBooksTableAdapter = new LibraryManagement.LibraryManagementDataSetTableAdapters.LibraryBooksTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.libraryBooksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idBook = new System.Windows.Forms.TextBox();
            this.nameBook = new System.Windows.Forms.TextBox();
            this.authorBook = new System.Windows.Forms.TextBox();
            this.stockBook = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.uploadButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBooksBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // libraryBooksBindingSource
            // 
            this.libraryBooksBindingSource.DataMember = "LibraryBooks";
            this.libraryBooksBindingSource.DataSource = this.libraryManagementDataSet;
            // 
            // libraryManagementDataSet
            // 
            this.libraryManagementDataSet.DataSetName = "LibraryManagementDataSet";
            this.libraryManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryBooksTableAdapter
            // 
            this.libraryBooksTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 312);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.bookAuthorDataGridViewTextBoxColumn,
            this.bookStockDataGridViewTextBoxColumn,
            this.bookImageDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.libraryBooksBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 343);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(530, 229);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "BookName";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            // 
            // bookAuthorDataGridViewTextBoxColumn
            // 
            this.bookAuthorDataGridViewTextBoxColumn.DataPropertyName = "BookAuthor";
            this.bookAuthorDataGridViewTextBoxColumn.HeaderText = "BookAuthor";
            this.bookAuthorDataGridViewTextBoxColumn.Name = "bookAuthorDataGridViewTextBoxColumn";
            // 
            // bookStockDataGridViewTextBoxColumn
            // 
            this.bookStockDataGridViewTextBoxColumn.DataPropertyName = "BookStock";
            this.bookStockDataGridViewTextBoxColumn.HeaderText = "BookStock";
            this.bookStockDataGridViewTextBoxColumn.Name = "bookStockDataGridViewTextBoxColumn";
            // 
            // bookImageDataGridViewImageColumn
            // 
            this.bookImageDataGridViewImageColumn.DataPropertyName = "BookImage";
            this.bookImageDataGridViewImageColumn.HeaderText = "BookImage";
            this.bookImageDataGridViewImageColumn.Name = "bookImageDataGridViewImageColumn";
            // 
            // libraryBooksBindingSource1
            // 
            this.libraryBooksBindingSource1.DataMember = "LibraryBooks";
            this.libraryBooksBindingSource1.DataSource = this.libraryManagementDataSet;
            // 
            // idBook
            // 
            this.idBook.Location = new System.Drawing.Point(411, 52);
            this.idBook.Name = "idBook";
            this.idBook.Size = new System.Drawing.Size(110, 20);
            this.idBook.TabIndex = 14;
            // 
            // nameBook
            // 
            this.nameBook.Location = new System.Drawing.Point(411, 103);
            this.nameBook.Name = "nameBook";
            this.nameBook.Size = new System.Drawing.Size(110, 20);
            this.nameBook.TabIndex = 15;
            // 
            // authorBook
            // 
            this.authorBook.Location = new System.Drawing.Point(411, 153);
            this.authorBook.Name = "authorBook";
            this.authorBook.Size = new System.Drawing.Size(110, 20);
            this.authorBook.TabIndex = 16;
            // 
            // stockBook
            // 
            this.stockBook.Location = new System.Drawing.Point(411, 208);
            this.stockBook.Name = "stockBook";
            this.stockBook.Size = new System.Drawing.Size(110, 20);
            this.stockBook.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(275, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Book Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(275, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Book Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(275, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Book Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(275, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Book ID";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(411, 290);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(110, 23);
            this.insertButton.TabIndex = 22;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(279, 290);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(110, 23);
            this.uploadButton.TabIndex = 23;
            this.uploadButton.Text = "Upload Image";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(411, 578);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(110, 23);
            this.updateButton.TabIndex = 24;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(279, 578);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(110, 23);
            this.refreshButton.TabIndex = 25;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // AdminListBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 609);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stockBook);
            this.Controls.Add(this.authorBook);
            this.Controls.Add(this.nameBook);
            this.Controls.Add(this.idBook);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdminListBooks";
            this.Text = "List";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBooksBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LibraryManagementDataSet libraryManagementDataSet;
        private System.Windows.Forms.BindingSource libraryBooksBindingSource;
        private LibraryManagementDataSetTableAdapters.LibraryBooksTableAdapter libraryBooksTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn bookImageDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource libraryBooksBindingSource1;
        private System.Windows.Forms.TextBox idBook;
        private System.Windows.Forms.TextBox nameBook;
        private System.Windows.Forms.TextBox authorBook;
        private System.Windows.Forms.TextBox stockBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button refreshButton;
    }
}