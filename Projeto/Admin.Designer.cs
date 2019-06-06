namespace Projeto
{
    partial class Admin
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
            this.AddEmpresasbtn = new System.Windows.Forms.Button();
            this.ModEnergiasbtn = new System.Windows.Forms.Button();
            this.AddCamposbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(206, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "BEM VINDO AO MODO DE ADMINISTRADOR";
            // 
            // AddEmpresasbtn
            // 
            this.AddEmpresasbtn.Location = new System.Drawing.Point(58, 204);
            this.AddEmpresasbtn.Name = "AddEmpresasbtn";
            this.AddEmpresasbtn.Size = new System.Drawing.Size(120, 55);
            this.AddEmpresasbtn.TabIndex = 1;
            this.AddEmpresasbtn.Text = "Adicionar empresas";
            this.AddEmpresasbtn.UseVisualStyleBackColor = true;
            // 
            // ModEnergiasbtn
            // 
            this.ModEnergiasbtn.Location = new System.Drawing.Point(309, 197);
            this.ModEnergiasbtn.Name = "ModEnergiasbtn";
            this.ModEnergiasbtn.Size = new System.Drawing.Size(120, 68);
            this.ModEnergiasbtn.TabIndex = 2;
            this.ModEnergiasbtn.Text = "Modificar utilização das energias";
            this.ModEnergiasbtn.UseVisualStyleBackColor = true;
            // 
            // AddCamposbtn
            // 
            this.AddCamposbtn.Location = new System.Drawing.Point(574, 197);
            this.AddCamposbtn.Name = "AddCamposbtn";
            this.AddCamposbtn.Size = new System.Drawing.Size(141, 68);
            this.AddCamposbtn.TabIndex = 3;
            this.AddCamposbtn.Text = "Adicionar/modificar campos das energias";
            this.AddCamposbtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(55, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 94);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aqui pode adicionar as empresas exploradoras e em qual das energias pretende adic" +
    "ionar";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(306, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 94);
            this.label3.TabIndex = 5;
            this.label3.Text = "Aqui pode adicionar /modificar as informações sobre a utilização das energias";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(571, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 74);
            this.label4.TabIndex = 6;
            this.label4.Text = "Aqui pode adicionar /modificar campos à tabela dos campos técnicos";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddCamposbtn);
            this.Controls.Add(this.ModEnergiasbtn);
            this.Controls.Add(this.AddEmpresasbtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Admin";
            this.Text = "MODO ADMINISTRADOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddEmpresasbtn;
        private System.Windows.Forms.Button ModEnergiasbtn;
        private System.Windows.Forms.Button AddCamposbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}