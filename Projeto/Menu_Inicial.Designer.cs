namespace Projeto
{
    partial class Menu_Inicial
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
            this.btnEolica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHidrica = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSolar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAssociacao = new System.Windows.Forms.Button();
            this.Adminbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEolica
            // 
            this.btnEolica.Location = new System.Drawing.Point(57, 224);
            this.btnEolica.Name = "btnEolica";
            this.btnEolica.Size = new System.Drawing.Size(112, 42);
            this.btnEolica.TabIndex = 2;
            this.btnEolica.Text = "Energia Eolica";
            this.btnEolica.UseVisualStyleBackColor = true;
            this.btnEolica.Click += new System.EventHandler(this.BtnEolica_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(57, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 108);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aqui pode encontrar como é produzida, qual é utilização deste tipo de energias";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(226, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 108);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aqui pode encontrar como é produzida, qual é utilização deste tipo de energias";
            // 
            // btnHidrica
            // 
            this.btnHidrica.Location = new System.Drawing.Point(226, 224);
            this.btnHidrica.Name = "btnHidrica";
            this.btnHidrica.Size = new System.Drawing.Size(137, 42);
            this.btnHidrica.TabIndex = 4;
            this.btnHidrica.Text = "Energia Hidrica";
            this.btnHidrica.UseVisualStyleBackColor = true;
            this.btnHidrica.Click += new System.EventHandler(this.BtnHidrica_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(413, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 108);
            this.label3.TabIndex = 7;
            this.label3.Text = "Aqui pode encontrar como é produzida, qual é utilização deste tipo de energias";
            // 
            // btnSolar
            // 
            this.btnSolar.Location = new System.Drawing.Point(413, 224);
            this.btnSolar.Name = "btnSolar";
            this.btnSolar.Size = new System.Drawing.Size(112, 42);
            this.btnSolar.TabIndex = 6;
            this.btnSolar.Text = "Energia Solar";
            this.btnSolar.UseVisualStyleBackColor = true;
            this.btnSolar.Click += new System.EventHandler(this.BtnSolar_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(601, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 138);
            this.label4.TabIndex = 9;
            this.label4.Text = "Aqui pode saber o que faz cada associação ligada ao setor energético, e tambem co" +
    "ntem os contactos de cada energia ";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // btnAssociacao
            // 
            this.btnAssociacao.Location = new System.Drawing.Point(601, 224);
            this.btnAssociacao.Name = "btnAssociacao";
            this.btnAssociacao.Size = new System.Drawing.Size(112, 42);
            this.btnAssociacao.TabIndex = 8;
            this.btnAssociacao.Text = "Associações";
            this.btnAssociacao.UseVisualStyleBackColor = true;
            this.btnAssociacao.Click += new System.EventHandler(this.BtnAssociacao_Click);
            // 
            // Adminbtn
            // 
            this.Adminbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminbtn.Location = new System.Drawing.Point(663, 425);
            this.Adminbtn.Name = "Adminbtn";
            this.Adminbtn.Size = new System.Drawing.Size(137, 27);
            this.Adminbtn.TabIndex = 10;
            this.Adminbtn.Text = "ADMIN";
            this.Adminbtn.UseVisualStyleBackColor = true;
            // 
            // Menu_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Adminbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAssociacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSolar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHidrica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEolica);
            this.Name = "Menu_Inicial";
            this.Text = "Menu_Inicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEolica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHidrica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSolar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAssociacao;
        private System.Windows.Forms.Button Adminbtn;
    }
}