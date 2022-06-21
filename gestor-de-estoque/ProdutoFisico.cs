using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_de_estoque
{
    [System.Serializable] //Essa anotação passa para o C# que o tipo de dado "ProdutoFisico" pode ser salvo em arquivos.

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
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {frete}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Estoque: {estoque}");
            Console.WriteLine("=============================");
        }

        public void RegistrarEntrada()
        {
            Console.WriteLine($"Registrar entrada no estoque do produto {nome}");
            Console.WriteLine("Digite a Qtd. que você quer dar entrada: ");
            int entrada = int.Parse(Console.ReadLine());
            estoque = estoque + entrada;
            Console.WriteLine("Entrada registrada.");
            Console.ReadLine();
        }

        public void RegistrarSaida()
        {
            Console.WriteLine($"Registrar saída do produto {nome} do estoque");
            Console.WriteLine("Digite a Qtd. que você quer dar baixa: ");
            int entrada = int.Parse(Console.ReadLine());
            estoque = estoque - entrada;
            Console.WriteLine("Baixa registrada.");
            Console.ReadLine();
        }
    }
}
