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
            this.bookName = new System.Windows.Forms.TextBox();
            this.bookStock = new System.Windows.Forms.TextBox();
            this.authorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bookId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.uploadButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.libraryBooksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            // bookName
            // 
            this.bookName.Location = new System.Drawing.Point(386, 102);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(131, 20);
            this.bookName.TabIndex = 2;
            // 
            // bookStock
            // 
            this.bookStock.Location = new System.Drawing.Point(386, 195);
            this.bookStock.Name = "bookStock";
            this.bookStock.Size = new System.Drawing.Size(131, 20);
            this.bookStock.TabIndex = 3;
            // 
            // authorName
            // 
            this.authorName.Location = new System.Drawing.Point(386, 150);
            this.authorName.Name = "authorName";
            this.authorName.Size = new System.Drawing.Size(131, 20);
            this.authorName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(275, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Book Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(275, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Author Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(275, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Stock";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bookId
            // 
            this.bookId.Location = new System.Drawing.Point(386, 60);
            this.bookId.Name = "bookId";
            this.bookId.Size = new System.Drawing.Size(131, 20);
            this.bookId.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(275, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Book ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sumbit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(386, 241);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(131, 26);
            this.uploadButton.TabIndex = 12;
            this.uploadButton.Text = "Upload Image";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 368);
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
            // AdminListBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 609);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bookId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authorName);
            this.Controls.Add(this.bookStock);
            this.Controls.Add(this.bookName);
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
        private System.Windows.Forms.TextBox bookName;
        private System.Windows.Forms.TextBox bookStock;
        private System.Windows.Forms.TextBox authorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bookId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn bookImageDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource libraryBooksBindingSource1;
    }
}