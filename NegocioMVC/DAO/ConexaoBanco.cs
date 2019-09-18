using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//insira essas ref p/ utilizar o mysql
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;


namespace NegocioMVC.DAO
{
    class ConexaoBanco
    {

        public static MySqlConnection Conectar()
        {
            string stringConexao = "SERVER=localhost;DATABASE=negocio;UID=root;PASSWORD=;";
            MySqlConnection conexao = new MySqlConnection(stringConexao);
            conexao.Open();
            return conexao;
        }

        public static void CRUD(MySqlCommand comando)
        {
            MySqlConnection con = Conectar();
            comando.Connection = con;
            comando.ExecuteNonQuery();
            con.Close();
        }

        public static MySqlDataReader Selecionar(MySqlCommand comando)
        {
            MySqlConnection con = Conectar();
            comando.Connection = con;
            MySqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }

    }
}
