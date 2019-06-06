namespace Projeto
{
    partial class UtilizacaoEnergia
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
            this.pnl_Utilizacao = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Utilizacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Utilizacao
            // 
            this.pnl_Utilizacao.Controls.Add(this.label1);
            this.pnl_Utilizacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Utilizacao.Location = new System.Drawing.Point(0, 0);
            this.pnl_Utilizacao.Name = "pnl_Utilizacao";
            this.pnl_Utilizacao.Size = new System.Drawing.Size(696, 413);
            this.pnl_Utilizacao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASDADGFHGDS";
            // 
            // UtilizacaoEnergia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 413);
            this.Controls.Add(this.pnl_Utilizacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UtilizacaoEnergia";
            this.Text = "UtilizacaoEnergia";
            this.pnl_Utilizacao.ResumeLayout(false);
            this.pnl_Utilizacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Utilizacao;
        private System.Windows.Forms.Label label1;
    }
}