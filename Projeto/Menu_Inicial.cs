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
    public partial class Menu_Inicial : Form
    {
        public Menu_Inicial()
        {
            InitializeComponent();
        }

        private void BtnEolica_Click(object sender, EventArgs e)
        {
            Energias_Renováveis form = new Energias_Renováveis();
            form.Show();
        }

        private void BtnHidrica_Click(object sender, EventArgs e)
        {
            Energias_Renováveis form = new Energias_Renováveis();
            form.Show();
        }

        private void BtnSolar_Click(object sender, EventArgs e)
        {
            Energias_Renováveis form = new Energias_Renováveis();
            form.Show();
        }

        private void BtnAssociacao_Click(object sender, EventArgs e)
        {
            Associacoes form = new Associacoes();
            form.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
