using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NegocioMVC.Model; // inserir a ref p/ model p/ poder usar o Livro
using MySql.Data; // inserir as ref p/ o mysql
using MySql.Data.MySqlClient;
using System.Data; // inserir p/ usar o CommandType

namespace NegocioMVC.DAO
{
    class LivroDAO
    {
       


        public Livro BuscaPorId(int id) // o SELECT retorna um valor, que é o livro buscado
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Livro where livroId=@id";

            comando.Parameters.AddWithValue("@id", id);

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            Livro livro = new Livro();//instancia para poder retornar um valor
            if (dr.HasRows)
            {
                dr.Read();
                livro.LivroId = (int)dr["livroId"];
                livro.Titulo = (string)dr["titulo"];
                livro.Datapublicacao = (DateTime)dr["datapublicacao"];
                livro.Autor.AutorId = (int)dr["autorId"];
            }
            else
            {
                livro.LivroId = 0;
                livro.Titulo = "";
                livro.Autor.AutorId = 0;
            }
            return livro;
        }



        public DataTable getDados(string titulo)
        {
            MySqlConnection con = ConexaoBanco.Conectar();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;

            //MySqlCommand cmd = CN.CreateCommand();
            MySqlDataAdapter da;

            comando.CommandText = "Select li.titulo, li.livroid, li.autorid, a.autorid, a.nome from livro li, autor a " +
                " where li.titulo like @titulo and li.autorid = a.autorid";
            try
            {
                comando = new MySqlCommand(comando.CommandText, con);

                comando.Parameters.AddWithValue("@titulo", "%" + titulo + "%");

                
                da = new MySqlDataAdapter(comando);
                //
                DataTable dtDados = new DataTable();
                da.Fill(dtDados);
                return dtDados;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
        }
    }
}