using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_de_estoque
{
    [System.Serializable]
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
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: R${preco}");
            Console.WriteLine($"Vendas: {vendas}");
            Console.WriteLine("=============================");
        }

        public void RegistrarEntrada()
        {
            Console.WriteLine("Não é possível registrar entradas em um e-book.");
            Console.ReadLine();
        }

        public void RegistrarSaida()
        {
            Console.WriteLine($"Registrar vendas do e-book {nome}");
            Console.WriteLine("Digite a Qtd. de vendas: ");
            int entrada = int.Parse(Console.ReadLine());
            vendas = vendas - entrada;
            Console.WriteLine("Venda(s) registrada(s).");
            Console.ReadLine();
        }
    }
}
