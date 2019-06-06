namespace Projeto
{
    partial class ModUtilizacaoEnergia
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
            this.ModUtilizacaoText = new System.Windows.Forms.RichTextBox();
            this.Atualizarbtn = new System.Windows.Forms.Button();
            this.EscolherEnergia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ModUtilizacaoText
            // 
            this.ModUtilizacaoText.Location = new System.Drawing.Point(12, 12);
            this.ModUtilizacaoText.Name = "ModUtilizacaoText";
            this.ModUtilizacaoText.Size = new System.Drawing.Size(484, 426);
            this.ModUtilizacaoText.TabIndex = 0;
            this.ModUtilizacaoText.Text = "";
            // 
            // Atualizarbtn
            // 
            this.Atualizarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atualizarbtn.Location = new System.Drawing.Point(589, 400);
            this.Atualizarbtn.Name = "Atualizarbtn";
            this.Atualizarbtn.Size = new System.Drawing.Size(173, 38);
            this.Atualizarbtn.TabIndex = 1;
            this.Atualizarbtn.Text = "ATUALIZAR DADOS";
            this.Atualizarbtn.UseVisualStyleBackColor = true;
            // 
            // EscolherEnergia
            // 
            this.EscolherEnergia.FormattingEnabled = true;
            this.EscolherEnergia.Items.AddRange(new object[] {
            "ESCOLHE A ENERGIA",
            "Energia Solar",
            "Energia Eólica",
            "Energia Hídrica"});
            this.EscolherEnergia.Location = new System.Drawing.Point(546, 46);
            this.EscolherEnergia.Name = "EscolherEnergia";
            this.EscolherEnergia.Size = new System.Drawing.Size(218, 24);
            this.EscolherEnergia.TabIndex = 2;
            // 
            // ModUtilizacaoEnergia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EscolherEnergia);
            this.Controls.Add(this.Atualizarbtn);
            this.Controls.Add(this.ModUtilizacaoText);
            this.Name = "ModUtilizacaoEnergia";
            this.Text = "Modificar utilização da energia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ModUtilizacaoText;
        private System.Windows.Forms.Button Atualizarbtn;
        private System.Windows.Forms.ComboBox EscolherEnergia;
    }
}