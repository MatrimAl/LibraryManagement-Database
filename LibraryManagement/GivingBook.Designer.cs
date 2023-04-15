namespace LibraryManagement
{
    partial class GivingBook
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.authorNameLabel = new System.Windows.Forms.Label();
            this.libraryManagementDataSet = new LibraryManagement.LibraryManagementDataSet();
            this.libraryBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryBooksTableAdapter = new LibraryManagement.LibraryManagementDataSetTableAdapters.LibraryBooksTableAdapter();
            this.libraryManagementDataSet1 = new LibraryManagement.LibraryManagementDataSet1();
            this.givenBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.givenBooksTableAdapter = new LibraryManagement.LibraryManagementDataSet1TableAdapters.GivenBooksTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.givenBooksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementDataSet2 = new LibraryManagement.LibraryManagementDataSet2();
            this.givenBooksTableAdapter1 = new LibraryManagement.LibraryManagementDataSet2TableAdapters.GivenBooksTableAdapter();
            this.giveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.givenBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.givenBooksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 249);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(210, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(210, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Author";
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bookNameLabel.Location = new System.Drawing.Point(325, 64);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(90, 24);
            this.bookNameLabel.TabIndex = 3;
            this.bookNameLabel.Text = "                ";
            // 
            // authorNameLabel
            // 
            this.authorNameLabel.AutoSize = true;
            this.authorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.authorNameLabel.Location = new System.Drawing.Point(330, 156);
            this.authorNameLabel.Name = "authorNameLabel";
            this.authorNameLabel.Size = new System.Drawing.Size(90, 24);
            this.authorNameLabel.TabIndex = 4;
            this.authorNameLabel.Text = "                ";
            // 
            // libraryManagementDataSet
            // 
            this.libraryManagementDataSet.DataSetName = "LibraryManagementDataSet";
            this.libraryManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryBooksBindingSource
            // 
            this.libraryBooksBindingSource.DataMember = "LibraryBooks";
            this.libraryBooksBindingSource.DataSource = this.libraryManagementDataSet;
            // 
            // libraryBooksTableAdapter
            // 
            this.libraryBooksTableAdapter.ClearBeforeFill = true;
            // 
            // libraryManagementDataSet1
            // 
            this.libraryManagementDataSet1.DataSetName = "LibraryManagementDataSet1";
            this.libraryManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // givenBooksBindingSource
            // 
            this.givenBooksBindingSource.DataMember = "GivenBooks";
            this.givenBooksBindingSource.DataSource = this.libraryManagementDataSet1;
            // 
            // givenBooksTableAdapter
            // 
            this.givenBooksTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.bookIDDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.bookAuthorDataGridViewTextBoxColumn,
            this.bookImageDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.givenBooksBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 219);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
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
            // bookImageDataGridViewImageColumn
            // 
            this.bookImageDataGridViewImageColumn.DataPropertyName = "BookImage";
            this.bookImageDataGridViewImageColumn.HeaderText = "BookImage";
            this.bookImageDataGridViewImageColumn.Name = "bookImageDataGridViewImageColumn";
            // 
            // givenBooksBindingSource1
            // 
            this.givenBooksBindingSource1.DataMember = "GivenBooks";
            this.givenBooksBindingSource1.DataSource = this.libraryManagementDataSet2;
            // 
            // libraryManagementDataSet2
            // 
            this.libraryManagementDataSet2.DataSetName = "LibraryManagementDataSet2";
            this.libraryManagementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // givenBooksTableAdapter1
            // 
            this.givenBooksTableAdapter1.ClearBeforeFill = true;
            // 
            // giveButton
            // 
            this.giveButton.Location = new System.Drawing.Point(435, 266);
            this.giveButton.Name = "giveButton";
            this.giveButton.Size = new System.Drawing.Size(118, 26);
            this.giveButton.TabIndex = 6;
            this.giveButton.Text = "Give";
            this.giveButton.UseVisualStyleBackColor = true;
            this.giveButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // GivingBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 529);
            this.Controls.Add(this.giveButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.authorNameLabel);
            this.Controls.Add(this.bookNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GivingBook";
            this.Text = "GivingBook";
            this.Load += new System.EventHandler(this.GivingBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.givenBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.givenBooksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bookNameLabel;
        private System.Windows.Forms.Label authorNameLabel;
        private LibraryManagementDataSet libraryManagementDataSet;
        private System.Windows.Forms.BindingSource libraryBooksBindingSource;
        private LibraryManagementDataSetTableAdapters.LibraryBooksTableAdapter libraryBooksTableAdapter;
        private LibraryManagementDataSet1 libraryManagementDataSet1;
        private System.Windows.Forms.BindingSource givenBooksBindingSource;
        private LibraryManagementDataSet1TableAdapters.GivenBooksTableAdapter givenBooksTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LibraryManagementDataSet2 libraryManagementDataSet2;
        private System.Windows.Forms.BindingSource givenBooksBindingSource1;
        private LibraryManagementDataSet2TableAdapters.GivenBooksTableAdapter givenBooksTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn bookImageDataGridViewImageColumn;
        private System.Windows.Forms.Button giveButton;
    }
}