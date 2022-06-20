using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }
        //Métodos secundários para o cadastramento de cada produto
        static void CadastrarPFisico()
        {
            Console.WriteLine("CADASTRO DE PRODUTO FÍSICO");
            Console.WriteLine("Nome do produto: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço unitário: ");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Frete: ");
            float frete = float.Parse(Console.ReadLine());

            ProdutoFisico pf = new ProdutoFisico(nome, preco, frete);
            produtos.Add(pf);
        }
    }
}
