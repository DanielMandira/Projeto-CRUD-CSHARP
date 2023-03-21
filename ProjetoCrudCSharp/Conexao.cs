using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//apontar biblioteca 
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProjetoCrudCSharp
{
    internal class Conexao
    {
        //Declarando variaveis para sincronia com o banco de dados.
        public MySqlConnection conectar;
        public string servidor;
        public string database;
        public string username;
        public string password;
        public string porta;

        public Conexao()
        {
            inicializar();//Chama o método para inicializar a conexão com o banco de dados.
        }
        public void inicializar()
        {
            servidor = "127.0.0.1";//Endereço de IP do Servidor de banco de Dados.
            database = "meuPrimeiroCRUD";//Nome do Banco de dados.
            username = "root";//Nome do usuario do bando de dados.
            password = "";//Senha do Banco de Dados.
            porta = "3306";

            //Crair variavel para conexao
            string conexaoString;
            conexaoString = "SERVER=" +servidor+";"+"DATABASE="+database+";"+"UID="+username+";"+"PASSWORD="+password+";"+"PORT="+porta+";";
            //Cahamada da string de conexao.
            conectar = new MySqlConnection(conexaoString);
        }
        public bool abrirConexao()
        {
            try
            {
                conectar.Open();
                return true;
            }
            catch(MySqlException ex)//Mensagens possiveis de erro de conexão.
            {
                switch (ex.Number)
                {
                    case 0:
                        System.Windows.Forms.MessageBox.Show("Não foi possivel conectar!");
                        break;
                    case 1045:
                        System.Windows.Forms.MessageBox.Show("Usuario e Senha Invalidos!");
                        break;

                }
                return false;
            }
        }
        public bool fecharConexao()
        {
            try
            {
                conectar.Close();
                return true;
            }
            catch(MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
