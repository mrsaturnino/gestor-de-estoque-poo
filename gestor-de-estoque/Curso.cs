using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_de_estoque
{
    class Curso : Produto, IEstoque
    {
        public string autor;
        private int vagas; //Segue-se a mesma lógica das outras classes filhas.

        public Curso(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;

        }

        public void Exibir()
        {
            
        }

        public void RegistrarEntrada()
        {
            
        }

        public void RegistrarSaida()
        {
            
        }
    }
}
