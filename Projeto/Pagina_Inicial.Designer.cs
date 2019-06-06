namespace Projeto
{
    partial class Pagina_Inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagina_Inicial));
            this.Entrarbtn = new System.Windows.Forms.Button();
            this.Registarbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Entrarbtn
            // 
            this.Entrarbtn.Location = new System.Drawing.Point(111, 322);
            this.Entrarbtn.Name = "Entrarbtn";
            this.Entrarbtn.Size = new System.Drawing.Size(104, 49);
            this.Entrarbtn.TabIndex = 1;
            this.Entrarbtn.Text = "LOGIN";
            this.Entrarbtn.UseVisualStyleBackColor = true;
            this.Entrarbtn.Click += new System.EventHandler(this.Entrarbtn_Click);
            // 
            // Registarbtn
            // 
            this.Registarbtn.Location = new System.Drawing.Point(524, 322);
            this.Registarbtn.Name = "Registarbtn";
            this.Registarbtn.Size = new System.Drawing.Size(116, 49);
            this.Registarbtn.TabIndex = 2;
            this.Registarbtn.Text = "REGISTAR";
            this.Registarbtn.UseVisualStyleBackColor = true;
            this.Registarbtn.Click += new System.EventHandler(this.Registarbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(219, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Pagina_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Registarbtn);
            this.Controls.Add(this.Entrarbtn);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pagina_Inicial";
            this.Text = "Descobre as Energias";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Entrarbtn;
        private System.Windows.Forms.Button Registarbtn;
    }
}

