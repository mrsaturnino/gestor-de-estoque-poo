using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_de_estoque
{
    abstract class Produto //Classe pai para todos os tipos de produtos que virão a serem criados.
        //É uma classe abstrata porque ela simplesmente vai ser uma base para a criação das outras. Classes abstratas não podem ser instanciadas.
    {
        public string nome;
        public float preco;
    }
}
