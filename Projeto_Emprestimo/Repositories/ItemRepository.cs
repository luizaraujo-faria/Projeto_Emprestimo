using MySql.Data.MySqlClient;
using Projeto_Emprestimo.Models;
using Projeto_Emprestimo.Repositories.Contract;

namespace Projeto_Emprestimo.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly string _conexaoMySql;
        public ItemRepository(IConfiguration conf){
            _conexaoMySql = conf.GetConnectionString("ConexaoMySQL");
        }

        public void Cadastrar(Item item)
        {
            using (var conexao = new MySqlConnection(_conexaoMySql))
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("insert into itemEmp values(default, @codEmp, @codLivro);", conexao);

                cmd.Parameters.Add("@codEmp", MySqlDbType.VarChar).Value = item.codEmp;
                cmd.Parameters.Add("@codLivro", MySqlDbType.VarChar).Value = item.codLivro;
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
        }
        public void Atualizar(Item item)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int Id)
        {
            throw new NotImplementedException();
        }

        public Item ObterItens(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> OberTodosItens()
        {
            throw new NotImplementedException();
        }
    }
}
