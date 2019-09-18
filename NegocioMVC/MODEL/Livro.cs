using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioMVC.Model
{
    public class Livro //add public para q as outras classes possam enxergar
    {
        private int livroId;
        private string titulo;
        private DateTime datapublicacao;
        private Autor autor; // foi criado autor do tipo Autor

        public Livro()
        {
            Autor = new Autor(); //instanciando o autor dentro do construtor
                                 // no momento em que o Livrofor instanciado o livro também será instanciado

            // no momento em que o Livro for instanciado o autor também será instanciado
        }

        public int LivroId { get => livroId; set => livroId = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public DateTime Datapublicacao { get => datapublicacao; set => datapublicacao = value; }
        public Autor Autor { get => autor; set => autor = value; }




        public override string ToString()
        {
            return autor.ToString();
        }
    }
}
