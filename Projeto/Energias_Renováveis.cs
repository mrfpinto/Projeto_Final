using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Energias_Renováveis : Form
    {
        public Energias_Renováveis()
        {
            InitializeComponent();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
        
        private void MenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void VoltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Menu_Inicial form = new Menu_Inicial();
            form.Show();
            Close();
        }

        private void Energias_Renováveis_Load(object sender, EventArgs e)
        {
            
        }



        private void BtnEmpresa_Click(object sender, EventArgs e)
        {
            if (this.pnl_SobreEnergia.Controls.Count > 0)
            {
                this.pnl_SobreEnergia.Controls.RemoveAt(0);
            }

            Empresa_Exploradora log = new Empresa_Exploradora();
            log.TopLevel = false;
            log.Tag = this;
            this.pnl_SobreEnergia.Controls.Add(log);
            log.Show();
        }
        
        private void BtnUtilizacao_Click(object sender, EventArgs e)
        {
            if (this.pnl_SobreEnergia.Controls.Count > 0)
            {
                this.pnl_SobreEnergia.Controls.RemoveAt(0);
            }

            UtilizacaoEnergia log = new UtilizacaoEnergia();
            log.TopLevel = false;
            log.Tag = this;
            this.pnl_SobreEnergia.Controls.Add(log);
            log.Show();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Menu_Inicial form = new Menu_Inicial();
            form.Show();
            Close();
        }
    }
}
