using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_de_estoque
{
    class Program
    {
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

                if (opInt > 0 && opInt < 7) //Validação da escolha no menu
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
    }
}
