namespace LibraryManagement
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usernameLogin = new System.Windows.Forms.Label();
            this.passwordLogin = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameLogin
            // 
            this.usernameLogin.AutoSize = true;
            this.usernameLogin.BackColor = System.Drawing.Color.Transparent;
            this.usernameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameLogin.Location = new System.Drawing.Point(71, 121);
            this.usernameLogin.Name = "usernameLogin";
            this.usernameLogin.Size = new System.Drawing.Size(102, 25);
            this.usernameLogin.TabIndex = 0;
            this.usernameLogin.Text = "Username";
            // 
            // passwordLogin
            // 
            this.passwordLogin.AutoSize = true;
            this.passwordLogin.BackColor = System.Drawing.Color.Transparent;
            this.passwordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordLogin.Location = new System.Drawing.Point(72, 191);
            this.passwordLogin.Name = "passwordLogin";
            this.passwordLogin.Size = new System.Drawing.Size(98, 25);
            this.passwordLogin.TabIndex = 1;
            this.passwordLogin.Text = "Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(203, 121);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(107, 20);
            this.usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(203, 196);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(107, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(128, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 54);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.Location = new System.Drawing.Point(203, 264);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(107, 42);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Transparent;
            this.registerButton.Location = new System.Drawing.Point(76, 264);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(107, 42);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(405, 345);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordLogin);
            this.Controls.Add(this.usernameLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLogin;
        private System.Windows.Forms.Label passwordLogin;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
    }
}

