using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace gestor_de_estoque
{
    class Program
    {
        static List<IEstoque> produtos = new List<IEstoque>();
        //"static" porque os métodos/funções que criamos para cadastrar os produtos são estáticos.
        //Tipo "IEstoque" porque a lista irá aceitar qualquer tipo de dado que respeite o contrato imposto pela interface. Assim, qualquer classe nova que criarmos poderá cadastrar novos produtos sem problemas, ja que estarão inseridas na interface.

        enum Menu { Listar = 1, Adicionar, Remover, Entrada, Saida, Sair}
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair) //ENQUANTO o "while" for verdadeiro, o programa será executado.
            {
                Console.WriteLine("[ SISTEMA DE ESTOQUE ]");
                Console.WriteLine("1 - Listar\n2 - Adicionar\n3 - Remover\n4 - Registrar entrada\n5 - Registrar saída\n6 - Sair");

                //Capturando a opção do menu escolhida pelo usuário.
                string opStr = Console.ReadLine();
                int opInt = int.Parse(opStr);

                if (opInt > 0 && opInt < 7) //Validação da escolha no menu, para evitar que o usuario insira um numero diferente dos disponiveis.
                {
                    Menu escolha = (Menu)opInt; //Casting para converter o numero inteiro digitado em uma opção/índice do menu (Enum) que será interpretada no switch abaixo.

                    switch (escolha)
                    {
                        case Menu.Listar:
                            break;
                        case Menu.Adicionar:
                            Cadastro();
                            break;
                        case Menu.Remover:
                            break;
                        case Menu.Entrada:
                            break;
                        case Menu.Saida:
                            break;
                        case Menu.Sair:
                            escolheuSair = true;
                            break;
                    }
                }
                else
                {
                    escolheuSair = true;
                }

                Console.Clear(); 
            }
        }

        static void Cadastro() //Método principal para o cadastramento geral de produtos.
        {
            Console.WriteLine("Cadastro de Produto");
            Console.WriteLine("1 - Produto Físico\n2 - Ebook\n3 - Curso");
            string opStr = Console.ReadLine();
            int escolhaInt = int.Parse(opStr);

            switch (escolhaInt)
            {
                case 1:
                    CadastrarPFisico();
                    break;
                case 2:
                    CadastrarEbook();
                    break;
                case 3:
                    CadastrarCurso();
                    break;
            }
        }
        //Métodos secundários para o cadastramento de cada tipo produto
        static void CadastrarPFisico()
        {
            Console.WriteLine("CADASTRO DE PRODUTO FÍSICO");
            Console.WriteLine("Nome do produto: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço unitário: ");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Frete: ");
            float frete = float.Parse(Console.ReadLine());

            //Criando um objeto que contém as informações das variáveis que foram alimentadas pelo usuário; O construtor criado para a classe auxilia ao passar estas informações.
            ProdutoFisico pf = new ProdutoFisico(nome, preco, frete);
            produtos.Add(pf); //aqui adicionamos o objeto criado à lista de produtos.
            Salvar();

            //Ou seja, toda vez que o usuário cadastrar um produto, será criado um objeto e este objeto será adicionado à lista.
        }

        static void CadastrarEbook()
        {
            Console.WriteLine("CADASTRO DE EBOOK");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Autor: ");
            string autor = Console.ReadLine();
            
            Ebook eb = new Ebook(nome, preco, autor);
            produtos.Add(eb);
            Salvar();
        }

        static void CadastrarCurso()
        {
            Console.WriteLine("CADASTRO DE CURSO");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Autor: ");
            string autor = Console.ReadLine();

            Curso cs = new Curso(nome, preco, autor);
            produtos.Add(cs);
            Salvar();
        }

        static void Salvar() //Método para salvamento dos dados no arquivo do programa.
        {
            //criando um arquivo binário no projeto
            FileStream stream = new FileStream("produtos.dat", FileMode.OpenOrCreate); //"OpenOrCreate" para abrir o arquivo "produtos.dat" caso ele exista, ou criá-lo caso não exista.
            BinaryFormatter encoder = new BinaryFormatter(); //pega os dados que serão salvos e os guarda de forma binária no arquivo.

            encoder.Serialize(stream, produtos); //passando os dados que serão salvos no arquivo

            stream.Close(); //fechando a operação de stream.
        }
    }
}
