namespace Projeto
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
            this.User_Login = new System.Windows.Forms.Label();
            this.Pass_Login = new System.Windows.Forms.Label();
            this.UserLogin = new System.Windows.Forms.TextBox();
            this.PassLogin = new System.Windows.Forms.TextBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Voltarbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // User_Login
            // 
            this.User_Login.AutoSize = true;
            this.User_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Login.Location = new System.Drawing.Point(237, 211);
            this.User_Login.Name = "User_Login";
            this.User_Login.Size = new System.Drawing.Size(109, 20);
            this.User_Login.TabIndex = 0;
            this.User_Login.Text = "USERNAME";
            // 
            // Pass_Login
            // 
            this.Pass_Login.AutoSize = true;
            this.Pass_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_Login.Location = new System.Drawing.Point(235, 283);
            this.Pass_Login.Name = "Pass_Login";
            this.Pass_Login.Size = new System.Drawing.Size(111, 20);
            this.Pass_Login.TabIndex = 1;
            this.Pass_Login.Text = "PASSWORD";
            // 
            // UserLogin
            // 
            this.UserLogin.Location = new System.Drawing.Point(382, 205);
            this.UserLogin.Multiline = true;
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Size = new System.Drawing.Size(224, 26);
            this.UserLogin.TabIndex = 2;
            this.UserLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PassLogin
            // 
            this.PassLogin.Location = new System.Drawing.Point(382, 283);
            this.PassLogin.Multiline = true;
            this.PassLogin.Name = "PassLogin";
            this.PassLogin.Size = new System.Drawing.Size(224, 26);
            this.PassLogin.TabIndex = 3;
            this.PassLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassLogin.TextChanged += new System.EventHandler(this.PassLogin_TextChanged);

            // 
            // Loginbtn
            // 
            this.Loginbtn.Location = new System.Drawing.Point(293, 377);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(223, 61);
            this.Loginbtn.TabIndex = 4;
            this.Loginbtn.Text = "LOGIN";
            this.Loginbtn.UseVisualStyleBackColor = true;

            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto.Properties.Resources.id_card;
            this.pictureBox1.Location = new System.Drawing.Point(311, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Voltarbtn
            // 
            this.Voltarbtn.Location = new System.Drawing.Point(712, 415);
            this.Voltarbtn.Name = "Voltarbtn";
            this.Voltarbtn.Size = new System.Drawing.Size(90, 35);
            this.Voltarbtn.TabIndex = 6;
            this.Voltarbtn.Text = "VOLTAR";
            this.Voltarbtn.UseVisualStyleBackColor = true;
            this.Voltarbtn.Click += new System.EventHandler(this.Voltarbtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Voltarbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.PassLogin);
            this.Controls.Add(this.UserLogin);
            this.Controls.Add(this.Pass_Login);
            this.Controls.Add(this.User_Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label User_Login;
        private System.Windows.Forms.Label Pass_Login;
        private System.Windows.Forms.TextBox UserLogin;
        private System.Windows.Forms.TextBox PassLogin;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Voltarbtn;
    }
}