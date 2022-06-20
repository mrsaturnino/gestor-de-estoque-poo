using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_de_estoque
{
    class Ebook : Produto, IEstoque
    {
        public string autor;
        private int vendas; //Aqui, de forma lógica não discutimos o estoque já que um Ebook é um produto digital.

        public Ebook(string nome, float preco, string autor)
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
