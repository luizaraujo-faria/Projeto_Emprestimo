using Google.Protobuf;
using Projeto_Emprestimo.Models;

namespace Projeto_Emprestimo.Repositories.Contract
{
    public interface IItemRepository
    {
        //CRUD
        IEnumerable<Item> OberTodosItens();
        void Cadastrar(Item item);
        void Atualizar(Item item);
        Item ObterItens(int Id);
        void Excluir(int Id);
    }
}
