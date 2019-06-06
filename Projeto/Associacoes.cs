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
    public partial class Associacoes : Form
    {
        public Associacoes()
        {
            InitializeComponent();
        }

        private void Voltarbtn_Click(object sender, EventArgs e)
        {
            Menu_Inicial form = new Menu_Inicial();
            form.Show();
            Close();
        }
    }
}
