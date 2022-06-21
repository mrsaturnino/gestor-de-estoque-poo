using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_de_estoque
{
    [System.Serializable]
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
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Vagas restantes: {vagas}");
            Console.WriteLine("=============================");
        }

        public void RegistrarEntrada()
        {
            Console.WriteLine($"Adicionar vagas no curso {nome}");
            Console.WriteLine("Digite a Qtd. de vagas que você quer dar entrada: ");
            int entrada = int.Parse(Console.ReadLine());
            vagas = vagas + entrada;
            Console.WriteLine("Entrada registrada.");
            Console.ReadLine();
        }

        public void RegistrarSaida()
        {
            Console.WriteLine($"Registrar preenchimento de vagas do curso {nome}");
            Console.WriteLine("Digite a Qtd. de vagas preenchidas: ");
            int entrada = int.Parse(Console.ReadLine());
            vagas = vagas - entrada;
            Console.WriteLine("Vaga(s) preenchida(s).");
            Console.ReadLine();
        }
    }
}
