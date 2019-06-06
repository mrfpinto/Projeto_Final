using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Voltarbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PassLogin_TextChanged(object sender, EventArgs e)
        {
            PassLogin.UseSystemPasswordChar = true;
        }


        //conectar à base de dados
        private static string _connectionString = "Server=localhost;Database=Projeto_Final;Uid=root;Pwd=;";
        private static MySqlConnection BD = new MySqlConnection(_connectionString);



    } 
}
