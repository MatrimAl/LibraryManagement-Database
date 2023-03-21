namespace LibraryManagement
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.profilButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.listBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(465, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 93);
            this.button2.TabIndex = 1;
            this.button2.Text = "kitap al";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(754, 413);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 59);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // profilButton
            // 
            this.profilButton.BackColor = System.Drawing.Color.Transparent;
            this.profilButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profilButton.BackgroundImage")));
            this.profilButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.profilButton.Location = new System.Drawing.Point(733, 12);
            this.profilButton.Name = "profilButton";
            this.profilButton.Size = new System.Drawing.Size(80, 78);
            this.profilButton.TabIndex = 4;
            this.profilButton.UseVisualStyleBackColor = false;
            this.profilButton.Click += new System.EventHandler(this.profilButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(224, 297);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 93);
            this.button5.TabIndex = 5;
            this.button5.Text = "elindeki kitapları listele";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(465, 297);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 93);
            this.button6.TabIndex = 6;
            this.button6.Text = "kitap ver";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // listBooks
            // 
            this.listBooks.Location = new System.Drawing.Point(224, 101);
            this.listBooks.Name = "listBooks";
            this.listBooks.Size = new System.Drawing.Size(119, 93);
            this.listBooks.TabIndex = 7;
            this.listBooks.Text = "kitap listele";
            this.listBooks.UseVisualStyleBackColor = true;
            this.listBooks.Click += new System.EventHandler(this.listBooks_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(825, 484);
            this.Controls.Add(this.listBooks);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.profilButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button profilButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button listBooks;
    }
}