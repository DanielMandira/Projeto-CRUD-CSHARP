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
    internal class Class_Pessoas : Conexao
    {
        //DECLARAR AS VARIAVEIS PRIVADAS PARA O USO NA CLASSE
        private int _idx;
        private string _nome;
        private string _endereco;
        private string _celular;

        //CRIAR OS METODOS GET & SET PARA OS ATRIBUTOS
        public void set_idx(int idx)
        {
            this._idx = idx;
        }
        public int get_idx()
        {
            return _idx;
        }
        public void set_nome (string nome)
        {
            this._nome = nome;
        }
        public string get_nome()
        {
            return this._nome;
        }

        public void set_endereco(string endereco)
        {
            this._endereco = endereco;
        }
        public string get_endereco()
        {
            return this._endereco;
        }
        public void set_celular(string celular)
        {
            this._celular = celular;
        }
        public string get_celular()
        {
            return this._celular;
        }
        
        //CRIAR O METODO DE INSERIR CLIENTE
        public void inserir()
        {
            //CRIAR A QUERY DE INSERÇÃO DE REGISTRO NO BANCO

            string query = "INSERT INTO pessoas (nome, endereco, celular) VALUES ('"+get_nome()+"','"+get_endereco()+"','"+get_celular()+"')";


            //verificar se conexao aberta
            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }
        public DataTable consultar()
        {
            this.abrirConexao();
            string mSLQ = "SELECT * FROM pessoas";
            MySqlCommand cmd = new MySqlCommand(mSLQ, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.fecharConexao();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void apagar()
        {
            string query = "DELETE FROM pessoas WHERE idx = '" + get_idx() + "'";
            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }
        public void atualizar()
        {
            string query = "UPDATE pessoas SET nome='"+get_nome()+"', endereco='"+get_endereco()+ "', celular = '" + get_celular() + "' WHERE idx = '" + get_idx() + "'";
            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }

    }
}
