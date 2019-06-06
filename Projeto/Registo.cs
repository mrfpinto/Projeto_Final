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
    public partial class Registo : Form
    {
        public Registo()
        {
            InitializeComponent();
        }

        private string userName = "";
        private string passWord = "";
        private string email = "";

        //conectar à base de dados
        private static string _connectionString = "Server=localhost;Database=Projeto_Final;Uid=root;Pwd=;";
        private static MySqlConnection DB = new MySqlConnection(_connectionString);

        private void User_Login_Click(object sender, EventArgs e)
        {

        }

        private void userRegisto_TextChanged(object sender, EventArgs e)
        {
            userName = Convert.ToString(User_Registo.Text);
        }
        
        private void passRegisto_TextChanged(object sender, EventArgs e)
        {
            passWord = Convert.ToString(PassRegisto.Text);
        }

         private void EmailRegisto_TextChanged(object sender, EventArgs e)
        {
            email = Convert.ToString(EmailRegisto.Text);
        }

        private void Voltarbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Boolean existeUsername(string user, MySqlCommand inserirDados)
        {
            MySqlDataReader resultado;

            try
            {
                inserirDados.CommandText = "select 1 from users where username=@u";
                inserirDados.Parameters.Add("@u", MySqlDbType.String).Value = Convert.ToString(user);

                resultado = inserirDados.ExecuteReader();

                if (resultado.HasRows)
                {
                    Console.WriteLine("Existe user!");
                    resultado.Close();
                    return true;
                }
                resultado.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro: {ex.Message}");
            }
                        
            return false;
        }

        private void infoOk(string cabeçalho, string msg)
        {
            string mensagem = msg;
            string caption = cabeçalho;
            MessageBoxButtons botao = MessageBoxButtons.OK;
            MessageBox.Show(mensagem, caption, botao);
        }

        private void Registobtn_Click(object sender, EventArgs e)
        {
            //inserir dados na base de dados
            MySqlCommand inserirDados = new MySqlCommand();
            inserirDados.Connection = DB;
            
            try
            {
                //verificar a existência do username
                DB.Open();

                if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(passWord) && !string.IsNullOrEmpty(email))
                {
                    if (existeUsername(Convert.ToString(userName), inserirDados))
                        infoOk("Erro", "Este USERNAME já foi criado");                                       
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro:{ex.Message}");
            }
            finally
            {
                if (DB.State == System.Data.ConnectionState.Open)
                {
                    DB.Close();
                }
            }
        }
    }
}
