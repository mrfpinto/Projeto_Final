namespace Projeto
{
    partial class Registo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registo));
            this.PassRegisto = new System.Windows.Forms.TextBox();
            this.UserRegisto = new System.Windows.Forms.TextBox();
            this.Pass_Registo = new System.Windows.Forms.Label();
            this.User_Registo = new System.Windows.Forms.Label();
            this.Registobtn = new System.Windows.Forms.Button();
            this.EmailRegisto = new System.Windows.Forms.TextBox();
            this.Email_Registo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Voltarbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PassRegisto
            // 
            this.PassRegisto.Location = new System.Drawing.Point(399, 239);
            this.PassRegisto.Multiline = true;
            this.PassRegisto.Name = "PassRegisto";
            this.PassRegisto.PasswordChar = '*';
            this.PassRegisto.Size = new System.Drawing.Size(224, 26);
            this.PassRegisto.TabIndex = 7;
            this.PassRegisto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassRegisto.TextChanged += new System.EventHandler(this.passRegisto_TextChanged);
            // 
            // UserRegisto
            // 
            this.UserRegisto.Location = new System.Drawing.Point(399, 164);
            this.UserRegisto.Multiline = true;
            this.UserRegisto.Name = "UserRegisto";
            this.UserRegisto.Size = new System.Drawing.Size(224, 26);
            this.UserRegisto.TabIndex = 6;
            this.UserRegisto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserRegisto.TextChanged += new System.EventHandler(this.userRegisto_TextChanged);
            // 
            // Pass_Registo
            // 
            this.Pass_Registo.AutoSize = true;
            this.Pass_Registo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_Registo.Location = new System.Drawing.Point(175, 245);
            this.Pass_Registo.Name = "Pass_Registo";
            this.Pass_Registo.Size = new System.Drawing.Size(111, 20);
            this.Pass_Registo.TabIndex = 5;
            this.Pass_Registo.Text = "PASSWORD";
            // 
            // User_Registo
            // 
            this.User_Registo.AutoSize = true;
            this.User_Registo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Registo.Location = new System.Drawing.Point(175, 170);
            this.User_Registo.Name = "User_Registo";
            this.User_Registo.Size = new System.Drawing.Size(109, 20);
            this.User_Registo.TabIndex = 4;
            this.User_Registo.Text = "USERNAME";
            this.User_Registo.Click += new System.EventHandler(this.User_Login_Click);
            // 
            // Registobtn
            // 
            this.Registobtn.Location = new System.Drawing.Point(264, 387);
            this.Registobtn.Name = "Registobtn";
            this.Registobtn.Size = new System.Drawing.Size(223, 51);
            this.Registobtn.TabIndex = 8;
            this.Registobtn.Text = "REGISTAR";
            this.Registobtn.UseVisualStyleBackColor = true;
            this.Registobtn.Click += new System.EventHandler(this.Registobtn_Click);
            // 
            // EmailRegisto
            // 
            this.EmailRegisto.Location = new System.Drawing.Point(399, 304);
            this.EmailRegisto.Multiline = true;
            this.EmailRegisto.Name = "EmailRegisto";
            this.EmailRegisto.Size = new System.Drawing.Size(224, 26);
            this.EmailRegisto.TabIndex = 10;
            this.EmailRegisto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmailRegisto.TextChanged += new System.EventHandler(this.EmailRegisto_TextChanged);
            // 
            // Email_Registo
            // 
            this.Email_Registo.AutoSize = true;
            this.Email_Registo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_Registo.Location = new System.Drawing.Point(175, 310);
            this.Email_Registo.Name = "Email_Registo";
            this.Email_Registo.Size = new System.Drawing.Size(69, 20);
            this.Email_Registo.TabIndex = 9;
            this.Email_Registo.Text = "E-MAIL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto.Properties.Resources.id_card;
            this.pictureBox1.Location = new System.Drawing.Point(292, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Voltarbtn
            // 
            this.Voltarbtn.Location = new System.Drawing.Point(710, 417);
            this.Voltarbtn.Name = "Voltarbtn";
            this.Voltarbtn.Size = new System.Drawing.Size(90, 35);
            this.Voltarbtn.TabIndex = 12;
            this.Voltarbtn.Text = "VOLTAR";
            this.Voltarbtn.UseVisualStyleBackColor = true;
            this.Voltarbtn.Click += new System.EventHandler(this.Voltarbtn_Click);
            // 
            // Registo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Voltarbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EmailRegisto);
            this.Controls.Add(this.Email_Registo);
            this.Controls.Add(this.Registobtn);
            this.Controls.Add(this.PassRegisto);
            this.Controls.Add(this.UserRegisto);
            this.Controls.Add(this.Pass_Registo);
            this.Controls.Add(this.User_Registo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registo";
            this.Text = "Registo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PassRegisto;
        private System.Windows.Forms.TextBox UserRegisto;
        private System.Windows.Forms.Label Pass_Registo;
        private System.Windows.Forms.Label User_Registo;
        private System.Windows.Forms.Button Registobtn;
        private System.Windows.Forms.TextBox EmailRegisto;
        private System.Windows.Forms.Label Email_Registo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Voltarbtn;
    }
}