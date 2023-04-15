namespace LibraryManagement
{
    partial class TakingBook
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.libraryBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementDataSet = new LibraryManagement.LibraryManagementDataSet();
            this.libraryBooksTableAdapter = new LibraryManagement.LibraryManagementDataSetTableAdapters.LibraryBooksTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bookName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.bookLabel = new System.Windows.Forms.Label();
            this.takeBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.bookAuthorDataGridViewTextBoxColumn,
            this.bookStockDataGridViewTextBoxColumn,
            this.bookImageDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.libraryBooksBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(542, 260);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "BookName";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookAuthorDataGridViewTextBoxColumn
            // 
            this.bookAuthorDataGridViewTextBoxColumn.DataPropertyName = "BookAuthor";
            this.bookAuthorDataGridViewTextBoxColumn.HeaderText = "BookAuthor";
            this.bookAuthorDataGridViewTextBoxColumn.Name = "bookAuthorDataGridViewTextBoxColumn";
            this.bookAuthorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookStockDataGridViewTextBoxColumn
            // 
            this.bookStockDataGridViewTextBoxColumn.DataPropertyName = "BookStock";
            this.bookStockDataGridViewTextBoxColumn.HeaderText = "BookStock";
            this.bookStockDataGridViewTextBoxColumn.Name = "bookStockDataGridViewTextBoxColumn";
            this.bookStockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookImageDataGridViewImageColumn
            // 
            this.bookImageDataGridViewImageColumn.DataPropertyName = "BookImage";
            this.bookImageDataGridViewImageColumn.HeaderText = "BookImage";
            this.bookImageDataGridViewImageColumn.Name = "bookImageDataGridViewImageColumn";
            this.bookImageDataGridViewImageColumn.ReadOnly = true;
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
            this.pictureBox1.Size = new System.Drawing.Size(207, 272);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bookName
            // 
            this.bookName.AutoSize = true;
            this.bookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bookName.Location = new System.Drawing.Point(225, 57);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(96, 20);
            this.bookName.TabIndex = 2;
            this.bookName.Text = "Book Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(225, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Author Name:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.authorLabel.Location = new System.Drawing.Point(338, 142);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(0, 20);
            this.authorLabel.TabIndex = 4;
            // 
            // bookLabel
            // 
            this.bookLabel.AutoSize = true;
            this.bookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bookLabel.Location = new System.Drawing.Point(327, 57);
            this.bookLabel.Name = "bookLabel";
            this.bookLabel.Size = new System.Drawing.Size(0, 20);
            this.bookLabel.TabIndex = 5;
            // 
            // takeBook
            // 
            this.takeBook.ForeColor = System.Drawing.SystemColors.ControlText;
            this.takeBook.Location = new System.Drawing.Point(420, 292);
            this.takeBook.Name = "takeBook";
            this.takeBook.Size = new System.Drawing.Size(110, 23);
            this.takeBook.TabIndex = 6;
            this.takeBook.Text = "Take";
            this.takeBook.UseVisualStyleBackColor = true;
            this.takeBook.Click += new System.EventHandler(this.takeBook_Click);
            // 
            // TakingBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 581);
            this.Controls.Add(this.takeBook);
            this.Controls.Add(this.bookLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TakingBook";
            this.Text = "ListBooks";
            this.Load += new System.EventHandler(this.ListBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LibraryManagementDataSet libraryManagementDataSet;
        private System.Windows.Forms.BindingSource libraryBooksBindingSource;
        private LibraryManagementDataSetTableAdapters.LibraryBooksTableAdapter libraryBooksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn bookImageDataGridViewImageColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label bookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label bookLabel;
        private System.Windows.Forms.Button takeBook;
    }
}