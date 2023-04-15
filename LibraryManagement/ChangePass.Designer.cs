namespace LibraryManagement
{
    partial class ChangePass
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
            this.label1 = new System.Windows.Forms.Label();
            this.currentPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newPasswordAgain = new System.Windows.Forms.TextBox();
            this.sumbitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change The Password";
            // 
            // currentPassword
            // 
            this.currentPassword.Location = new System.Drawing.Point(229, 122);
            this.currentPassword.Name = "currentPassword";
            this.currentPassword.Size = new System.Drawing.Size(131, 20);
            this.currentPassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "New Password";
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(229, 195);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(131, 20);
            this.newPassword.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(32, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "New Password again";
            // 
            // newPasswordAgain
            // 
            this.newPasswordAgain.Location = new System.Drawing.Point(229, 281);
            this.newPasswordAgain.Name = "newPasswordAgain";
            this.newPasswordAgain.Size = new System.Drawing.Size(131, 20);
            this.newPasswordAgain.TabIndex = 6;
            // 
            // sumbitButton
            // 
            this.sumbitButton.Location = new System.Drawing.Point(251, 325);
            this.sumbitButton.Name = "sumbitButton";
            this.sumbitButton.Size = new System.Drawing.Size(109, 33);
            this.sumbitButton.TabIndex = 7;
            this.sumbitButton.Text = "Sumbit";
            this.sumbitButton.UseVisualStyleBackColor = true;
            this.sumbitButton.Click += new System.EventHandler(this.sumbitButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(47, 325);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(109, 33);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryManagement.Properties.Resources.paper_background;
            this.ClientSize = new System.Drawing.Size(445, 370);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.sumbitButton);
            this.Controls.Add(this.newPasswordAgain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentPassword);
            this.Controls.Add(this.label1);
            this.Name = "ChangePass";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox currentPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newPasswordAgain;
        private System.Windows.Forms.Button sumbitButton;
        private System.Windows.Forms.Button backButton;
    }
}