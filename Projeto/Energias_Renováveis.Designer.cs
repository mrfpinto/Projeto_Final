namespace Projeto
{
    partial class Energias_Renováveis
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
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.btnUtilizacao = new System.Windows.Forms.Button();
            this.btnTecnicos = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pnl_SobreEnergia = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Location = new System.Drawing.Point(0, 0);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(254, 30);
            this.btnEmpresa.TabIndex = 10;
            this.btnEmpresa.Text = "Empresas Exploradoras";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.BtnEmpresa_Click);
            // 
            // btnUtilizacao
            // 
            this.btnUtilizacao.Location = new System.Drawing.Point(250, 0);
            this.btnUtilizacao.Name = "btnUtilizacao";
            this.btnUtilizacao.Size = new System.Drawing.Size(290, 30);
            this.btnUtilizacao.TabIndex = 11;
            this.btnUtilizacao.Text = "Utilização Energia";
            this.btnUtilizacao.UseVisualStyleBackColor = true;
            this.btnUtilizacao.Click += new System.EventHandler(this.BtnUtilizacao_Click);
            // 
            // btnTecnicos
            // 
            this.btnTecnicos.Location = new System.Drawing.Point(538, 0);
            this.btnTecnicos.Name = "btnTecnicos";
            this.btnTecnicos.Size = new System.Drawing.Size(229, 30);
            this.btnTecnicos.TabIndex = 12;
            this.btnTecnicos.Text = "Campos Técnicos";
            this.btnTecnicos.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(764, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(149, 30);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // pnl_SobreEnergia
            // 
            this.pnl_SobreEnergia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_SobreEnergia.Location = new System.Drawing.Point(0, 27);
            this.pnl_SobreEnergia.Name = "pnl_SobreEnergia";
            this.pnl_SobreEnergia.Size = new System.Drawing.Size(913, 499);
            this.pnl_SobreEnergia.TabIndex = 8;
            // 
            // Energias_Renováveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 526);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnTecnicos);
            this.Controls.Add(this.btnUtilizacao);
            this.Controls.Add(this.btnEmpresa);
            this.Controls.Add(this.pnl_SobreEnergia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "Energias_Renováveis";
            this.Text = "Energias_Renováveis";
            this.Load += new System.EventHandler(this.Energias_Renováveis_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Button btnUtilizacao;
        private System.Windows.Forms.Button btnTecnicos;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel pnl_SobreEnergia;
    }
}