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
    public partial class Pagina_Inicial : Form
    {
        public Pagina_Inicial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
        private void Entrarbtn_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            
        }

        private void Registarbtn_Click(object sender, EventArgs e)
        {
            Registo form = new Registo();
            form.Show();
        }
    }
}
