namespace Projeto
{
    partial class AddEmpresa
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
            this.NomeEmpresalabel = new System.Windows.Forms.Label();
            this.EmailEmpresalabel = new System.Windows.Forms.Label();
            this.TelefoneEmpresalabel = new System.Windows.Forms.Label();
            this.MoradaEmpresalabel = new System.Windows.Forms.Label();
            this.NomeEmpresaText = new System.Windows.Forms.TextBox();
            this.EmailEmpresaText = new System.Windows.Forms.TextBox();
            this.TelefoneEmpresaText = new System.Windows.Forms.TextBox();
            this.MoradaEmpresaText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.EscolherEnergiacomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NomeEmpresalabel
            // 
            this.NomeEmpresalabel.AutoSize = true;
            this.NomeEmpresalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeEmpresalabel.Location = new System.Drawing.Point(40, 73);
            this.NomeEmpresalabel.Name = "NomeEmpresalabel";
            this.NomeEmpresalabel.Size = new System.Drawing.Size(129, 20);
            this.NomeEmpresalabel.TabIndex = 0;
            this.NomeEmpresalabel.Text = "Nome empresa";
            // 
            // EmailEmpresalabel
            // 
            this.EmailEmpresalabel.AutoSize = true;
            this.EmailEmpresalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailEmpresalabel.Location = new System.Drawing.Point(40, 120);
            this.EmailEmpresalabel.Name = "EmailEmpresalabel";
            this.EmailEmpresalabel.Size = new System.Drawing.Size(158, 20);
            this.EmailEmpresalabel.TabIndex = 1;
            this.EmailEmpresalabel.Text = "E-mail da empresa";
            // 
            // TelefoneEmpresalabel
            // 
            this.TelefoneEmpresalabel.AutoSize = true;
            this.TelefoneEmpresalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefoneEmpresalabel.Location = new System.Drawing.Point(40, 221);
            this.TelefoneEmpresalabel.Name = "TelefoneEmpresalabel";
            this.TelefoneEmpresalabel.Size = new System.Drawing.Size(178, 20);
            this.TelefoneEmpresalabel.TabIndex = 3;
            this.TelefoneEmpresalabel.Text = "Telefone da empresa";
            // 
            // MoradaEmpresalabel
            // 
            this.MoradaEmpresalabel.AutoSize = true;
            this.MoradaEmpresalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoradaEmpresalabel.Location = new System.Drawing.Point(40, 174);
            this.MoradaEmpresalabel.Name = "MoradaEmpresalabel";
            this.MoradaEmpresalabel.Size = new System.Drawing.Size(168, 20);
            this.MoradaEmpresalabel.TabIndex = 2;
            this.MoradaEmpresalabel.Text = "Morada da empresa";
            // 
            // NomeEmpresaText
            // 
            this.NomeEmpresaText.Location = new System.Drawing.Point(294, 70);
            this.NomeEmpresaText.Name = "NomeEmpresaText";
            this.NomeEmpresaText.Size = new System.Drawing.Size(186, 22);
            this.NomeEmpresaText.TabIndex = 4;
            // 
            // EmailEmpresaText
            // 
            this.EmailEmpresaText.Location = new System.Drawing.Point(294, 117);
            this.EmailEmpresaText.Name = "EmailEmpresaText";
            this.EmailEmpresaText.Size = new System.Drawing.Size(186, 22);
            this.EmailEmpresaText.TabIndex = 5;
            // 
            // TelefoneEmpresaText
            // 
            this.TelefoneEmpresaText.Location = new System.Drawing.Point(294, 218);
            this.TelefoneEmpresaText.Name = "TelefoneEmpresaText";
            this.TelefoneEmpresaText.Size = new System.Drawing.Size(186, 22);
            this.TelefoneEmpresaText.TabIndex = 7;
            // 
            // MoradaEmpresaText
            // 
            this.MoradaEmpresaText.Location = new System.Drawing.Point(294, 171);
            this.MoradaEmpresaText.Name = "MoradaEmpresaText";
            this.MoradaEmpresaText.Size = new System.Drawing.Size(186, 22);
            this.MoradaEmpresaText.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(599, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Adicionar empresa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EscolherEnergiacomboBox
            // 
            this.EscolherEnergiacomboBox.FormattingEnabled = true;
            this.EscolherEnergiacomboBox.Items.AddRange(new object[] {
            "ESCOLHER ENERGIA",
            "Energia Solar",
            "Energia Eólica",
            "Energia Hídrica"});
            this.EscolherEnergiacomboBox.Location = new System.Drawing.Point(599, 86);
            this.EscolherEnergiacomboBox.Name = "EscolherEnergiacomboBox";
            this.EscolherEnergiacomboBox.Size = new System.Drawing.Size(164, 24);
            this.EscolherEnergiacomboBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(599, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = " Escolher a energia";
            // 
            // AddEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EscolherEnergiacomboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TelefoneEmpresaText);
            this.Controls.Add(this.MoradaEmpresaText);
            this.Controls.Add(this.EmailEmpresaText);
            this.Controls.Add(this.NomeEmpresaText);
            this.Controls.Add(this.TelefoneEmpresalabel);
            this.Controls.Add(this.MoradaEmpresalabel);
            this.Controls.Add(this.EmailEmpresalabel);
            this.Controls.Add(this.NomeEmpresalabel);
            this.Name = "AddEmpresa";
            this.Text = "AddEmpresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomeEmpresalabel;
        private System.Windows.Forms.Label EmailEmpresalabel;
        private System.Windows.Forms.Label TelefoneEmpresalabel;
        private System.Windows.Forms.Label MoradaEmpresalabel;
        private System.Windows.Forms.TextBox NomeEmpresaText;
        private System.Windows.Forms.TextBox EmailEmpresaText;
        private System.Windows.Forms.TextBox TelefoneEmpresaText;
        private System.Windows.Forms.TextBox MoradaEmpresaText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox EscolherEnergiacomboBox;
        private System.Windows.Forms.Label label1;
    }
}