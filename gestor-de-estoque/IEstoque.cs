using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_de_estoque
{
    internal interface IEstoque //A interface funcionará como um "contrato" em que todas as classes que estiverem inseridas terão de seguir os termos deste contrato. Ou seja, todos os PRODUTOS cadastrados no ESTOQUE terão de seguir as regras da interface IEstoque.
    {
        void Exibir();
        void RegistrarEntrada();
        void RegistrarSaida();
    }
}
