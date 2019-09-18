using NegocioMVC.BO;
using NegocioMVC.DAO;
using NegocioMVC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NegocioMVC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        /////////////////////////////////////LIVRO NOME/////////////////////////////////////

        private void btnBuscaLivroNome_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            LivroBO livroBO = new LivroBO();

            try
            {
                livro.Titulo = txtTitulo.Text;

                LivroDAO dao = new LivroDAO();
                dataGridView1.DataSource = dao.getDados(txtTitulo.Text);
            }
            catch
            {
                MessageBox.Show("Preencha os dados corretamente");
            }

        }



        /////////////////////////////////////LIVRO ID/////////////////////////////////////


        private void btnBuscarLivroID_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            LivroBO livroBO = new LivroBO();


            try
            {
                livro.LivroId = Convert.ToInt16(txtLivroId.Text);
                livroBO.Buscar(livro);


                if (livro.Titulo == "")
                {
                    MessageBox.Show("Livro não encontrado");

                }
                else
                {
                    txtTitulo.Text = livro.Titulo;
                    mskDtPublicacao.Text = Convert.ToString(livro.Datapublicacao);
                    txtIdAutorLivro.Text = Convert.ToString(livro.Autor.AutorId);

                }
            }
            catch
            {
                MessageBox.Show("Preencha corretamente as informações");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
