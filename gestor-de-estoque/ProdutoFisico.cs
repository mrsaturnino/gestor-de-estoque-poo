using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_de_estoque
{
    //ProdutoFisico é um tipo de produto e também uma classe Filha da classe Pai "Produto".
    class ProdutoFisico : Produto, IEstoque 
    {
        public float frete;
        private int estoque; //Está como "private" para que esta variável não seja alterada acidentalmente, passando assim por uma "validação" para ser alterada.

        public ProdutoFisico(string nome, float preco, float frete)
        {
            this.nome = nome;
            this.preco = preco;
            this.frete = frete;

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
